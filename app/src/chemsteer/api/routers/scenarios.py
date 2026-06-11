from __future__ import annotations

from fastapi import APIRouter, HTTPException
from sqlalchemy import select

from chemsteer.api.schemas.registry import (
    GenericScenarioDetail,
    GenericScenarioOut,
    ScenarioActivityOut,
    ScenarioModelOut,
)
from chemsteer.calc.dispatch import EXPOSURE_MODELS, RELEASE_MODELS
from chemsteer.db.seed import session
from chemsteer.db.seed_models import (
    GenericScenario,
    ScenActExpModel,
    ScenActRelModel,
    ScenarioActivity,
)

router = APIRouter(prefix="/api/scenarios", tags=["scenarios"])


@router.get("", response_model=list[GenericScenarioOut])
def list_scenarios() -> list[GenericScenarioOut]:
    """The 34 Generic Scenarios shipped in scenarios.epa::Operations."""
    with session("scenarios") as s:
        rows = s.execute(select(GenericScenario).order_by(GenericScenario.OpID)).scalars().all()
        return [GenericScenarioOut.model_validate(r) for r in rows]


def _f(raw: str | None) -> float:
    try:
        return float(raw or 0.0)
    except ValueError:
        return 0.0


def _output_labels(row: ScenActRelModel | ScenActExpModel) -> list[str | None]:
    labels: list[str | None] = []
    if _f(row.OutputOn1):
        labels.append(row.Char1 or None)
    if _f(row.OutputOn2):
        labels.append(row.Char2 or None)
    return labels or [row.Char1 or None]


@router.get("/{scenario_id}", response_model=GenericScenarioDetail)
def get_scenario(scenario_id: int) -> GenericScenarioDetail:
    """One Generic Scenario with its activity / model template tree."""
    sid = str(scenario_id)
    with session("scenarios") as s:
        scen = (
            s.execute(select(GenericScenario).where(GenericScenario.ScenarioID == sid))
            .scalars()
            .first()
        )
        if scen is None:
            raise HTTPException(404, f"no Generic Scenario with ScenarioID={scenario_id}")
        acts = (
            s.execute(select(ScenarioActivity).where(ScenarioActivity.ScenarioID == sid))
            .scalars()
            .all()
        )
        rels = (
            s.execute(select(ScenActRelModel).where(ScenActRelModel.ScenarioID == sid))
            .scalars()
            .all()
        )
        exps = (
            s.execute(select(ScenActExpModel).where(ScenActExpModel.ScenarioID == sid))
            .scalars()
            .all()
        )

    models_by_act: dict[int, list[ScenarioModelOut]] = {}
    for rel in rels:
        models_by_act.setdefault(int(_f(rel.ScenActID)), []).append(
            ScenarioModelOut(
                model_id=int(_f(rel.ModelID)),
                model_kind="release",
                implemented=int(_f(rel.ModelID)) in RELEASE_MODELS,
                output_labels=_output_labels(rel),
            )
        )
    for exp in exps:
        models_by_act.setdefault(int(_f(exp.ScenActID)), []).append(
            ScenarioModelOut(
                model_id=int(_f(exp.ModelID)),
                model_kind="exposure",
                implemented=int(_f(exp.ModelID)) in EXPOSURE_MODELS,
                output_labels=_output_labels(exp),
            )
        )

    activities = [
        ScenarioActivityOut(
            scen_act_id=int(_f(a.ScenActID)),
            act_id=int(_f(a.ActID)),
            name=a.ActName or None,
            models=models_by_act.get(int(_f(a.ScenActID)), []),
        )
        for a in sorted(acts, key=lambda a: _f(a.ActOrder))
    ]
    detail = GenericScenarioDetail.model_validate(scen)
    return detail.model_copy(update={"activities": activities})
