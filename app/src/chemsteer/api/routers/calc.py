"""POST /api/calc/{release|exposure}/{model_id} — direct model invocation.

Given a (kind, model_id) and an input JSON body, validate the body
through the model's Pydantic input class, run the function, and return
the typed output.

The same dispatch helpers are reused by the per-assessment calc trigger
in ``chemsteer.api.routers.assessments``.
"""

from __future__ import annotations

from fastapi import APIRouter, HTTPException

from chemsteer.calc.base import ExposureOutput, ReleaseOutput
from chemsteer.calc.dispatch import (
    EXPOSURE_MODELS,
    RELEASE_MODELS,
    get_input_class,
    get_model_fn,
)

router = APIRouter(prefix="/api/calc", tags=["calc"])


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
