"""SQLAlchemy 2.0 mappings over the read-only seed databases.

Schema mirrors what `scripts/build-seed-db.py` writes — every column is
TEXT in SQLite (since CSV preserves no typing). Pydantic response
schemas in `chemsteer.api.schemas` cast to typed values at the API
boundary.
"""

from __future__ import annotations

from sqlalchemy.orm import DeclarativeBase, Mapped, mapped_column


class ChmSteerBase(DeclarativeBase):
    """Tables that live in `chmsteer.db` (master reference)."""


class ListOfModels(ChmSteerBase):
    __tablename__ = "ListOfModels"

    ModelID: Mapped[str] = mapped_column(primary_key=True)
    ModelName: Mapped[str | None] = mapped_column()
    Type: Mapped[str | None] = mapped_column()
    PCat: Mapped[str | None] = mapped_column()
    DefaultA: Mapped[str | None] = mapped_column()
    DefaultI: Mapped[str | None] = mapped_column()
    DefaultL: Mapped[str | None] = mapped_column()
    DefaultW: Mapped[str | None] = mapped_column()
    Mechanism: Mapped[str | None] = mapped_column()
    ChemStateID: Mapped[str | None] = mapped_column()
    Equation: Mapped[str | None] = mapped_column()
    Basis: Mapped[str | None] = mapped_column()
    OutputOn1: Mapped[str | None] = mapped_column()
    OutputOn2: Mapped[str | None] = mapped_column()
    Char1: Mapped[str | None] = mapped_column()
    Char2: Mapped[str | None] = mapped_column()
    specNum: Mapped[str | None] = mapped_column()
    specsApproved: Mapped[str | None] = mapped_column()


class ListOfActivities(ChmSteerBase):
    __tablename__ = "ListOfActivities"

    ActID: Mapped[str] = mapped_column(primary_key=True)
    ActName: Mapped[str | None] = mapped_column()
    RelActivity: Mapped[str | None] = mapped_column()
    ExpActivity: Mapped[str | None] = mapped_column()
    DefaultRelModel: Mapped[str | None] = mapped_column()
    DefaultRelModel2: Mapped[str | None] = mapped_column()
    DefaultRelModel3: Mapped[str | None] = mapped_column()
    DefaultInhModel: Mapped[str | None] = mapped_column()
    DefaultDrmModel: Mapped[str | None] = mapped_column()
    ContTab: Mapped[str | None] = mapped_column()
    ActType: Mapped[str | None] = mapped_column()
    RestrictedActivity: Mapped[str | None] = mapped_column()
    TwinActivity: Mapped[str | None] = mapped_column()


class ListOfOperations(ChmSteerBase):
    __tablename__ = "ListOfOperations"

    OpID: Mapped[str] = mapped_column(primary_key=True)
    OpName: Mapped[str | None] = mapped_column()
    OpType: Mapped[str | None] = mapped_column()
    SortOrder: Mapped[str | None] = mapped_column()
    OpStatus: Mapped[str | None] = mapped_column()
    InfluentLabel: Mapped[str | None] = mapped_column()
    EffluentLabel: Mapped[str | None] = mapped_column()
    BatchOrCont: Mapped[str | None] = mapped_column()
    InfOrEff: Mapped[str | None] = mapped_column()
    EnableCmdCalcXmoProd: Mapped[str | None] = mapped_column()
    EnableCmdCalcNS: Mapped[str | None] = mapped_column()
    EnableCmdCalcYprod: Mapped[str | None] = mapped_column()
    MassBalMsg: Mapped[str | None] = mapped_column()
    DefaultNAICS: Mapped[str | None] = mapped_column()
    DefaultProcDesc: Mapped[str | None] = mapped_column()


class ListOfParms(ChmSteerBase):
    __tablename__ = "ListOfParms"

    ParmID: Mapped[str] = mapped_column(primary_key=True)
    ParmName: Mapped[str | None] = mapped_column()
    StdUnits: Mapped[str | None] = mapped_column()
    Abbr: Mapped[str | None] = mapped_column()
    Notes: Mapped[str | None] = mapped_column()
    Type: Mapped[str | None] = mapped_column()
    DefaultSource: Mapped[str | None] = mapped_column()


class ListOfValidModels(ChmSteerBase):
    __tablename__ = "ListOfValidModels"

    # No real PK; (ActID, ModelID) is unique. SQLAlchemy needs *something*
    # to map; use the composite as primary key.
    ActID: Mapped[str] = mapped_column(primary_key=True)
    ModelID: Mapped[str] = mapped_column(primary_key=True)


class ScenariosBase(DeclarativeBase):
    """Tables that live in `scenarios.db` (Generic Scenarios)."""


class GenericScenario(ScenariosBase):
    __tablename__ = "Operations"

    OpID: Mapped[str] = mapped_column(primary_key=True)
    OpName: Mapped[str | None] = mapped_column(primary_key=True)
    ScenarioID: Mapped[str | None] = mapped_column()
    OpType: Mapped[str | None] = mapped_column()
    GSS_PDF: Mapped[str | None] = mapped_column()
    ProcessDesc: Mapped[str | None] = mapped_column()
