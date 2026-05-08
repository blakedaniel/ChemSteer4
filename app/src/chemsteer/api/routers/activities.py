from __future__ import annotations

from fastapi import APIRouter, HTTPException
from sqlalchemy import select

from chemsteer.api.schemas.registry import Activity
from chemsteer.db.seed import session
from chemsteer.db.seed_models import ListOfActivities

router = APIRouter(prefix="/api/activities", tags=["activities"])


@router.get("", response_model=list[Activity])
def list_activities() -> list[Activity]:
    with session("chmsteer") as s:
        rows = s.execute(select(ListOfActivities).order_by(ListOfActivities.ActID)).scalars().all()
        return [Activity.model_validate(r) for r in rows]


@router.get("/{act_id}", response_model=Activity)
def get_activity(act_id: int) -> Activity:
    with session("chmsteer") as s:
        row = s.execute(
            select(ListOfActivities).where(ListOfActivities.ActID == str(act_id))
        ).scalar_one_or_none()
        if row is None:
            raise HTTPException(404, f"activity {act_id} not found")
        return Activity.model_validate(row)
