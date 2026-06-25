"""Build a structured report payload from an assessment.

Centralises the data-shaping logic so HTML, PDF, CSV, and JSON exporters
can all consume the same dict.
"""

from __future__ import annotations

import json
from datetime import UTC, datetime
from typing import Any

from sqlalchemy import select, text

from chemsteer.db.seed import get_engine
from chemsteer.db.user import (
    Assessment,
    AssessmentActivity,
    AssessmentOperation,
    ChemicalRecord,
    ModelRun,
    user_session,
)


def sci1(v: float) -> str:
    """v3.2's ``ShowInSciNot1digit`` — two significant figures with a
    bare exponent, e.g. ``6.5E+1`` (ChemStrX.cs:4566)."""
    if v == 0:
        return "0.0E+0"
    mant, exp = f"{v:.1E}".split("E")
    return f"{mant}E{int(exp):+d}"


def _media_names() -> dict[int, tuple[str, int]]:
    """{MediaID: (name, sort)} from the seed ListOfMedia."""
    with get_engine("chmsteer").connect() as con:
        rows = con.execute(text('SELECT "MediaID", "Media", "SortID" FROM "ListOfMedia"')).all()
    return {int(m): (name or "", int(sort or 0)) for m, name, sort in rows}


def _release_summary(operations: list[dict[str, Any]]) -> list[dict[str, Any]]:
    """Per-operation releases split across media — the IRER's release
    summary. v3.2 partitions each run's daily/annual release rate by its
    media percentages (``DRR_media = DRR × pct/100``, DBFuncs.cs:6602)
    and sums across the operation's activities per (media,
    characterization) (DBFuncs.cs:6674)."""
    media_names = _media_names()
    rows: dict[tuple[int, int, str], dict[str, Any]] = {}
    for op in operations:
        for act in op["activities"]:
            for r in act["runs"]:
                if r["model_kind"] != "release" or not r["outputs"]:
                    continue
                dr = (r["outputs"].get("DR") or {}).get("value")
                ar = (r["outputs"].get("AR") or {}).get("value")
                if dr is None:
                    continue
                split = {int(m): p for m, p in (r.get("media") or {}).items()} or {-1: 100.0}
                label = r["label"] or ""
                for media_id, pct in split.items():
                    key = (op["id"], media_id, label)
                    row = rows.setdefault(
                        key,
                        {
                            "op_id": op["op_id"],
                            "op_name": op["name"],
                            "media_id": media_id,
                            "media": media_names.get(media_id, ("(unassigned)", 99))[0]
                            if media_id >= 0
                            else "(unassigned)",
                            "label": label or None,
                            "drr_kg_day": 0.0,
                            "arr_kg_yr": 0.0,
                            "activities": [],
                        },
                    )
                    row["drr_kg_day"] += dr * pct / 100.0
                    if ar is not None:
                        row["arr_kg_yr"] += ar * pct / 100.0
                    if act["name"] and act["name"] not in row["activities"]:
                        row["activities"].append(act["name"])
    return sorted(
        rows.values(),
        key=lambda r: (
            r["op_id"],
            media_names.get(r["media_id"], ("", 99))[1] if r["media_id"] >= 0 else 99,
            r["label"] or "",
        ),
    )


def build_report(assessment_id: int) -> dict[str, Any]:
    """Build the canonical report dict for a given assessment.

    The returned shape::

        {
          "assessment": {id, name, chemical_name, cas_number, notes,
                          created_at, updated_at},
          "operations": [
            {
              "id", "op_id", "name",
              "activities": [
                {
                  "id", "act_id", "name",
                  "runs": [
                    {
                      "id", "model_id", "model_kind",
                      "inputs": {...}, "outputs": {...} | None,
                      "last_run_at": ...
                    }
                  ]
                }
              ]
            }
          ],
          "generated_at": ISO timestamp
        }
    """
    with user_session() as s:
        from sqlalchemy.orm import selectinload

        a = s.execute(
            select(Assessment)
            .where(Assessment.id == assessment_id)
            .options(
                selectinload(Assessment.operations)
                .selectinload(AssessmentOperation.activities)
                .selectinload(AssessmentActivity.model_runs)
            )
        ).scalar_one_or_none()

        if a is None:
            raise KeyError(f"assessment {assessment_id} not found")

        chem = s.execute(
            select(ChemicalRecord).where(ChemicalRecord.assessment_id == assessment_id)
        ).scalar_one_or_none()

        operations = [
            {
                "id": op.id,
                "op_id": op.op_id,
                "name": op.name,
                "activities": [
                    {
                        "id": act.id,
                        "act_id": act.act_id,
                        "name": act.name,
                        "runs": [_run_dict(r) for r in act.model_runs],
                    }
                    for act in op.activities
                ],
            }
            for op in a.operations
        ]

        return {
            "assessment": {
                "id": a.id,
                "name": a.name,
                "chemical_name": a.chemical_name,
                "cas_number": a.cas_number,
                "notes": a.notes,
                "created_at": a.created_at.isoformat() if a.created_at else None,
                "updated_at": a.updated_at.isoformat() if a.updated_at else None,
            },
            "chemical": _chemical_dict(chem),
            "operations": operations,
            "release_summary": _release_summary(operations),
            "generated_at": datetime.now(UTC).isoformat(),
        }


def _chemical_dict(c: ChemicalRecord | None) -> dict[str, Any] | None:
    if c is None:
        return None
    return {
        "mol_formula": c.mol_formula,
        "trade_names": c.trade_names,
        "category": c.category,
        "mw": c.mw,
        "vp_torr": c.vp_torr,
        "vp_temp_c": c.vp_temp_c,
        "density_kg_l": c.density_kg_l,
        "density_temp_c": c.density_temp_c,
        "solubility_g_l": c.solubility_g_l,
        "sol_temp_c": c.sol_temp_c,
        "melting_point_c": c.melting_point_c,
        "boiling_point_c": c.boiling_point_c,
        "production_volume_kg_yr": c.production_volume_kg_yr,
        "physical_state": c.physical_state,
    }


def _run_dict(r: ModelRun) -> dict[str, Any]:
    return {
        "id": r.id,
        "model_id": r.model_id,
        "model_kind": r.model_kind,
        "label": r.label,
        "inputs": json.loads(r.inputs_json) if r.inputs_json else {},
        "outputs": json.loads(r.outputs_json) if r.outputs_json else None,
        "media": json.loads(r.media_json) if r.media_json else None,
        "last_run_at": r.last_run_at.isoformat() if r.last_run_at else None,
    }
