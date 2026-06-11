"""Pydantic request / response schemas for the assessment workflow."""

from __future__ import annotations

import json
from datetime import datetime
from typing import Any

from pydantic import BaseModel, ConfigDict, Field, field_validator


class _Base(BaseModel):
    model_config = ConfigDict(from_attributes=True)


# --- Activities ----------------------------------------------------------


class ActivityCreate(BaseModel):
    act_id: int = Field(description="ListOfActivities.ActID from seed data")
    name: str | None = None
    sort_order: int = 0


class ActivityRead(_Base):
    id: int
    act_id: int
    name: str | None
    sort_order: int


# --- Operations ----------------------------------------------------------


class OperationCreate(BaseModel):
    op_id: int = Field(description="ListOfOperations.OpID from seed data")
    name: str | None = None
    sort_order: int = 0
    activities: list[ActivityCreate] = Field(default_factory=list)


class OperationRead(_Base):
    id: int
    op_id: int
    name: str | None
    sort_order: int
    activities: list[ActivityRead] = Field(default_factory=list)


# --- Assessments ---------------------------------------------------------


class AssessmentCreate(BaseModel):
    name: str
    chemical_name: str | None = None
    cas_number: str | None = None
    notes: str | None = None


class AssessmentUpdate(BaseModel):
    name: str | None = None
    chemical_name: str | None = None
    cas_number: str | None = None
    notes: str | None = None


class AssessmentSummary(_Base):
    id: int
    name: str
    chemical_name: str | None
    cas_number: str | None
    created_at: datetime
    updated_at: datetime


class AssessmentRead(AssessmentSummary):
    notes: str | None
    operations: list[OperationRead] = Field(default_factory=list)


# --- Model runs ----------------------------------------------------------


class ModelRunCreate(BaseModel):
    activity_id: int
    model_id: int = Field(description="ListOfModels.ModelID from seed data")
    model_kind: str = Field(pattern="^(release|exposure)$")
    inputs: dict[str, object]


class ModelRunUpdate(BaseModel):
    """Partial update of a run; ``inputs`` replaces the whole input dict."""

    inputs: dict[str, object] | None = None
    label: str | None = None


class ModelRunRead(_Base):
    id: int
    activity_id: int
    model_id: int
    model_kind: str
    label: str | None = None
    inputs: dict[str, Any] = Field(validation_alias="inputs_json")
    outputs: dict[str, Any] | None = Field(default=None, validation_alias="outputs_json")
    last_run_at: datetime | None

    @field_validator("inputs", "outputs", mode="before")
    @classmethod
    def _parse_json(cls, v: Any) -> Any:
        if v is None or isinstance(v, dict):
            return v
        if isinstance(v, str):
            return json.loads(v) if v else None
        return v


class CalcRunResult(BaseModel):
    """Outcome of running a single ModelRun within a per-assessment calc."""

    run_id: int
    model_id: int
    model_kind: str
    ok: bool
    error: str | None = None
    outputs: dict[str, Any] | None = None


class CalcAssessmentResponse(BaseModel):
    assessment_id: int
    runs: list[CalcRunResult]


# --- Generic Scenario instantiation ---------------------------------------


class FromScenarioRequest(BaseModel):
    scenario_id: int = Field(description="scenarios.db Operations.ScenarioID (1 of the 34 GSs)")


class FromScenarioResponse(BaseModel):
    operation: OperationRead
    n_activities: int
    n_runs: int
    skipped_runs: list[str] = Field(default_factory=list)


# --- Revisions -----------------------------------------------------------


class RevisionRead(_Base):
    id: int
    assessment_id: int
    summary: str
    created_at: datetime
