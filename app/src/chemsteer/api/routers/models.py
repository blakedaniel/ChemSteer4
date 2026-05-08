from __future__ import annotations

from fastapi import APIRouter, HTTPException, Query
from sqlalchemy import select

from chemsteer.api.schemas.registry import Model, ModelType
from chemsteer.db.seed import session
from chemsteer.db.seed_models import ListOfModels, ListOfValidModels

router = APIRouter(prefix="/api/models", tags=["models"])


@router.get("", response_model=list[Model])
def list_models(
    type: ModelType | None = Query(default=None, description="Filter by R/I/D"),
) -> list[Model]:
    stmt = select(ListOfModels).order_by(ListOfModels.ModelID)
    if type is not None:
        stmt = stmt.where(ListOfModels.Type == type)
    with session("chmsteer") as s:
        rows = s.execute(stmt).scalars().all()
        return [Model.model_validate(r) for r in rows]


@router.get("/{model_id}", response_model=Model)
def get_model(model_id: int) -> Model:
    with session("chmsteer") as s:
        row = s.execute(
            select(ListOfModels).where(ListOfModels.ModelID == str(model_id))
        ).scalar_one_or_none()
        if row is None:
            raise HTTPException(404, f"model {model_id} not found")
        return Model.model_validate(row)


@router.get("/{model_id}/valid-activities", response_model=list[int])
def model_valid_activities(model_id: int) -> list[int]:
    """Activities that may legally invoke this model (per ListOfValidModels)."""
    with session("chmsteer") as s:
        rows = (
            s.execute(
                select(ListOfValidModels.ActID)
                .where(ListOfValidModels.ModelID == str(model_id))
                .order_by(ListOfValidModels.ActID)
            )
            .scalars()
            .all()
        )
        return [int(a) for a in rows]
