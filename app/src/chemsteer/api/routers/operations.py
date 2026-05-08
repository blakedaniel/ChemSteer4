from __future__ import annotations

from fastapi import APIRouter, HTTPException
from sqlalchemy import select

from chemsteer.api.schemas.registry import Operation
from chemsteer.db.seed import session
from chemsteer.db.seed_models import ListOfOperations

router = APIRouter(prefix="/api/operations", tags=["operations"])


@router.get("", response_model=list[Operation])
def list_operations() -> list[Operation]:
    with session("chmsteer") as s:
        rows = s.execute(select(ListOfOperations).order_by(ListOfOperations.OpID)).scalars().all()
        return [Operation.model_validate(r) for r in rows]


@router.get("/{op_id}", response_model=Operation)
def get_operation(op_id: int) -> Operation:
    with session("chmsteer") as s:
        row = s.execute(
            select(ListOfOperations).where(ListOfOperations.OpID == str(op_id))
        ).scalar_one_or_none()
        if row is None:
            raise HTTPException(404, f"operation {op_id} not found")
        return Operation.model_validate(row)
