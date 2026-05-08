"""Tests for the final 6 release models: #41 #42 #48 #51 #52 #53."""

from __future__ import annotations

import math

import pytest

from chemsteer.calc.dispatch import RELEASE_MODELS, get_release_model
from chemsteer.calc.release.electroplating import (
    RinseWaterInput,
    SpentBathInput,
    rinse_water_loss,
    spent_bath_disposal,
)
from chemsteer.calc.release.residual import (
    ResidualInput,
    auto_oem_overspray,
    auto_refinish_overspray,
    solids_transfer_dust,
)
from chemsteer.calc.release.water_saturation import (
    WaterSaturationInput,
    water_saturation,
)

# --- Residual-shaped: #41 #48 #53 ----------------------------------------


@pytest.mark.parametrize(
    "fn",
    [auto_refinish_overspray, auto_oem_overspray, solids_transfer_dust],
)
def test_residual_shaped_phase2d(fn) -> None:  # type: ignore[no-untyped-def]
    out = fn(ResidualInput(Amt=100.0, LF=0.35, Freq=200.0, NS=4.0))
    assert math.isclose(float(out.DR.to("kilogram / (site * day)").magnitude), 35.0, rel_tol=1e-12)
    assert math.isclose(float(out.AR.to("kilogram / year").magnitude), 35.0 * 200.0 * 4.0)


# --- #42 Water Saturation -------------------------------------------------


def test_water_saturation_hand_calculation() -> None:
    """DR = WSchem × CF × Amt / 1000.

    With WSchem=10 g/L, CF=1, Amt=500 kg-water/site-day:
      DR = 10 × 1 × 500 / 1000 = 5.0 kg-chem/site-day
    Annual at 250 days × 2 sites: AR = 5 × 250 × 2 = 2500 kg/year.
    """
    out = water_saturation(WaterSaturationInput(WSchem=10.0, CF=1.0, Amt=500.0, Freq=250.0, NS=2.0))
    assert math.isclose(float(out.DR.to("kilogram / (site * day)").magnitude), 5.0, rel_tol=1e-12)
    assert math.isclose(float(out.AR.to("kilogram / year").magnitude), 2500.0, rel_tol=1e-12)


def test_water_saturation_correction_factor_scales_linearly() -> None:
    base = water_saturation(
        WaterSaturationInput(WSchem=10.0, CF=1.0, Amt=500.0, Freq=250.0, NS=1.0)
    )
    half = water_saturation(
        WaterSaturationInput(WSchem=10.0, CF=0.5, Amt=500.0, Freq=250.0, NS=1.0)
    )
    base_dr = float(base.DR.to("kilogram / (site * day)").magnitude)
    half_dr = float(half.DR.to("kilogram / (site * day)").magnitude)
    assert math.isclose(half_dr * 2.0, base_dr)


# --- #51 Spent Bath -------------------------------------------------------


def test_spent_bath_hand_calculation() -> None:
    """DR = DVbath × 3.78 × Ybath × Dbath.

    With DVbath=10 gal/site-day, Ybath=0.05, Dbath=1.2 kg/L:
      DR = 10 × 3.78 × 0.05 × 1.2 = 2.268 kg-chem/site-day
    """
    out = spent_bath_disposal(
        SpentBathInput(DVbath=10.0, Ybath=0.05, Dbath=1.2, Freq=200.0, NS=1.0)
    )
    expected = 10.0 * 3.78 * 0.05 * 1.2
    assert math.isclose(
        float(out.DR.to("kilogram / (site * day)").magnitude), expected, rel_tol=1e-12
    )
    assert math.isclose(
        float(out.AR.to("kilogram / year").magnitude), expected * 200.0, rel_tol=1e-12
    )


# --- #52 Rinse Water ------------------------------------------------------


def test_rinse_water_hand_calculation() -> None:
    """DR = DVrinse × 3.78 × Yrinse × Drinse × (1 − RinseE).

    With DVrinse=100 gal/site-day, Yrinse=0.001, Drinse=1.0 kg/L, RinseE=0.9:
      DR = 100 × 3.78 × 0.001 × 1.0 × (1 − 0.9) = 0.0378 kg-chem/site-day
    """
    out = rinse_water_loss(
        RinseWaterInput(DVrinse=100.0, Yrinse=0.001, Drinse=1.0, RinseE=0.9, Freq=250.0, NS=1.0)
    )
    expected = 100.0 * 3.78 * 0.001 * 1.0 * 0.1
    assert math.isclose(
        float(out.DR.to("kilogram / (site * day)").magnitude), expected, rel_tol=1e-12
    )


def test_rinse_water_full_recovery_yields_zero_release() -> None:
    out = rinse_water_loss(
        RinseWaterInput(DVrinse=100.0, Yrinse=0.001, Drinse=1.0, RinseE=1.0, Freq=250.0, NS=1.0)
    )
    assert float(out.DR.to("kilogram / (site * day)").magnitude) == 0.0


# --- Dispatch wiring: full coverage check --------------------------------


def test_dispatch_registers_all_phase2d_models() -> None:
    assert get_release_model(41) is auto_refinish_overspray
    assert get_release_model(42) is water_saturation
    assert get_release_model(48) is auto_oem_overspray
    assert get_release_model(51) is spent_bath_disposal
    assert get_release_model(52) is rinse_water_loss
    assert get_release_model(53) is solids_transfer_dust


def test_dispatch_covers_every_release_model_in_seed_data() -> None:
    """All release-type ModelIDs in the seed DB must have a registered fn."""
    import sqlite3

    from chemsteer.settings import get_settings

    db = get_settings().seed_data_dir / "chmsteer.db"
    con = sqlite3.connect(db)
    seed_ids = {
        int(r[0])
        for r in con.execute(
            "SELECT ModelID FROM ListOfModels WHERE Type='R' AND ModelID GLOB '[0-9]*';"
        )
    }
    con.close()
    missing = seed_ids - RELEASE_MODELS.keys()
    assert not missing, f"unimplemented release models: {sorted(missing)}"
