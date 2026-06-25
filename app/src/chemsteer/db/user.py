"""SQLAlchemy session + ORM models for the user-data SQLite DB.

The user DB lives at ``~/.chemsteer-py/assessments.db`` (or wherever
``CHEMSTEER_USER_DATA_DIR`` points) and stores everything a user enters:
assessments, operations attached to those assessments, activities under
those operations, model runs (per-activity calc invocations + cached
results), and a per-assessment revision history.

Schema is intentionally narrow at this stage — Phase 4a covers the
minimum needed to drive an end-to-end assessment workflow. Phase 5
extends with reports/exports and the .cs2 importer.
"""

from __future__ import annotations

from collections.abc import Iterator
from contextlib import contextmanager
from datetime import datetime
from functools import cache

from sqlalchemy import (
    DateTime,
    Engine,
    Float,
    ForeignKey,
    Integer,
    String,
    Text,
    create_engine,
    func,
)
from sqlalchemy.orm import (
    DeclarativeBase,
    Mapped,
    Session,
    mapped_column,
    relationship,
    sessionmaker,
)

from chemsteer.settings import get_settings


class UserBase(DeclarativeBase):
    """Tables that live in the user-data DB (assessments + history)."""


class Assessment(UserBase):
    __tablename__ = "assessments"

    id: Mapped[int] = mapped_column(primary_key=True)
    name: Mapped[str] = mapped_column(String(255))
    chemical_name: Mapped[str | None] = mapped_column(String(255), nullable=True)
    cas_number: Mapped[str | None] = mapped_column(String(64), nullable=True)
    notes: Mapped[str | None] = mapped_column(Text, nullable=True)
    created_at: Mapped[datetime] = mapped_column(DateTime, server_default=func.now())
    updated_at: Mapped[datetime] = mapped_column(
        DateTime, server_default=func.now(), onupdate=func.now()
    )

    operations: Mapped[list[AssessmentOperation]] = relationship(
        back_populates="assessment", cascade="all, delete-orphan"
    )
    revisions: Mapped[list[Revision]] = relationship(
        back_populates="assessment",
        cascade="all, delete-orphan",
        order_by="Revision.created_at.desc()",
    )
    chemical: Mapped[ChemicalRecord | None] = relationship(
        back_populates="assessment", cascade="all, delete-orphan", uselist=False
    )


class ChemicalRecord(UserBase):
    """Per-assessment chemical properties (v3.2's ``Chemicals`` table).

    Numeric fields are stored in v3.2's standard units (the binary reads
    them raw into model formulas): vapor pressure in torr, MW in g/mol,
    density in kg/L, water solubility in g/L, temperatures in °C,
    production volume in kg/yr. ``None`` means "not provided" — the
    original leaves blanks and the defaults resolver simply skips the
    chemical-record sentinels for missing values.
    """

    __tablename__ = "chemical_records"

    id: Mapped[int] = mapped_column(primary_key=True)
    assessment_id: Mapped[int] = mapped_column(
        ForeignKey("assessments.id", ondelete="CASCADE"), unique=True
    )
    mol_formula: Mapped[str | None] = mapped_column(String(255), nullable=True)
    trade_names: Mapped[str | None] = mapped_column(String(255), nullable=True)
    category: Mapped[str | None] = mapped_column(String(255), nullable=True)
    mw: Mapped[float | None] = mapped_column(Float, nullable=True)
    """Molecular weight (g/mol) — ParmID 5."""
    vp_torr: Mapped[float | None] = mapped_column(Float, nullable=True)
    """Vapor pressure (torr) — ParmID 4."""
    vp_temp_c: Mapped[float | None] = mapped_column(Float, nullable=True)
    density_kg_l: Mapped[float | None] = mapped_column(Float, nullable=True)
    """Density of the chemical (kg/L)."""
    density_temp_c: Mapped[float | None] = mapped_column(Float, nullable=True)
    solubility_g_l: Mapped[float | None] = mapped_column(Float, nullable=True)
    """Water solubility (g/L) — ParmID 80 (WSchem)."""
    sol_temp_c: Mapped[float | None] = mapped_column(Float, nullable=True)
    melting_point_c: Mapped[float | None] = mapped_column(Float, nullable=True)
    boiling_point_c: Mapped[float | None] = mapped_column(Float, nullable=True)
    production_volume_kg_yr: Mapped[float | None] = mapped_column(Float, nullable=True)
    physical_state: Mapped[str | None] = mapped_column(String(64), nullable=True)

    assessment: Mapped[Assessment] = relationship(back_populates="chemical")


