"""CRUD routes for user assessments + nested operations + activities + runs."""

from __future__ import annotations

import json
from datetime import UTC, datetime

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
    CalcAssessmentResponse,
    CalcRunResult,
    FromScenarioRequest,
    FromScenarioResponse,
    ModelRunCreate,
    ModelRunRead,
    ModelRunUpdate,
    OperationCreate,
    OperationRead,
    RevisionRead,
)
from chemsteer.calc.dispatch import get_input_class, get_model_fn
from chemsteer.db.user import (
    Assessment,
    AssessmentActivity,
    AssessmentOperation,
    ModelRun,
    Revision,
    user_session,
)
from chemsteer.importers.scenario import ScenarioNotFoundError, instantiate_scenario

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


@router.post(
    "/{assessment_id}/operations/from-scenario",
    response_model=FromScenarioResponse,
    status_code=201,
)
def add_operation_from_scenario(
    assessment_id: int, body: FromScenarioRequest
) -> FromScenarioResponse:
    """Instantiate one of the 34 Generic Scenario templates onto the
    assessment: operation + activities + pre-parameterized model runs."""
    with user_session() as s:
        a = _load(s, assessment_id)
        try:
            result = instantiate_scenario(s, a.id, body.scenario_id)
        except ScenarioNotFoundError as e:
            raise HTTPException(404, str(e)) from e
        _save_revision(s, a, f"added operation from Generic Scenario #{body.scenario_id}")
        s.refresh(result.operation)
        return FromScenarioResponse(
            operation=OperationRead.model_validate(result.operation),
            n_activities=result.n_activities,
            n_runs=result.n_runs,
            skipped_runs=result.skipped_runs,
        )


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


# --- Model runs (per activity) -------------------------------------------


def _find_activity(a: Assessment, activity_id: int) -> AssessmentActivity:
    for op in a.operations:
        for act in op.activities:
            if act.id == activity_id:
                return act
    raise HTTPException(404, f"activity {activity_id} not found in assessment {a.id}")


@router.post(
    "/{assessment_id}/activities/{activity_id}/runs",
    response_model=ModelRunRead,
    status_code=201,
)
def add_model_run(assessment_id: int, activity_id: int, body: ModelRunCreate) -> ModelRunRead:
    """Attach a (model_id, inputs) entry to an activity. Doesn't run yet."""
    with user_session() as s:
        a = _load(s, assessment_id)
        act = _find_activity(a, activity_id)

        # Validate that the model is implemented and the inputs parse.
        try:
            input_cls = get_input_class(body.model_kind, body.model_id)
            input_cls.model_validate(body.inputs)
        except KeyError as exc:
            raise HTTPException(400, str(exc)) from exc
        except Exception as exc:
            raise HTTPException(422, f"invalid inputs: {exc}") from exc

        run = ModelRun(
            activity_id=act.id,
            model_id=body.model_id,
            model_kind=body.model_kind,
            inputs_json=json.dumps(body.inputs),
        )
        s.add(run)
        s.flush()
        _save_revision(s, a, f"added {body.model_kind} model #{body.model_id} to activity {act.id}")
        s.refresh(run)
        return ModelRunRead.model_validate(run)


@router.get(
    "/{assessment_id}/activities/{activity_id}/runs",
    response_model=list[ModelRunRead],
)
def list_model_runs(assessment_id: int, activity_id: int) -> list[ModelRunRead]:
    with user_session() as s:
        a = _load(s, assessment_id)
        act = _find_activity(a, activity_id)
        rows = (
            s.execute(select(ModelRun).where(ModelRun.activity_id == act.id).order_by(ModelRun.id))
            .scalars()
            .all()
        )
        return [ModelRunRead.model_validate(r) for r in rows]


