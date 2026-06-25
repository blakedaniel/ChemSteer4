"""Instantiate a Generic Scenario template into a user assessment.

This is the web-app equivalent of picking one of the 34 shipped Generic
Scenarios in ChemSTEER v3.2: the scenario's operation appears on the
assessment with its activities and pre-parameterized release/exposure
model runs attached, ready to calculate.

Parameter resolution mirrors the original's "calculate defaults" flow.
For each run, ``{ParmID: value}`` dicts merge lowest-to-highest
precedence:

1. ``ParmDefaults`` (chmsteer.db) resolved for (model, activity, GS op)
2. ``OpParms`` (scenarios.db) — operation-level values the GS ships
3. per-(model, output) rows from ``ActRelModParms`` / ``ActExpModParms``

then translate to calc-input fields via :mod:`chemsteer.calc.parm_map`.
Fields the original leaves for the user (e.g. number of sites) stay
absent; the per-run calc surfaces them as validation errors, matching
v3.2's "missing required parameter" prompts.

Some scenarios (e.g. the cooling-tower GS) attach no explicit model
rows; the original auto-attaches each activity's default models from
``ListOfActivities`` (negative IDs there mean "suggested, off by
default" and are skipped). We reproduce that fallback.

A v3.2 model row can enable up to two output characterizations
(``OutputOn1``/``OutputOn2``, labelled by ``Char1``/``Char2`` — e.g.
"Central Tendency" and "High End") with separate parameter sets keyed by
``OutputID`` 0/1. Each enabled output becomes its own ``ModelRun`` with
the characterization stored in ``ModelRun.label``.
"""

from __future__ import annotations

import json
from dataclasses import dataclass, field

from sqlalchemy import select
from sqlalchemy.orm import Session

from chemsteer.calc.defaults import ChemicalProps, defaults_for, media_defaults_for
from chemsteer.calc.dispatch import EXPOSURE_MODELS, RELEASE_MODELS
from chemsteer.calc.parm_map import map_parms
from chemsteer.db.seed import session as seed_session
from chemsteer.db.seed_models import (
    GenericScenario,
    ListOfActivities,
    ScenActExpModel,
    ScenActExpModParm,
    ScenActRelModel,
    ScenActRelModMedia,
    ScenActRelModParm,
    ScenarioActivity,
    ScenOpParm,
)
from chemsteer.db.user import AssessmentActivity, AssessmentOperation, ModelRun

OD_PARM = 2  # Number of Operating Days (days/site-yr)
FREQ_PARM = 72  # Frequency of Use (days/site-yr)
DRRCHEM_PARM = 130  # Daily recirculation rate of chemical (kg/site-day)
COOLING_TOWER_MODELS = frozenset({12, 13, 14})


class ScenarioNotFoundError(LookupError):
    pass


@dataclass
class InstantiateResult:
    operation: AssessmentOperation
    n_activities: int
    n_runs: int
    skipped_runs: list[str] = field(default_factory=list)


def _f(raw: str | None) -> float:
    try:
        return float(raw or 0.0)
    except ValueError:
        return 0.0


def _truthy(raw: str | None) -> bool:
    # Access booleans dump as 0 / 1 / -1.
    return _f(raw) != 0.0


def _enabled_outputs(row: ScenActRelModel | ScenActExpModel) -> list[tuple[str, str | None]]:
    """(OutputID, label) for each enabled output; OutputID 0 ↔ Output1."""
    outputs: list[tuple[str, str | None]] = []
    if _truthy(row.OutputOn1):
        outputs.append(("0", row.Char1 or None))
    if _truthy(row.OutputOn2):
        outputs.append(("1", row.Char2 or None))
    return outputs or [("0", row.Char1 or None)]


def _merge_parms(
    model_kind: str,
    model_id: int,
    act_id: int,
    gss_op_id: int,
    op_parms: dict[int, float],
    row_parms: dict[int, float],
    output: int = 0,
    chemical: ChemicalProps | None = None,
) -> dict[int, float]:
    """Defaults < op-level parms < per-model rows; zeros never override."""
    merged = dict(
        defaults_for(model_id, act_id=act_id, gss_id=gss_op_id, output=output, chemical=chemical)
    )
    for src in (op_parms, row_parms):
        for pid, value in src.items():
            if value != 0.0:
                merged[pid] = value

    # frmMDUpdOpIP: DRRchem = RRctw(126) × Yctw(124) × HD(35) × Dctw(125) × 60
    if (
        model_kind == "release"
        and model_id in COOLING_TOWER_MODELS
        and not merged.get(DRRCHEM_PARM)
    ):
        rr, yctw, hd, dctw = (merged.get(p, 0.0) for p in (126, 124, 35, 125))
        if rr and yctw and hd and dctw:
            merged[DRRCHEM_PARM] = rr * yctw * hd * dctw * 60.0

    # Release frequency falls back to the operation's operating days.
    if model_kind == "release" and not merged.get(FREQ_PARM) and merged.get(OD_PARM):
        merged[FREQ_PARM] = merged[OD_PARM]
    return merged