class AssessmentOperation(UserBase):
    """An operation (Manufacturing/Processing/Use, etc.) under an assessment.

    Joined via ``op_id`` to the seed-data ``ListOfOperations`` for the
    operation type metadata. We keep the seed-data IDs as plain ints —
    this is a cross-database soft FK enforced at the API layer.
    """

    __tablename__ = "assessment_operations"

    id: Mapped[int] = mapped_column(primary_key=True)
    assessment_id: Mapped[int] = mapped_column(ForeignKey("assessments.id", ondelete="CASCADE"))
    op_id: Mapped[int] = mapped_column(Integer)
    """References ListOfOperations.OpID in the seed DB."""
    name: Mapped[str | None] = mapped_column(String(255), nullable=True)
    sort_order: Mapped[int] = mapped_column(Integer, default=0)

    assessment: Mapped[Assessment] = relationship(back_populates="operations")
    activities: Mapped[list[AssessmentActivity]] = relationship(
        back_populates="operation", cascade="all, delete-orphan"
    )


class AssessmentActivity(UserBase):
    """An activity under an operation. References seed ListOfActivities."""

    __tablename__ = "assessment_activities"

    id: Mapped[int] = mapped_column(primary_key=True)
    operation_id: Mapped[int] = mapped_column(
        ForeignKey("assessment_operations.id", ondelete="CASCADE")
    )
    act_id: Mapped[int] = mapped_column(Integer)
    """References ListOfActivities.ActID in the seed DB."""
    name: Mapped[str | None] = mapped_column(String(255), nullable=True)
    sort_order: Mapped[int] = mapped_column(Integer, default=0)

    operation: Mapped[AssessmentOperation] = relationship(back_populates="activities")
    model_runs: Mapped[list[ModelRun]] = relationship(
        back_populates="activity", cascade="all, delete-orphan"
    )


class ModelRun(UserBase):
    """A single (model_id, parameter set) invocation under an activity.

    ``inputs_json`` and ``outputs_json`` are JSON-serialized Pydantic
    payloads matching the calc engine's per-model Input/Output schemas.
    """

    __tablename__ = "model_runs"

    id: Mapped[int] = mapped_column(primary_key=True)
    activity_id: Mapped[int] = mapped_column(
        ForeignKey("assessment_activities.id", ondelete="CASCADE")
    )
    model_id: Mapped[int] = mapped_column(Integer)
    """References ListOfModels.ModelID in the seed DB."""
    model_kind: Mapped[str] = mapped_column(String(8))
    """'release' or 'exposure'."""
    label: Mapped[str | None] = mapped_column(String(64), nullable=True)
    """Output characterization ('Central Tendency', 'High End', …) when a
    v3.2 model row carries two enabled outputs and instantiates as two runs."""
    inputs_json: Mapped[str] = mapped_column(Text)
    outputs_json: Mapped[str | None] = mapped_column(Text, nullable=True)
    media_json: Mapped[str | None] = mapped_column(Text, nullable=True)
    """Release-media split as JSON ``{MediaID: pct}`` (percentages sum to
    100, v3.2 ``ActRelModMedia``). Only meaningful for release runs;
    ``None`` falls back to ``MediaDefaults`` at report time."""
    last_run_at: Mapped[datetime | None] = mapped_column(DateTime, nullable=True)

    activity: Mapped[AssessmentActivity] = relationship(back_populates="model_runs")


class Revision(UserBase):
    """A snapshot of an assessment, written on save / calc invocation.

    Stores the full assessment state as a JSON blob plus a short summary
    — enough to power a "view history / restore" UI. Keep it dumb (just
    a serialized snapshot) until we hit a need for richer diffing.
    """

    __tablename__ = "revisions"

    id: Mapped[int] = mapped_column(primary_key=True)
    assessment_id: Mapped[int] = mapped_column(ForeignKey("assessments.id", ondelete="CASCADE"))
    summary: Mapped[str] = mapped_column(String(255))
    snapshot_json: Mapped[str] = mapped_column(Text)
    created_at: Mapped[datetime] = mapped_column(DateTime, server_default=func.now())

    assessment: Mapped[Assessment] = relationship(back_populates="revisions")


# --- Engine + session plumbing -------------------------------------------


def _user_db_url() -> str:
    s = get_settings()
    s.user_data_dir.mkdir(parents=True, exist_ok=True)
    return f"sqlite:///{s.assessments_db_path}"


@cache
def get_user_engine() -> Engine:
    return create_engine(_user_db_url(), future=True)


@cache
def _session_factory() -> sessionmaker[Session]:
    return sessionmaker(bind=get_user_engine(), expire_on_commit=False, future=True)


@contextmanager
def user_session() -> Iterator[Session]:
    Sess = _session_factory()
    s = Sess()
    try:
        yield s
        s.commit()
    except Exception:
        s.rollback()
        raise
    finally:
        s.close()
