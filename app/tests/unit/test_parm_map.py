"""Tests for the ParmID → calc-field translation layer."""

from __future__ import annotations

import math

from chemsteer.calc.parm_map import map_parms
from chemsteer.calc.release.residual import ResidualInput, drum_residual


def test_residual_parms_map_to_fields() -> None:
    inputs, unmapped = map_parms(
        "release",
        2,  # Drum Residual
        {92: 1000.0, 73: 0.025, 72: 250.0, 1: 3.0, 16: 40.0},
    )
    assert inputs == {"Amt": 1000.0, "LF": 0.025, "Freq": 250.0, "NS": 3.0}
    # Nby (16) is a mass-balance work field, not a model input.
    assert unmapped == {16: 40.0}


def test_zero_values_mean_not_filled_in() -> None:
    inputs, unmapped = map_parms("release", 2, {92: 1000.0, 73: 0.0, 1: 0.0})
    assert inputs == {"Amt": 1000.0}
    assert unmapped == {}


def test_mapped_inputs_validate_and_run() -> None:
    inputs, _ = map_parms("release", 2, {92: 1000.0, 73: 0.025, 72: 250.0, 1: 1.0})
    out = drum_residual(ResidualInput(**inputs))
    assert math.isclose(float(out.DR.magnitude), 25.0, rel_tol=1e-9)


def test_cooling_tower_overrides_take_drrchem_not_amt() -> None:
    """#13 windage: Amt ← DRRchem (130), LF ← LFw (128).

    The generic Amt (92) and LF (73) parms ride along on scenario rows
    as work fields and must be ignored for the cooling-tower models.
    """
    inputs, unmapped = map_parms(
        "release",
        13,
        {130: 500.0, 128: 0.001, 92: 999.0, 73: 0.5, 72: 360.0, 1: 1.0},
    )
    assert inputs["Amt"] == 500.0
    assert inputs["LF"] == 0.001
    assert inputs["Freq"] == 360.0
    # The shadowed generic parms are dropped silently, not "unmapped".
    assert unmapped == {}


def test_unit_override_wraps_value() -> None:
    inputs, _ = map_parms("exposure", 54, {151: 3.6e6, 148: 1.0})
    assert inputs["G"] == {"value": 3.6e6, "unit": "milligram / hour"}
    assert inputs["LNF"] == 1.0


def test_exposure_dermal_mapping() -> None:
    inputs, _ = map_parms(
        "exposure",
        26,  # 2-hand dermal liquid
        {
            36: 1070.0,
            37: 2.1,
            77: 0.5,
            60: 1.0,
            75: 250.0,
            41: 40.0,
            42: 80.0,
            47: 40.0,
            48: 78.0,
            91: 3.0,
            1: 2.0,
        },
    )
    assert inputs["S"] == 1070.0
    assert inputs["Wf"] == 0.5  # ParmID 77 is Yderm in v3.2
    assert inputs["Y"] == 40.0  # ParmID 41 is EY in v3.2
    assert set(inputs) == {"S", "Qu", "Wf", "FT", "ED", "Y", "BW", "AT", "ATc", "NWexp", "NS"}
