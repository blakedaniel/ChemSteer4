"""Pydantic request / response schemas for the assessment workflow."""

from __future__ import annotations

from datetime import datetime

from pydantic import BaseModel, ConfigDict, Field


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


class ModelRunRead(_Base):
    id: int
    activity_id: int
    model_id: int
    model_kind: str
    inputs: dict[str, object] = Field(alias="inputs_json")
    outputs: dict[str, object] | None = Field(default=None, alias="outputs_json")
    last_run_at: datetime | None


# --- Revisions -----------------------------------------------------------


class RevisionRead(_Base):
    id: int
    assessment_id: int
    summary: str
    created_at: datetime
