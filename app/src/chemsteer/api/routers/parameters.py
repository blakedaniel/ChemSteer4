from __future__ import annotations

from fastapi import APIRouter, HTTPException
from sqlalchemy import select

from chemsteer.api.schemas.registry import Parameter
from chemsteer.db.seed import session
from chemsteer.db.seed_models import ListOfParms

router = APIRouter(prefix="/api/parameters", tags=["parameters"])


@router.get("", response_model=list[Parameter])
def list_parameters() -> list[Parameter]:
    with session("chmsteer") as s:
        rows = s.execute(select(ListOfParms).order_by(ListOfParms.ParmID)).scalars().all()
        return [Parameter.model_validate(r) for r in rows]


@router.get("/{parm_id}", response_model=Parameter)
def get_parameter(parm_id: int) -> Parameter:
    with session("chmsteer") as s:
        row = s.execute(
            select(ListOfParms).where(ListOfParms.ParmID == str(parm_id))
        ).scalar_one_or_none()
        if row is None:
            raise HTTPException(404, f"parameter {parm_id} not found")
        return Parameter.model_validate(row)
