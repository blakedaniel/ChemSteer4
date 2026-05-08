"""Map ChemSTEER ``ModelID`` → calc function.

The registry is hand-maintained as we port models from
``decompilation/source/ChemSteer/{RelModels,ExpModels}.cs``.
Cross-checked against ``mdb/ChmSteer/tables/ListOfModels.csv``.
"""

from __future__ import annotations

from chemsteer.calc.base import ModelFn
from chemsteer.calc.exposure import dermal, inhalation
from chemsteer.calc.release import (
    electroplating,
    residual,
    vapor_generation,
    water_saturation,
)

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
    12: residual.cooling_tower_blowdown,
    13: residual.cooling_tower_windage,
    14: residual.cooling_tower_evaporative,
    39: residual.user_defined_loss_rate,
    41: residual.auto_refinish_overspray,
    42: water_saturation.water_saturation,
    43: vapor_generation.user_defined_vapor_generation,
    48: residual.auto_oem_overspray,
    51: electroplating.spent_bath_disposal,
    52: electroplating.rinse_water_loss,
    53: residual.solids_transfer_dust,
}

EXPOSURE_MODELS: dict[int, ModelFn] = {
    18: inhalation.uv_roll_coating,
    22: inhalation.mass_balance,
    23: inhalation.osha_pel_particulates,
    24: inhalation.osha_total_pnor,
    25: dermal.dermal_1hand_liquid,
    26: dermal.dermal_2hand_liquid,
    27: dermal.dermal_2hand_immersion,
    28: dermal.dermal_2hand_solids,
    29: dermal.dermal_2hand_container_solids,
    40: inhalation.auto_spray_polyiso,
    44: dermal.user_defined_dermal,
    46: inhalation.user_defined_inhalation,
    47: inhalation.osha_respirable_pnor,
    49: inhalation.auto_oem_spray,
    50: inhalation.auto_refinish_spray,
    # Models 21 (Small Volume), 45 (OSHA Vapor PEL), 54 (NF/FF): ported next.
}


def get_release_model(model_id: int) -> ModelFn:
    """Return the release-model function for ``model_id`` or raise ``KeyError``."""
    return RELEASE_MODELS[model_id]


def get_exposure_model(model_id: int) -> ModelFn:
    return EXPOSURE_MODELS[model_id]
