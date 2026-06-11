"""Response schemas for the reference-lookup endpoints (NAICS, PEL/REL)."""

from __future__ import annotations

from pydantic import BaseModel, ConfigDict, Field, field_validator


class _Base(BaseModel):
    model_config = ConfigDict(from_attributes=True, extra="ignore")


def _opt_float(v: object) -> float | None:
    if v is None or v == "":
        return None
    if isinstance(v, int | float):
        return float(v)
    if isinstance(v, str):
        try:
            return float(v)
        except ValueError:
            return None
    return None


class NaicsOut(_Base):
    code: str | None = Field(default=None, validation_alias="naics")
    description: str | None = Field(default=None, validation_alias="naicsdesc")


class ExposureLimitOut(_Base):
    """One chemical's OSHA PEL / NIOSH REL limits (TWA / STEL / ceiling).

    ppm fields hold the limit as a volume concentration; ``*_mgm3``
    fields are the mass-concentration equivalents.
    """

    cas_number: str | None = Field(default=None, validation_alias="CASNumber")
    chemical_name: str | None = Field(default=None, validation_alias="ChemicalName")
    mw: float | None = Field(default=None, validation_alias="MW")
    pel_twa_ppm: float | None = Field(default=None, validation_alias="pel_twa")
    pel_twa_mgm3: float | None = Field(default=None, validation_alias="pel_twa_mgm3")
    pel_stel_ppm: float | None = Field(default=None, validation_alias="pel_stel")
    pel_stel_mgm3: float | None = Field(default=None, validation_alias="pel_stel_mgm3")
    pel_ceiling_ppm: float | None = Field(default=None, validation_alias="pel_cl")
    pel_ceiling_mgm3: float | None = Field(default=None, validation_alias="pel_cl_mgm3")
    pel_comments: str | None = Field(default=None, validation_alias="pel_comments")
    rel_twa_ppm: float | None = Field(default=None, validation_alias="rel_twa")
    rel_twa_mgm3: float | None = Field(default=None, validation_alias="rel_twa_mgm3")
    rel_stel_ppm: float | None = Field(default=None, validation_alias="rel_stel")
    rel_stel_mgm3: float | None = Field(default=None, validation_alias="rel_stel_mgm3")
    rel_ceiling_ppm: float | None = Field(default=None, validation_alias="rel_cl")
    rel_ceiling_mgm3: float | None = Field(default=None, validation_alias="rel_cl_mgm3")
    rel_comments: str | None = Field(default=None, validation_alias="rel_comments")

    @field_validator(
        "mw",
        "pel_twa_ppm",
        "pel_twa_mgm3",
        "pel_stel_ppm",
        "pel_stel_mgm3",
        "pel_ceiling_ppm",
        "pel_ceiling_mgm3",
        "rel_twa_ppm",
        "rel_twa_mgm3",
        "rel_stel_ppm",
        "rel_stel_mgm3",
        "rel_ceiling_ppm",
        "rel_ceiling_mgm3",
        mode="before",
    )
    @classmethod
    def _floats(cls, v: object) -> float | None:
        return _opt_float(v)
