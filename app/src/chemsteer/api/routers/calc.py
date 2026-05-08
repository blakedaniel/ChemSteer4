"""POST /api/calc/release/{model_id} — run a release-model calculation.

Phase 2a ships the six residual-loss models (IDs 1–6); subsequent
commits add the rest. The endpoint validates the input through the
model's Pydantic input class, runs the function, and returns a typed
``ReleaseOutput``.
"""

from __future__ import annotations

from fastapi import APIRouter, HTTPException
from pydantic import BaseModel

from chemsteer.calc.base import CalcInput, ReleaseOutput
from chemsteer.calc.dispatch import RELEASE_MODELS
from chemsteer.calc.release.residual import ResidualInput
from chemsteer.calc.release.vapor_generation import (
    Ap42LoadingInput,
    MassTransferInput,
    PenetrationInput,
)

router = APIRouter(prefix="/api/calc", tags=["calc"])

# Per-model input schema. Keep this hand-mapped alongside RELEASE_MODELS so
# FastAPI knows the exact request body type per model. As more models are
# ported, add their (input_class, model_id) pair here.
_RELEASE_INPUT_CLASSES: dict[int, type[CalcInput]] = {
    1: ResidualInput,
    2: ResidualInput,
    3: ResidualInput,
    4: ResidualInput,
    5: ResidualInput,
    6: ResidualInput,
    7: Ap42LoadingInput,
    8: MassTransferInput,
    9: PenetrationInput,
}

assert all(issubclass(cls, BaseModel) for cls in _RELEASE_INPUT_CLASSES.values())


@router.post("/release/{model_id}", response_model=ReleaseOutput)
def run_release_model(model_id: int, body: dict[str, object]) -> ReleaseOutput:
    """Run release model ``model_id`` with the given parameter set."""
    fn = RELEASE_MODELS.get(model_id)
    if fn is None:
        raise HTTPException(
            404,
            f"release model {model_id} not implemented yet "
            f"(implemented: {sorted(RELEASE_MODELS.keys())})",
        )
    input_cls = _RELEASE_INPUT_CLASSES.get(model_id)
    if input_cls is None:  # safety net — should match RELEASE_MODELS exactly
        raise HTTPException(500, f"no input schema registered for model {model_id}")
    try:
        inp = input_cls.model_validate(body)
    except Exception as exc:
        raise HTTPException(422, f"invalid input: {exc}") from exc
    out = fn(inp)
    # All currently-registered release models return ReleaseOutput; the
    # heterogeneous dispatch type is widened on purpose, so narrow here.
    assert isinstance(out, ReleaseOutput), (
        f"model {model_id} returned {type(out).__name__}, expected ReleaseOutput"
    )
    return out
