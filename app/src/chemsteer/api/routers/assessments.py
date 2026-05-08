"""CRUD routes for user assessments + nested operations + activities."""

from __future__ import annotations

import json

from fastapi import APIRouter, HTTPException
from sqlalchemy import select
from sqlalchemy.orm import selectinload

from chemsteer.api.schemas.assessment import (
    ActivityCreate,
    ActivityRead,
    AssessmentCreate,
    AssessmentRead,
    AssessmentSummary,
    AssessmentUpdate,
    OperationCreate,
    OperationRead,
    RevisionRead,
)
from chemsteer.db.user import (
    Assessment,
    AssessmentActivity,
    AssessmentOperation,
    Revision,
    user_session,
)

router = APIRouter(prefix="/api/assessments", tags=["assessments"])


# --- Helpers --------------------------------------------------------------


def _snapshot(a: Assessment) -> dict[str, object]:
    """Build a JSON-serializable snapshot of an assessment for revisions."""
    return {
        "id": a.id,
        "name": a.name,
        "chemical_name": a.chemical_name,
        "cas_number": a.cas_number,
        "notes": a.notes,
        "operations": [
            {
                "id": op.id,
                "op_id": op.op_id,
                "name": op.name,
                "sort_order": op.sort_order,
                "activities": [
                    {
                        "id": act.id,
                        "act_id": act.act_id,
                        "name": act.name,
                        "sort_order": act.sort_order,
                    }
                    for act in op.activities
                ],
            }
            for op in a.operations
        ],
    }


def _save_revision(s, a: Assessment, summary: str) -> None:  # type: ignore[no-untyped-def]
    rev = Revision(
        assessment_id=a.id,
        summary=summary,
        snapshot_json=json.dumps(_snapshot(a)),
    )
    s.add(rev)


# --- Top-level assessment CRUD -------------------------------------------


@router.get("", response_model=list[AssessmentSummary])
def list_assessments() -> list[AssessmentSummary]:
    with user_session() as s:
        rows = s.execute(select(Assessment).order_by(Assessment.id.desc())).scalars().all()
        return [AssessmentSummary.model_validate(r) for r in rows]


@router.post("", response_model=AssessmentRead, status_code=201)
def create_assessment(body: AssessmentCreate) -> AssessmentRead:
    with user_session() as s:
        a = Assessment(
            name=body.name,
            chemical_name=body.chemical_name,
            cas_number=body.cas_number,
            notes=body.notes,
        )
        s.add(a)
        s.flush()
        _save_revision(s, a, "created")
        s.refresh(a)
        return AssessmentRead.model_validate(a)


def _load(s, assessment_id: int) -> Assessment:  # type: ignore[no-untyped-def]
    a: Assessment | None = s.execute(
        select(Assessment)
        .where(Assessment.id == assessment_id)
        .options(selectinload(Assessment.operations).selectinload(AssessmentOperation.activities))
    ).scalar_one_or_none()
    if a is None:
        raise HTTPException(404, f"assessment {assessment_id} not found")
    return a


@router.get("/{assessment_id}", response_model=AssessmentRead)
def get_assessment(assessment_id: int) -> AssessmentRead:
    with user_session() as s:
        return AssessmentRead.model_validate(_load(s, assessment_id))


@router.patch("/{assessment_id}", response_model=AssessmentRead)
def update_assessment(assessment_id: int, body: AssessmentUpdate) -> AssessmentRead:
    with user_session() as s:
        a = _load(s, assessment_id)
        for k, v in body.model_dump(exclude_unset=True).items():
            setattr(a, k, v)
        s.flush()
        _save_revision(s, a, "updated")
        return AssessmentRead.model_validate(a)


@router.delete("/{assessment_id}", status_code=204)
def delete_assessment(assessment_id: int) -> None:
    with user_session() as s:
        a = _load(s, assessment_id)
        s.delete(a)


# --- Nested: operations ---------------------------------------------------


@router.post(
    "/{assessment_id}/operations",
    response_model=OperationRead,
    status_code=201,
)
def add_operation(assessment_id: int, body: OperationCreate) -> OperationRead:
    with user_session() as s:
        a = _load(s, assessment_id)
        op = AssessmentOperation(
            assessment_id=a.id,
            op_id=body.op_id,
            name=body.name,
            sort_order=body.sort_order,
        )
        s.add(op)
        s.flush()
        for act_in in body.activities:
            s.add(
                AssessmentActivity(
                    operation_id=op.id,
                    act_id=act_in.act_id,
                    name=act_in.name,
                    sort_order=act_in.sort_order,
                )
            )
        s.flush()
        _save_revision(s, a, f"added operation #{op.op_id}")
        s.refresh(op)
        return OperationRead.model_validate(op)


@router.delete(
    "/{assessment_id}/operations/{operation_id}",
    status_code=204,
)
def delete_operation(assessment_id: int, operation_id: int) -> None:
    with user_session() as s:
        a = _load(s, assessment_id)
        op = next((o for o in a.operations if o.id == operation_id), None)
        if op is None:
            raise HTTPException(404, f"operation {operation_id} not found in assessment")
        s.delete(op)
        s.flush()
        _save_revision(s, a, f"deleted operation #{op.op_id}")


# --- Nested: activities ---------------------------------------------------


@router.post(
    "/{assessment_id}/operations/{operation_id}/activities",
    response_model=ActivityRead,
    status_code=201,
)
def add_activity(assessment_id: int, operation_id: int, body: ActivityCreate) -> ActivityRead:
    with user_session() as s:
        a = _load(s, assessment_id)
        op = next((o for o in a.operations if o.id == operation_id), None)
        if op is None:
            raise HTTPException(404, f"operation {operation_id} not found")
        act = AssessmentActivity(
            operation_id=op.id,
            act_id=body.act_id,
            name=body.name,
            sort_order=body.sort_order,
        )
        s.add(act)
        s.flush()
        _save_revision(s, a, f"added activity #{act.act_id} to operation #{op.op_id}")
        s.refresh(act)
        return ActivityRead.model_validate(act)


# --- Revisions ------------------------------------------------------------


@router.get("/{assessment_id}/revisions", response_model=list[RevisionRead])
def list_revisions(assessment_id: int) -> list[RevisionRead]:
    with user_session() as s:
        a = _load(s, assessment_id)
        return [RevisionRead.model_validate(r) for r in a.revisions]
