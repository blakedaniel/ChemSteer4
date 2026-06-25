"""POST /api/calc/{release|exposure}/{model_id} — direct model invocation.

Given a (kind, model_id) and an input JSON body, validate the body
through the model's Pydantic input class, run the function, and return
the typed output.

The same dispatch helpers are reused by the per-assessment calc trigger
in ``chemsteer.api.routers.assessments``.
"""

from __future__ import annotations

from typing import Literal

from fastapi import APIRouter, HTTPException
from pydantic import BaseModel, Field

from chemsteer.calc.base import ExposureOutput, ReleaseOutput
from chemsteer.calc.dispatch import (
    EXPOSURE_MODELS,
    RELEASE_MODELS,
    get_input_class,
    get_model_fn,
)
from chemsteer.calc.mass_balance import MassBalanceError, solve_mass_balance

router = APIRouter(prefix="/api/calc", tags=["calc"])


class MassBalanceRequest(BaseModel):
    """Knowns for the operation mass balance (frmMDUpdOpIP). Supply
    ``pv_kg_yr`` plus v3.2's three knowns out of {NS, T, DMOchem, Yprod,
    DMOprod}; ``T`` is OD (continuous) or Nby (batch)."""

    pv_kg_yr: float = Field(gt=0, description="Annual production volume (kg/yr)")
    mode: Literal["continuous", "batch"] = "continuous"
    NS: float | None = Field(default=None, description="Number of sites")
    T: float | None = Field(default=None, description="OD (days/site-yr) or Nby (btc/site-yr)")
    DMOchem: float | None = Field(default=None, description="Daily mass of chemical (kg/site-day)")
    Yprod: float | None = Field(default=None, description="Weight fraction of chemical in product")
    DMOprod: float | None = Field(default=None, description="Daily mass of product (kg/site-day)")
    round_up_ns: bool = Field(
        default=False, description="Ceil NS instead of v3.2's nearest-int rounding"
    )


class MassBalanceResponse(BaseModel):
    NS: float
    T: float
    DMOchem: float
    Yprod: float | None
    DMOprod: float | None
    derived: list[str]
    warnings: list[str]


@router.post("/mass-balance", response_model=MassBalanceResponse)
def mass_balance(body: MassBalanceRequest) -> MassBalanceResponse:
    """Solve PV = NS × T × DMOchem (with DMOchem = Yprod × DMOprod) for
    the unknowns, with v3.2's rounding and validity rules."""
    try:
        r = solve_mass_balance(
            body.pv_kg_yr,
            mode=body.mode,
            NS=body.NS,
            T=body.T,
            DMOchem=body.DMOchem,
            Yprod=body.Yprod,
            DMOprod=body.DMOprod,
            round_up_ns=body.round_up_ns,
        )
    except MassBalanceError as exc:
        raise HTTPException(422, str(exc)) from exc
    return MassBalanceResponse(
        NS=r.NS,
        T=r.T,
        DMOchem=r.DMOchem,
        Yprod=r.Yprod,
        DMOprod=r.DMOprod,
        derived=r.derived,
        warnings=r.warnings,
    )


def _run(model_kind: str, model_id: int, body: dict[str, object]) -> object:
    if model_id not in (RELEASE_MODELS if model_kind == "release" else EXPOSURE_MODELS):
        raise HTTPException(
            404,
            f"{model_kind} model {model_id} not implemented",
        )
    input_cls = get_input_class(model_kind, model_id)
    fn = get_model_fn(model_kind, model_id)
    try:
        inp = input_cls.model_validate(body)
    except Exception as exc:
        raise HTTPException(422, f"invalid input: {exc}") from exc
    return fn(inp)


@router.post("/release/{model_id}", response_model=ReleaseOutput)
def run_release_model(model_id: int, body: dict[str, object]) -> ReleaseOutput:
    out = _run("release", model_id, body)
    assert isinstance(out, ReleaseOutput), f"release model {model_id} returned {type(out).__name__}"
    return out


@router.post("/exposure/{model_id}", response_model=ExposureOutput)
def run_exposure_model(model_id: int, body: dict[str, object]) -> ExposureOutput:
    out = _run("exposure", model_id, body)
    assert isinstance(out, ExposureOutput), (
        f"exposure model {model_id} returned {type(out).__name__}"
    )
    return out
