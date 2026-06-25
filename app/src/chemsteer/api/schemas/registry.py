"""Pydantic response schemas for the read-only seed-data endpoints.

The seed DBs store everything as TEXT (CSV-derived); these schemas coerce
to typed values where the column is unambiguous (numeric IDs, model
type code) and keep TEXT where the source itself is mixed
(`Equation`, `Notes`).
"""

from __future__ import annotations

from typing import Literal

from pydantic import BaseModel, ConfigDict, Field, field_validator

ModelType = Literal["R", "I", "D"]
"""Release / Inhalation / Dermal"""


def _coerce_int(v: object) -> int:
    """Coerce CSV-loaded TEXT values into ``int`` for required ID fields."""
    if isinstance(v, int):
        return v
    if isinstance(v, str):
        return int(v)
    raise TypeError(f"cannot coerce {type(v).__name__} to int")


def _opt_int(v: object) -> int | None:
    if v is None:
        return None
    if isinstance(v, int):
        return v
    if isinstance(v, str):
        if v == "":
            return None
        return int(v)
    raise TypeError(f"cannot coerce {type(v).__name__} to int|None")


def _opt_bool(v: object) -> bool | None:
    if v is None or v == "":
        return None
    return str(v) not in ("0", "False", "false")


class _Base(BaseModel):
    model_config = ConfigDict(from_attributes=True, extra="ignore")


# --- Operations -----------------------------------------------------------


class Operation(_Base):
    op_id: int = Field(validation_alias="OpID")
    op_name: str | None = Field(default=None, validation_alias="OpName")
    op_type: str | None = Field(default=None, validation_alias="OpType")

    @field_validator("op_id", mode="before")
    @classmethod
    def _coerce_op_id(cls, v: object) -> int:
        return _coerce_int(v)


# --- Activities -----------------------------------------------------------


class Activity(_Base):
    act_id: int = Field(validation_alias="ActID")
    act_name: str | None = Field(default=None, validation_alias="ActName")
    rel_activity: bool | None = Field(default=None, validation_alias="RelActivity")
    exp_activity: bool | None = Field(default=None, validation_alias="ExpActivity")
    default_rel_model: int | None = Field(default=None, validation_alias="DefaultRelModel")
    default_rel_model_2: int | None = Field(default=None, validation_alias="DefaultRelModel2")
    default_rel_model_3: int | None = Field(default=None, validation_alias="DefaultRelModel3")
    default_inh_model: int | None = Field(default=None, validation_alias="DefaultInhModel")
    default_drm_model: int | None = Field(default=None, validation_alias="DefaultDrmModel")

    @field_validator("act_id", mode="before")
    @classmethod
    def _coerce_act_id(cls, v: object) -> int:
        return _coerce_int(v)

    @field_validator(
        "default_rel_model",
        "default_rel_model_2",
        "default_rel_model_3",
        "default_inh_model",
        "default_drm_model",
        mode="before",
    )
    @classmethod
    def _coerce_opt_int(cls, v: object) -> int | None:
        return _opt_int(v)

    @field_validator("rel_activity", "exp_activity", mode="before")
    @classmethod
    def _coerce_opt_bool(cls, v: object) -> bool | None:
        return _opt_bool(v)


# --- Models ---------------------------------------------------------------


class Model(_Base):
    model_id: int = Field(validation_alias="ModelID")
    model_name: str | None = Field(default=None, validation_alias="ModelName")
    type: ModelType | None = Field(default=None, validation_alias="Type")
    equation: str | None = Field(default=None, validation_alias="Equation")
    basis: str | None = Field(default=None, validation_alias="Basis")
    mechanism: str | None = Field(default=None, validation_alias="Mechanism")

    @field_validator("model_id", mode="before")
    @classmethod
    def _coerce_model_id(cls, v: object) -> int:
        return _coerce_int(v)


# --- Parameters -----------------------------------------------------------


class Parameter(_Base):
    parm_id: int = Field(validation_alias="ParmID")
    parm_name: str | None = Field(default=None, validation_alias="ParmName")
    abbr: str | None = Field(default=None, validation_alias="Abbr")
    std_units: str | None = Field(default=None, validation_alias="StdUnits")
    notes: str | None = Field(default=None, validation_alias="Notes")
    type: str | None = Field(default=None, validation_alias="Type")

    @field_validator("parm_id", mode="before")
    @classmethod
    def _coerce_parm_id(cls, v: object) -> int:
        return _coerce_int(v)


# --- Generic Scenarios ----------------------------------------------------


class GenericScenarioOut(_Base):
    op_id: int = Field(validation_alias="OpID")
    op_name: str | None = Field(default=None, validation_alias="OpName")
    scenario_id: int | None = Field(default=None, validation_alias="ScenarioID")
    op_type: str | None = Field(default=None, validation_alias="OpType")
    pdf: str | None = Field(default=None, validation_alias="GSS_PDF")

    @field_validator("op_id", mode="before")
    @classmethod
    def _coerce_op_id(cls, v: object) -> int:
        return _coerce_int(v)

    @field_validator("scenario_id", mode="before")
    @classmethod
    def _coerce_scenario_id(cls, v: object) -> int | None:
        return _opt_int(v)


class ModelDefaultsOut(BaseModel):
    """Pre-fill values for a model's input form, from v3.2 ParmDefaults."""

    model_id: int
    model_kind: Literal["release", "exposure"]
    fields: list[str]
    """Every input-field name the model's calc class accepts."""
    defaults: dict[str, object]
    """Subset of ``fields`` that have resolvable defaults; values are
    bare floats or ``{"value", "unit"}`` dicts."""
    media: dict[str, float] = Field(default_factory=dict)
    """Default release-media split ``{MediaID: pct}`` (v3.2
    MediaDefaults); empty for exposure models or models without one."""


class MediaOut(BaseModel):
    """One of the 18 release-media categories (chmsteer.db ListOfMedia)."""

    media_id: int
    name: str
    sort_id: int


class ScenarioModelOut(BaseModel):
    """A release/exposure model attached to a Generic Scenario activity."""

    model_id: int
    model_kind: Literal["release", "exposure"]
    implemented: bool
    """Whether this ModelID is in the calc-engine dispatch registry."""
    output_labels: list[str | None] = Field(default_factory=list)
    """One entry per enabled output characterization (e.g. 'High End')."""


class ScenarioActivityOut(BaseModel):
    scen_act_id: int
    act_id: int
    name: str | None = None
    models: list[ScenarioModelOut] = Field(default_factory=list)


class GenericScenarioDetail(GenericScenarioOut):
    process_desc: str | None = Field(default=None, validation_alias="ProcessDesc")
    activities: list[ScenarioActivityOut] = Field(default_factory=list)
