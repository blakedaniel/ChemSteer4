"""Map ChemSTEER ``ModelID`` → calc function.

The registry is hand-maintained as we port models from
``decompilation/source/ChemSteer/{RelModels,ExpModels}.cs``.
Cross-checked against ``mdb/ChmSteer/tables/ListOfModels.csv``.
"""

from __future__ import annotations

from chemsteer.calc.base import ModelFn
from chemsteer.calc.release import residual, vapor_generation

RELEASE_MODELS: dict[int, ModelFn] = {
    1: residual.bulk_transport_residual,
    2: residual.drum_residual,
    3: residual.multiple_process_vessel_residual,
    4: residual.single_process_vessel_residual,
    5: residual.small_container_residual,
    6: residual.solid_transport_container_residual,
    7: vapor_generation.ap42_loading,
    8: vapor_generation.mass_transfer_coefficient,
    9: vapor_generation.penetration,
    # Models 10+: ported in subsequent commits.
}

EXPOSURE_MODELS: dict[int, ModelFn] = {
    # Phase 3.
}


def get_release_model(model_id: int) -> ModelFn:
    """Return the release-model function for ``model_id`` or raise ``KeyError``."""
    return RELEASE_MODELS[model_id]


def get_exposure_model(model_id: int) -> ModelFn:
    return EXPOSURE_MODELS[model_id]
