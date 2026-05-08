"""Map ChemSTEER ``ModelID`` → calc function.

The registry is hand-maintained as we port models from
``decompilation/source/ChemSteer/{RelModels,ExpModels}.cs``.
Cross-checked against ``mdb/ChmSteer/tables/ListOfModels.csv``.
"""

from __future__ import annotations

from chemsteer.calc.base import CalcInput, ModelFn
from chemsteer.calc.exposure import dermal, inhalation, near_far_field, small_volume
from chemsteer.calc.exposure.dermal import DermalInput
from chemsteer.calc.exposure.inhalation import (
    KCkInhalationInput,
    KCkOnlyInput,
    MassBalanceInput,
    OshaPelParticulatesInput,
    OshaVaporPelInput,
    UserDefinedInhalationInput,
)
from chemsteer.calc.exposure.near_far_field import NearFarFieldInput
from chemsteer.calc.exposure.small_volume import SmallVolumeInput
from chemsteer.calc.release import (
    electroplating,
    residual,
    vapor_generation,
    water_saturation,
)
from chemsteer.calc.release.electroplating import RinseWaterInput, SpentBathInput
from chemsteer.calc.release.residual import ResidualInput
from chemsteer.calc.release.vapor_generation import (
    Ap42LoadingInput,
    MassTransferInput,
    PenetrationInput,
    UserDefinedGInput,
)
from chemsteer.calc.release.water_saturation import WaterSaturationInput

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
    21: small_volume.small_volume_handling,
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
    45: inhalation.osha_pel_vapor,
    46: inhalation.user_defined_inhalation,
    47: inhalation.osha_respirable_pnor,
    49: inhalation.auto_oem_spray,
    50: inhalation.auto_refinish_spray,
    54: near_far_field.near_far_field,
}


def get_release_model(model_id: int) -> ModelFn:
    """Return the release-model function for ``model_id`` or raise ``KeyError``."""
    return RELEASE_MODELS[model_id]


def get_exposure_model(model_id: int) -> ModelFn:
    return EXPOSURE_MODELS[model_id]


# --- Input-class lookup (per-model Pydantic schema) ----------------------

RELEASE_INPUT_CLASSES: dict[int, type[CalcInput]] = {
    1: ResidualInput,
    2: ResidualInput,
    3: ResidualInput,
    4: ResidualInput,
    5: ResidualInput,
    6: ResidualInput,
    7: Ap42LoadingInput,
    8: MassTransferInput,
    9: PenetrationInput,
    12: ResidualInput,
    13: ResidualInput,
    14: ResidualInput,
    39: ResidualInput,
    41: ResidualInput,
    42: WaterSaturationInput,
    43: UserDefinedGInput,
    48: ResidualInput,
    51: SpentBathInput,
    52: RinseWaterInput,
    53: ResidualInput,
}

EXPOSURE_INPUT_CLASSES: dict[int, type[CalcInput]] = {
    18: KCkInhalationInput,
    21: SmallVolumeInput,
    22: MassBalanceInput,
    23: OshaPelParticulatesInput,
    24: KCkInhalationInput,
    25: DermalInput,
    26: DermalInput,
    27: DermalInput,
    28: DermalInput,
    29: DermalInput,
    40: KCkOnlyInput,
    44: DermalInput,
    45: OshaVaporPelInput,
    46: UserDefinedInhalationInput,
    47: KCkInhalationInput,
    49: KCkInhalationInput,
    50: KCkInhalationInput,
    54: NearFarFieldInput,
}


def get_input_class(model_kind: str, model_id: int) -> type[CalcInput]:
    """Look up the Pydantic input class for ``(kind, model_id)``."""
    if model_kind == "release":
        cls = RELEASE_INPUT_CLASSES.get(model_id)
    elif model_kind == "exposure":
        cls = EXPOSURE_INPUT_CLASSES.get(model_id)
    else:
        raise KeyError(f"unknown model kind: {model_kind!r}")
    if cls is None:
        raise KeyError(f"no input schema for {model_kind} model {model_id}")
    return cls


def get_model_fn(model_kind: str, model_id: int) -> ModelFn:
    """Look up the calc function for ``(kind, model_id)``."""
    if model_kind == "release":
        fn = RELEASE_MODELS.get(model_id)
    elif model_kind == "exposure":
        fn = EXPOSURE_MODELS.get(model_id)
    else:
        raise KeyError(f"unknown model kind: {model_kind!r}")
    if fn is None:
        raise KeyError(f"{model_kind} model {model_id} not implemented")
    return fn