def _default_model_ids(act_row: ListOfActivities | None, kind: str) -> list[int]:
    """Positive default ModelIDs from the activity registry (negative =
    suggested-but-off in v3.2; skipped)."""
    if act_row is None:
        return []
    if kind == "release":
        raw = [act_row.DefaultRelModel, act_row.DefaultRelModel2, act_row.DefaultRelModel3]
    else:
        raw = [act_row.DefaultInhModel, act_row.DefaultDrmModel]
    return [int(v) for v in (_f(r) for r in raw) if v > 0]


def instantiate_scenario(
    s: Session,
    assessment_id: int,
    scenario_id: int,
    chemical: ChemicalProps | None = None,
) -> InstantiateResult:
    """Attach the Generic Scenario's operation tree to an assessment.

    ``s`` is an open user-DB session (the caller owns the transaction so
    it can wrap this in its revision bookkeeping). ``chemical`` is the
    assessment's chemical record, feeding the VP/MW/solubility defaults.
    """
    sid = str(scenario_id)
    skipped: list[str] = []

    with seed_session("scenarios") as seed:
        scen = (
            seed.execute(select(GenericScenario).where(GenericScenario.ScenarioID == sid))
            .scalars()
            .first()
        )
        if scen is None:
            raise ScenarioNotFoundError(f"no Generic Scenario with ScenarioID={scenario_id}")

        activities = (
            seed.execute(select(ScenarioActivity).where(ScenarioActivity.ScenarioID == sid))
            .scalars()
            .all()
        )
        rel_models = (
            seed.execute(select(ScenActRelModel).where(ScenActRelModel.ScenarioID == sid))
            .scalars()
            .all()
        )
        exp_models = (
            seed.execute(select(ScenActExpModel).where(ScenActExpModel.ScenarioID == sid))
            .scalars()
            .all()
        )
        rel_parms = (
            seed.execute(
                select(ScenActRelModParm).where(
                    ScenActRelModParm.RelParmsAN.in_([m.RelParmsAN for m in rel_models])
                )
            )
            .scalars()
            .all()
        )
        exp_parms = (
            seed.execute(
                select(ScenActExpModParm).where(
                    ScenActExpModParm.ExpParmsAN.in_([m.ExpParmsAN for m in exp_models])
                )
            )
            .scalars()
            .all()
        )
        op_parm_rows = (
            seed.execute(select(ScenOpParm).where(ScenOpParm.ScenarioID == sid)).scalars().all()
        )
        media_rows = (
            seed.execute(select(ScenActRelModMedia).where(ScenActRelModMedia.ScenarioID == sid))
            .scalars()
            .all()
        )

    # GS-shipped media splits, keyed by (ScenActID, RelModID).
    media_by_key: dict[tuple[str, str], dict[int, float]] = {}
    for mr in media_rows:
        pct = _f(mr.Pct)
        if pct != 0.0:
            media_by_key.setdefault((mr.ScenActID, mr.RelModID), {})[int(_f(mr.MediaID))] = pct

    # Operation-level parms the GS ships (zeros = user-to-fill, dropped).
    op_parms: dict[int, float] = {}
    for opp in op_parm_rows:
        val = _f(opp.ParmValue)
        if val != 0.0:
            op_parms[int(_f(opp.ParmID))] = val

    # Activity registry rows for default-model fallback.
    act_ids = sorted({int(_f(a.ActID)) for a in activities})
    with seed_session("chmsteer") as chm:
        registry_rows = (
            chm.execute(
                select(ListOfActivities).where(
                    ListOfActivities.ActID.in_([str(i) for i in act_ids])
                )
            )
            .scalars()
            .all()
        )
    registry_by_act = {int(_f(r.ActID)): r for r in registry_rows}

    # Group parm rows by (ParmsAN, OutputID) → {ParmID: value}
    rel_parms_by_key: dict[tuple[str, str], dict[int, float]] = {}
    for p in rel_parms:
        rel_parms_by_key.setdefault((p.RelParmsAN, p.OutputID), {})[int(_f(p.ParmID))] = _f(
            p.ParmValue
        )
    exp_parms_by_key: dict[tuple[str, str], dict[int, float]] = {}
    for ep in exp_parms:
        exp_parms_by_key.setdefault((ep.ExpParmsAN, ep.OutputID), {})[int(_f(ep.ParmID))] = _f(
            ep.ParmValue
        )

    gss_op_id = int(_f(scen.OpID))
    op = AssessmentOperation(
        assessment_id=assessment_id,
        op_id=gss_op_id,
        name=scen.OpName or None,
        sort_order=int(_f(scen.OpOrder)),
    )
    s.add(op)
    s.flush()

    act_by_scen_act: dict[str, AssessmentActivity] = {}
    for src in sorted(activities, key=lambda a: _f(a.ActOrder)):
        act = AssessmentActivity(
            operation_id=op.id,
            act_id=int(_f(src.ActID)),
            name=src.ActName or None,
            sort_order=int(_f(src.ActOrder)),
        )
        s.add(act)
        s.flush()
        act_by_scen_act[src.ScenActID] = act

    n_runs = 0

    def _add_run(
        activity: AssessmentActivity,
        kind: str,
        model_id: int,
        label: str | None,
        row_parms: dict[int, float],
        rel_days: float = 0.0,
        output: int = 0,
        media: dict[int, float] | None = None,
    ) -> None:
        nonlocal n_runs
        merged = _merge_parms(
            kind,
            model_id,
            activity.act_id,
            gss_op_id,
            op_parms,
            row_parms,
            output=output,
            chemical=chemical,
        )
        inputs, _unmapped = map_parms(kind, model_id, merged)
        # v3.2 also stores release frequency on the model row (RelDays /
        # RelDays2); it wins over op-level fallbacks when filled in.
        if kind == "release" and rel_days:
            inputs["Freq"] = rel_days
        # Media split: scenario rows win, else the model's MediaDefaults.
        media_json: str | None = None
        if kind == "release":
            split = media or media_defaults_for(model_id)
            if split:
                media_json = json.dumps({str(m): p for m, p in split.items()})
        s.add(
            ModelRun(
                activity_id=activity.id,
                model_id=model_id,
                model_kind=kind,
                label=label,
                inputs_json=json.dumps(inputs),
                media_json=media_json,
            )
        )
        n_runs += 1

    scen_acts_with_rel: set[str] = set()
    scen_acts_with_exp: set[str] = set()

    for rel in rel_models:
        rel_act = act_by_scen_act.get(rel.ScenActID or "")
        if rel_act is None:
            continue
        scen_acts_with_rel.add(rel.ScenActID or "")
        model_id = int(_f(rel.ModelID))
        if model_id not in RELEASE_MODELS:
            skipped.append(f"release model {model_id} not implemented (activity {rel_act.name})")
            continue
        for output_id, label in _enabled_outputs(rel):
            row_parms = rel_parms_by_key.get((rel.RelParmsAN, output_id), {})
            rel_days = _f(rel.RelDays if output_id == "0" else rel.RelDays2)
            _add_run(
                rel_act,
                "release",
                model_id,
                label,
                row_parms,
                rel_days,
                output=int(output_id),
                media=media_by_key.get((rel.ScenActID or "", rel.RelModID or "")),
            )

    for exp in exp_models:
        exp_act = act_by_scen_act.get(exp.ScenActID or "")
        if exp_act is None:
            continue
        scen_acts_with_exp.add(exp.ScenActID or "")
        model_id = int(_f(exp.ModelID))
        if model_id not in EXPOSURE_MODELS:
            skipped.append(f"exposure model {model_id} not implemented (activity {exp_act.name})")
            continue
        for output_id, label in _enabled_outputs(exp):
            row_parms = exp_parms_by_key.get((exp.ExpParmsAN, output_id), {})
            _add_run(exp_act, "exposure", model_id, label, row_parms, output=int(output_id))

    # Default-model fallback for activities with no explicit model rows.
    for src in activities:
        activity = act_by_scen_act[src.ScenActID]
        registry = registry_by_act.get(activity.act_id)
        if _truthy(src.DoRel) and src.ScenActID not in scen_acts_with_rel:
            for model_id in _default_model_ids(registry, "release"):
                if model_id not in RELEASE_MODELS:
                    skipped.append(
                        f"release model {model_id} not implemented (activity {activity.name})"
                    )
                    continue
                _add_run(activity, "release", model_id, None, {})
        if _truthy(src.DoExp) and src.ScenActID not in scen_acts_with_exp:
            for model_id in _default_model_ids(registry, "exposure"):
                if model_id not in EXPOSURE_MODELS:
                    skipped.append(
                        f"exposure model {model_id} not implemented (activity {activity.name})"
                    )
                    continue
                _add_run(activity, "exposure", model_id, None, {})

    s.flush()
    return InstantiateResult(
        operation=op,
        n_activities=len(act_by_scen_act),
        n_runs=n_runs,
        skipped_runs=skipped,
    )