@router.patch(
    "/{assessment_id}/runs/{run_id}",
    response_model=ModelRunRead,
)
def update_model_run(assessment_id: int, run_id: int, body: ModelRunUpdate) -> ModelRunRead:
    """Edit a run's inputs (full replacement) and/or label; clears cached
    outputs since they no longer reflect the inputs."""
    with user_session() as s:
        a = _load(s, assessment_id)
        run = s.execute(select(ModelRun).where(ModelRun.id == run_id)).scalar_one_or_none()
        if run is None:
            raise HTTPException(404, f"run {run_id} not found")
        owned = any(act.id == run.activity_id for op in a.operations for act in op.activities)
        if not owned:
            raise HTTPException(404, f"run {run_id} not found in assessment {assessment_id}")
        if body.inputs is not None:
            try:
                input_cls = get_input_class(run.model_kind, run.model_id)
                input_cls.model_validate(body.inputs)
            except Exception as exc:
                raise HTTPException(422, f"invalid inputs: {exc}") from exc
            run.inputs_json = json.dumps(body.inputs)
            run.outputs_json = None
            run.last_run_at = None
        if body.label is not None:
            run.label = body.label
        s.flush()
        _save_revision(s, a, f"updated run #{run_id}")
        s.refresh(run)
        return ModelRunRead.model_validate(run)


@router.delete(
    "/{assessment_id}/runs/{run_id}",
    status_code=204,
)
def delete_model_run(assessment_id: int, run_id: int) -> None:
    with user_session() as s:
        a = _load(s, assessment_id)
        run = s.execute(select(ModelRun).where(ModelRun.id == run_id)).scalar_one_or_none()
        if run is None:
            raise HTTPException(404, f"run {run_id} not found")
        # confirm the run lives under this assessment (safety check)
        owned = any(act.id == run.activity_id for op in a.operations for act in op.activities)
        if not owned:
            raise HTTPException(404, f"run {run_id} not found in assessment {assessment_id}")
        s.delete(run)
        s.flush()
        _save_revision(s, a, f"deleted run #{run_id}")


# --- Per-assessment calc trigger -----------------------------------------


def _serialize_output(out: object) -> dict[str, object]:
    """Convert a CalcOutput Pydantic model to a JSON-friendly dict.

    Quantities serialize to {"value": float, "unit": str} via their
    `_ToJson` annotation. This is what the schema's `outputs` field
    expects.
    """
    from chemsteer.calc.base import CalcOutput

    if isinstance(out, CalcOutput):
        return out.model_dump(mode="json")
    raise TypeError(f"cannot serialize {type(out).__name__}")


@router.post(
    "/{assessment_id}/calc",
    response_model=CalcAssessmentResponse,
)
def calc_assessment(assessment_id: int) -> CalcAssessmentResponse:
    """Run every ModelRun under this assessment, persisting outputs.

    Failures on individual runs do not abort the whole calc — each run's
    `ok` / `error` is reported in the response so the UI can highlight
    bad inputs without losing successful results.
    """
    results: list[CalcRunResult] = []
    with user_session() as s:
        a = _load(s, assessment_id)
        runs: list[ModelRun] = list(
            s.execute(
                select(ModelRun)
                .join(AssessmentActivity, ModelRun.activity_id == AssessmentActivity.id)
                .join(
                    AssessmentOperation, AssessmentActivity.operation_id == AssessmentOperation.id
                )
                .where(AssessmentOperation.assessment_id == a.id)
                .order_by(ModelRun.id)
            )
            .scalars()
            .all()
        )

        for run in runs:
            try:
                input_cls = get_input_class(run.model_kind, run.model_id)
                fn = get_model_fn(run.model_kind, run.model_id)
                inp = input_cls.model_validate(json.loads(run.inputs_json))
                out = fn(inp)
                serialized = _serialize_output(out)
                run.outputs_json = json.dumps(serialized)
                run.last_run_at = datetime.now(UTC).replace(tzinfo=None)
                results.append(
                    CalcRunResult(
                        run_id=run.id,
                        model_id=run.model_id,
                        model_kind=run.model_kind,
                        ok=True,
                        outputs=serialized,
                    )
                )
            except Exception as exc:
                results.append(
                    CalcRunResult(
                        run_id=run.id,
                        model_id=run.model_id,
                        model_kind=run.model_kind,
                        ok=False,
                        error=str(exc),
                    )
                )

        s.flush()
        n_ok = sum(1 for r in results if r.ok)
        n_fail = len(results) - n_ok
        _save_revision(
            s,
            a,
            f"calc: {n_ok} ok, {n_fail} failed across {len(results)} run(s)",
        )

    return CalcAssessmentResponse(assessment_id=assessment_id, runs=results)
