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


# --- Chemical record -------------------------------------------------------


class ChemicalRecordUpdate(BaseModel):
    """Upsert payload for the per-assessment chemical record. All fields
    optional; numeric values are v3.2 standard units (torr, g/mol, kg/L,
    g/L, °C, kg/yr)."""

    mol_formula: str | None = None
    trade_names: str | None = None
    category: str | None = None
    mw: float | None = Field(default=None, gt=0)
    vp_torr: float | None = Field(default=None, ge=0)
    vp_temp_c: float | None = None
    density_kg_l: float | None = Field(default=None, gt=0)
    density_temp_c: float | None = None
    solubility_g_l: float | None = Field(default=None, ge=0)
    sol_temp_c: float | None = None
    melting_point_c: float | None = None
    boiling_point_c: float | None = None
    production_volume_kg_yr: float | None = Field(default=None, gt=0)
    physical_state: str | None = None


class ChemicalRecordRead(_Base):
    id: int
    assessment_id: int
    mol_formula: str | None
    trade_names: str | None
    category: str | None
    mw: float | None
    vp_torr: float | None
    vp_temp_c: float | None
    density_kg_l: float | None
    density_temp_c: float | None
    solubility_g_l: float | None
    sol_temp_c: float | None
    melting_point_c: float | None
    boiling_point_c: float | None
    production_volume_kg_yr: float | None
    physical_state: str | None


# --- Model runs ----------------------------------------------------------


class ModelRunCreate(BaseModel):
    activity_id: int
    model_id: int = Field(description="ListOfModels.ModelID from seed data")
    model_kind: str = Field(pattern="^(release|exposure)$")
    inputs: dict[str, object]


class ModelRunUpdate(BaseModel):
    """Partial update of a run; ``inputs`` replaces the whole input dict,
    ``media`` replaces the whole media split (``{MediaID: pct}``,
    percentages must total 100)."""

    inputs: dict[str, object] | None = None
    label: str | None = None
    media: dict[int, float] | None = None


class ModelRunRead(_Base):
    id: int
    activity_id: int
    model_id: int
    model_kind: str
    label: str | None = None
    inputs: dict[str, Any] = Field(validation_alias="inputs_json")
    outputs: dict[str, Any] | None = Field(default=None, validation_alias="outputs_json")
    media: dict[str, float] | None = Field(default=None, validation_alias="media_json")
    last_run_at: datetime | None

    @field_validator("inputs", "outputs", "media", mode="before")
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
