"""Read a ChemSTEER v3.2 ``.cs2`` user-assessment file and ETL into our
user-DB schema.

A ``.cs2`` is just a renamed Microsoft Access database with the
MDBShell.epa schema. We extract its `Assessments`, `Operations`,
`Activities`, `ActRelModels`, `ActExpModels`, and the per-(activity,
model) parameter rows, then create new rows in the user DB.

This is *read-only import* (Phase 5 scope) — we don't preserve
v3.2-specific calc state (cached outputs, mass-balance flags, etc.). The
imported assessment shows up as a fresh assessment with attached ops/
activities/runs; users re-run /calc to populate outputs.
"""

from __future__ import annotations

import csv
import io
import json
import shutil
import subprocess
from dataclasses import dataclass
from pathlib import Path

from chemsteer.calc.dispatch import EXPOSURE_MODELS, RELEASE_MODELS
from chemsteer.db.user import (
    Assessment,
    AssessmentActivity,
    AssessmentOperation,
    ModelRun,
    user_session,
)


class Cs2ImportError(RuntimeError):
    pass


@dataclass
class ImportResult:
    assessment_id: int
    name: str
    n_operations: int
    n_activities: int
    n_runs: int
    skipped_runs: list[str]


def _have_mdb_export() -> bool:
    return shutil.which("mdb-export") is not None


def _read_table(cs2_path: Path, table: str) -> list[dict[str, str]]:
    """Run mdb-export on a single table and return rows as dicts."""
    result = subprocess.run(
        ["mdb-export", "-Q", "-d", "\t", str(cs2_path), table],
        capture_output=True,
        text=True,
        check=False,
    )
    if result.returncode != 0:
        # Table doesn't exist or file isn't an Access DB.
        return []
    if not result.stdout.strip():
        return []
    reader = csv.DictReader(io.StringIO(result.stdout), delimiter="\t")
    return list(reader)


def import_cs2(cs2_path: Path | str, *, name_override: str | None = None) -> ImportResult:
    """Import a v3.2 .cs2 file. Returns an ImportResult with counts."""
    if not _have_mdb_export():
        raise Cs2ImportError(
            "mdb-export (mdbtools) not found on PATH; install with `apt install mdbtools`"
        )
    p = Path(cs2_path)
    if not p.exists():
        raise Cs2ImportError(f"file not found: {p}")

    # Pull source data
    src_assessments = _read_table(p, "Assessments")
    src_chemicals = _read_table(p, "Chemicals")
    src_operations = _read_table(p, "Operations")
    src_activities = _read_table(p, "Activities")
    src_rel_models = _read_table(p, "ActRelModels")
    src_exp_models = _read_table(p, "ActExpModels")
    src_rel_parms = _read_table(p, "ActRelModParms")
    src_exp_parms = _read_table(p, "ActExpModParms")

    if not src_assessments:
        raise Cs2ImportError("no Assessments row found — is this an empty MDBShell template?")

    src_a = src_assessments[0]
    chem = src_chemicals[0] if src_chemicals else {}
    asmt_name = (
        name_override or src_a.get("EPAIDNumber") or chem.get("ChemName") or f"imported {p.name}"
    )

    skipped: list[str] = []
    with user_session() as s:
        a = Assessment(
            name=asmt_name,
            chemical_name=chem.get("ChemName") or None,
            cas_number=chem.get("CAS") or None,
            notes=f"Imported from {p.name}",
        )
        s.add(a)
        s.flush()

        # Build a lookup: (OpID -> AssessmentOperation row)
        op_lookup: dict[str, AssessmentOperation] = {}
        for src_op in src_operations:
            op_id_raw = src_op.get("OpID", "").strip()
            if not op_id_raw:
                continue
            op = AssessmentOperation(
                assessment_id=a.id,
                op_id=int(float(op_id_raw)),
                name=src_op.get("OpName") or None,
                sort_order=int(float(src_op.get("OpOrder", "0") or "0")),
            )
            s.add(op)
            s.flush()
            op_lookup[op_id_raw] = op

        # Activities — keyed by ScenActID in v3.2
        act_lookup: dict[str, AssessmentActivity] = {}
        for src_act in src_activities:
            scen_act = src_act.get("ScenActID", "").strip()
            op_id = src_act.get("OpID", "").strip()
            if not scen_act or op_id not in op_lookup:
                continue
            act = AssessmentActivity(
                operation_id=op_lookup[op_id].id,
                act_id=int(float(src_act.get("ActID", "0") or "0")),
                name=src_act.get("ActName") or None,
                sort_order=int(float(src_act.get("ActOrder", "0") or "0")),
            )
            s.add(act)
            s.flush()
            act_lookup[scen_act] = act

        # Build ModelRun rows from rel + exp model tables, joining their
        # parameter rows on the per-table primary key (RelParmsAN /
        # ExpParmsAN) into a {ParmAbbr: value} dict per run.
        n_runs = 0

        def _params_for(parm_an_value: str, src_parms: list[dict[str, str]]) -> dict[str, float]:
            """Collect parameter rows for a (Rel|Exp)ParmsAN into a dict."""
            return {
                row["ParmID"]: float(row.get("ParmValue", "0") or 0.0)
                for row in src_parms
                if row.get("RelParmsAN", "") == parm_an_value
                or row.get("ExpParmsAN", "") == parm_an_value
            }

        for src_rel in src_rel_models:
            scen_act = src_rel.get("ScenActID", "").strip()
            model_id_raw = src_rel.get("ModelID", "").strip()
            parm_an = src_rel.get("RelParmsAN", "").strip()
            if not scen_act or not model_id_raw or scen_act not in act_lookup:
                continue
            try:
                model_id = int(float(model_id_raw))
            except ValueError:
                continue
            if model_id not in RELEASE_MODELS:
                skipped.append(f"release model {model_id} not implemented")
                continue
            inputs = _params_for(parm_an, src_rel_parms)
            run = ModelRun(
                activity_id=act_lookup[scen_act].id,
                model_id=model_id,
                model_kind="release",
                inputs_json=json.dumps(inputs),
            )
            s.add(run)
            n_runs += 1

        for src_exp in src_exp_models:
            scen_act = src_exp.get("ScenActID", "").strip()
            model_id_raw = src_exp.get("ModelID", "").strip()
            parm_an = src_exp.get("ExpParmsAN", "").strip()
            if not scen_act or not model_id_raw or scen_act not in act_lookup:
                continue
            try:
                model_id = int(float(model_id_raw))
            except ValueError:
                continue
            if model_id not in EXPOSURE_MODELS:
                skipped.append(f"exposure model {model_id} not implemented")
                continue
            inputs = _params_for(parm_an, src_exp_parms)
            run = ModelRun(
                activity_id=act_lookup[scen_act].id,
                model_id=model_id,
                model_kind="exposure",
                inputs_json=json.dumps(inputs),
            )
            s.add(run)
            n_runs += 1

        s.flush()
        return ImportResult(
            assessment_id=a.id,
            name=asmt_name,
            n_operations=len(op_lookup),
            n_activities=len(act_lookup),
            n_runs=n_runs,
            skipped_runs=skipped,
        )
