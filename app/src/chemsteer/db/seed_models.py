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


class ListOfMedia(ChmSteerBase):
    """chmsteer.db::ListOfMedia — the 18 release-media categories."""

    __tablename__ = "ListOfMedia"

    MediaID: Mapped[str] = mapped_column(primary_key=True)
    Media: Mapped[str | None] = mapped_column()
    SortID: Mapped[str | None] = mapped_column()


class MediaDefaults(ChmSteerBase):
    """chmsteer.db::MediaDefaults — default media % split per release model."""

    __tablename__ = "MediaDefaults"

    ModelID: Mapped[str] = mapped_column(primary_key=True)
    MediaID: Mapped[str] = mapped_column(primary_key=True)
    Pct: Mapped[str | None] = mapped_column()


class Naics(ChmSteerBase):
    """chmsteer.db::NAICS — 1814 industry classification codes."""

    __tablename__ = "NAICS"

    naicsid: Mapped[str] = mapped_column(primary_key=True)
    naics: Mapped[str | None] = mapped_column()
    naicsdesc: Mapped[str | None] = mapped_column()


class PelRelTwa(ChmSteerBase):
    """chmsteer.db::pel_rel_twa — OSHA PEL / NIOSH REL chemical limits."""

    __tablename__ = "pel_rel_twa"

    NumericCas: Mapped[str] = mapped_column(primary_key=True)
    CASNumber: Mapped[str | None] = mapped_column()
    ChemicalName: Mapped[str | None] = mapped_column()
    MW: Mapped[str | None] = mapped_column()
    pel_twa: Mapped[str | None] = mapped_column("PEL-TWA")
    pel_twa_mgm3: Mapped[str | None] = mapped_column("PEL-TWAmgm3")
    pel_stel: Mapped[str | None] = mapped_column("PEL-STEL")
    pel_stel_mgm3: Mapped[str | None] = mapped_column("PEL-STELmgm3")
    pel_cl: Mapped[str | None] = mapped_column("PEL-CL")
    pel_cl_mgm3: Mapped[str | None] = mapped_column("PEL-CLmgm3")
    pel_comments: Mapped[str | None] = mapped_column("PEL-COMMENTS")
    rel_twa: Mapped[str | None] = mapped_column("REL-TWA")
    rel_twa_mgm3: Mapped[str | None] = mapped_column("REL-TWAmgm3")
    rel_stel: Mapped[str | None] = mapped_column("REL-STEL")
    rel_stel_mgm3: Mapped[str | None] = mapped_column("REL-STELmgm3")
    rel_cl: Mapped[str | None] = mapped_column("REL-CL")
    rel_cl_mgm3: Mapped[str | None] = mapped_column("REL-CLmgm3")
    rel_comments: Mapped[str | None] = mapped_column("REL-COMMENTS")


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
    OpOrder: Mapped[str | None] = mapped_column()


class ScenarioActivity(ScenariosBase):
    """scenarios.db::Activities — activities attached to a Generic Scenario.

    ``ScenActID`` restarts per scenario; (ScenarioID, ScenActID) is the
    real key.
    """

    __tablename__ = "Activities"

    ScenarioID: Mapped[str] = mapped_column(primary_key=True)
    ScenActID: Mapped[str] = mapped_column(primary_key=True)
    ActID: Mapped[str | None] = mapped_column()
    ActName: Mapped[str | None] = mapped_column()
    ActOrder: Mapped[str | None] = mapped_column()
    DoRel: Mapped[str | None] = mapped_column()
    DoExp: Mapped[str | None] = mapped_column()


class ScenActRelModel(ScenariosBase):
    """scenarios.db::ActRelModels — release models on scenario activities."""

    __tablename__ = "ActRelModels"

    RelParmsAN: Mapped[str] = mapped_column(primary_key=True)
    ScenarioID: Mapped[str | None] = mapped_column()
    ScenActID: Mapped[str | None] = mapped_column()
    RelModID: Mapped[str | None] = mapped_column()
    """Index of this model row within its activity — the join key for
    ``ActRelModMedia``."""
    ModelID: Mapped[str | None] = mapped_column()
    RelDays: Mapped[str | None] = mapped_column()
    RelDays2: Mapped[str | None] = mapped_column()
    OutputOn1: Mapped[str | None] = mapped_column()
    OutputOn2: Mapped[str | None] = mapped_column()
    Char1: Mapped[str | None] = mapped_column()
    Char2: Mapped[str | None] = mapped_column()
    Basis: Mapped[str | None] = mapped_column()


class ScenActRelModParm(ScenariosBase):
    """scenarios.db::ActRelModParms — per-(model, output) parameter rows."""

    __tablename__ = "ActRelModParms"

    RelParmsAN: Mapped[str] = mapped_column(primary_key=True)
    OutputID: Mapped[str] = mapped_column(primary_key=True)
    ParmID: Mapped[str] = mapped_column(primary_key=True)
    ParmValue: Mapped[str | None] = mapped_column()


class ScenActExpModel(ScenariosBase):
    """scenarios.db::ActExpModels — exposure models on scenario activities."""

    __tablename__ = "ActExpModels"

    ExpParmsAN: Mapped[str] = mapped_column(primary_key=True)
    ScenarioID: Mapped[str | None] = mapped_column()
    ScenActID: Mapped[str | None] = mapped_column()
    ModelID: Mapped[str | None] = mapped_column()
    OutputOn1: Mapped[str | None] = mapped_column()
    OutputOn2: Mapped[str | None] = mapped_column()
    Char1: Mapped[str | None] = mapped_column()
    Char2: Mapped[str | None] = mapped_column()
    Basis: Mapped[str | None] = mapped_column()


class ScenOpParm(ScenariosBase):
    """scenarios.db::OpParms — operation-level parameter values a GS ships.

    No real PK; (ScenarioID, ParmID) is unique in practice.
    """

    __tablename__ = "OpParms"

    ScenarioID: Mapped[str] = mapped_column(primary_key=True)
    ParmID: Mapped[str] = mapped_column(primary_key=True)
    ParmValue: Mapped[str | None] = mapped_column()


class ScenActRelModMedia(ScenariosBase):
    """scenarios.db::ActRelModMedia — media % splits a GS ships per
    (activity, release-model-row)."""

    __tablename__ = "ActRelModMedia"

    ScenarioID: Mapped[str] = mapped_column(primary_key=True)
    ScenActID: Mapped[str] = mapped_column(primary_key=True)
    RelModID: Mapped[str] = mapped_column(primary_key=True)
    MediaID: Mapped[str] = mapped_column(primary_key=True)
    Pct: Mapped[str | None] = mapped_column()


class ScenActExpModParm(ScenariosBase):
    """scenarios.db::ActExpModParms — per-(model, output) parameter rows."""

    __tablename__ = "ActExpModParms"

    ExpParmsAN: Mapped[str] = mapped_column(primary_key=True)
    OutputID: Mapped[str] = mapped_column(primary_key=True)
    ParmID: Mapped[str] = mapped_column(primary_key=True)
    ParmValue: Mapped[str | None] = mapped_column()
