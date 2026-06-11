from __future__ import annotations

from fastapi import APIRouter, HTTPException, Query
from sqlalchemy import select

from chemsteer.api.schemas.registry import Model, ModelDefaultsOut, ModelType
from chemsteer.calc.defaults import defaults_for
from chemsteer.calc.dispatch import get_input_class
from chemsteer.calc.parm_map import map_parms
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


@router.get("/{model_id}/defaults", response_model=ModelDefaultsOut)
def model_defaults(
    model_id: int,
    act_id: int = Query(default=0, description="Activity context (ListOfActivities.ActID)"),
    gss_id: int = Query(default=0, description="Generic-Scenario op context (OpID, e.g. 103)"),
) -> ModelDefaultsOut:
    """Input-field defaults for a model, resolved from v3.2's ParmDefaults
    (GSS > activity > model > global precedence) and mapped onto the calc
    input class — what v3.2 pre-fills when the model dialog opens."""
    with session("chmsteer") as s:
        row = s.execute(
            select(ListOfModels).where(ListOfModels.ModelID == str(model_id))
        ).scalar_one_or_none()
    if row is None:
        raise HTTPException(404, f"model {model_id} not found")
    kind = "release" if row.Type == "R" else "exposure"
    try:
        input_cls = get_input_class(kind, model_id)
    except KeyError as exc:
        raise HTTPException(400, f"model {model_id} not implemented in calc engine") from exc
    raw = dict(defaults_for(model_id, act_id=act_id, gss_id=gss_id))
    # Release frequency falls back to the operating-days default (ParmID 2),
    # mirroring how v3.2 seeds the release dialog from the operation.
    if kind == "release" and not raw.get(72) and raw.get(2):
        raw[72] = raw[2]
    defaults, _unmapped = map_parms(kind, model_id, raw)
    return ModelDefaultsOut(
        model_id=model_id,
        model_kind=kind,
        fields=list(input_cls.model_fields.keys()),
        defaults=defaults,
    )


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
