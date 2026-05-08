from __future__ import annotations

from fastapi import APIRouter
from sqlalchemy import select

from chemsteer.api.schemas.registry import GenericScenarioOut
from chemsteer.db.seed import session
from chemsteer.db.seed_models import GenericScenario

router = APIRouter(prefix="/api/scenarios", tags=["scenarios"])


@router.get("", response_model=list[GenericScenarioOut])
def list_scenarios() -> list[GenericScenarioOut]:
    """The 34 Generic Scenarios shipped in scenarios.epa::Operations."""
    with session("scenarios") as s:
        rows = s.execute(select(GenericScenario).order_by(GenericScenario.OpID)).scalars().all()
        return [GenericScenarioOut.model_validate(r) for r in rows]
