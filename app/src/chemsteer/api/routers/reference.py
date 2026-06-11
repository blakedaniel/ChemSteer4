"""Reference lookups over the master seed DB: NAICS codes and the
OSHA PEL / NIOSH REL chemical-limits table.

v3.2 exposes these as the NAICS picker on the operation editor and the
"View PEL/REL/TWA limits" browser (frmViewPels); here they are search
endpoints the frontend can drive a typeahead/table from.
"""

from __future__ import annotations

from fastapi import APIRouter, Query
from sqlalchemy import or_, select

from chemsteer.api.schemas.reference import ExposureLimitOut, NaicsOut
from chemsteer.db.seed import session
from chemsteer.db.seed_models import Naics, PelRelTwa

router = APIRouter(prefix="/api/reference", tags=["reference"])


@router.get("/naics", response_model=list[NaicsOut])
def search_naics(
    q: str = Query(default="", description="Code prefix or description substring"),
    limit: int = Query(default=50, ge=1, le=500),
) -> list[NaicsOut]:
    stmt = select(Naics).order_by(Naics.naics)
    if q:
        stmt = stmt.where(or_(Naics.naics.like(f"{q}%"), Naics.naicsdesc.like(f"%{q}%")))
    with session("chmsteer") as s:
        rows = s.execute(stmt.limit(limit)).scalars().all()
        return [NaicsOut.model_validate(r) for r in rows]


@router.get("/exposure-limits", response_model=list[ExposureLimitOut])
def search_exposure_limits(
    q: str = Query(default="", description="CAS number or chemical-name substring"),
    limit: int = Query(default=50, ge=1, le=500),
) -> list[ExposureLimitOut]:
    stmt = select(PelRelTwa).order_by(PelRelTwa.ChemicalName)
    if q:
        stmt = stmt.where(
            or_(
                PelRelTwa.CASNumber.like(f"{q}%"),
                PelRelTwa.ChemicalName.like(f"%{q}%"),
            )
        )
    with session("chmsteer") as s:
        rows = s.execute(stmt.limit(limit)).scalars().all()
        return [ExposureLimitOut.model_validate(r) for r in rows]
