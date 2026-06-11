"""Build a structured report payload from an assessment.

Centralises the data-shaping logic so HTML, PDF, CSV, and JSON exporters
can all consume the same dict.
"""

from __future__ import annotations

import json
from datetime import UTC, datetime
from typing import Any

from sqlalchemy import select

from chemsteer.db.user import (
    Assessment,
    AssessmentActivity,
    AssessmentOperation,
    ModelRun,
    user_session,
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
            "operations": [
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
            ],
            "generated_at": datetime.now(UTC).isoformat(),
        }


def _run_dict(r: ModelRun) -> dict[str, Any]:
    return {
        "id": r.id,
        "model_id": r.model_id,
        "model_kind": r.model_kind,
        "label": r.label,
        "inputs": json.loads(r.inputs_json) if r.inputs_json else {},
        "outputs": json.loads(r.outputs_json) if r.outputs_json else None,
        "last_run_at": r.last_run_at.isoformat() if r.last_run_at else None,
    }
