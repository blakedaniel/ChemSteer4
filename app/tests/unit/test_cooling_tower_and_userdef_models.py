"""Unit tests for cooling-tower (#12 #13 #14) and user-defined (#39 #43) models.

Cooling tower variants share the residual DR = LF × Amt shape; #43 shares
the vapor-generation outer shell DR = (G × 3600 × OHa) / 1000.
"""

from __future__ import annotations

import math

import pytest

from chemsteer.calc.dispatch import get_release_model
from chemsteer.calc.release.residual import (
    ResidualInput,
    cooling_tower_blowdown,
    cooling_tower_evaporative,
    cooling_tower_windage,
    user_defined_loss_rate,
)
from chemsteer.calc.release.vapor_generation import (
    UserDefinedGInput,
    user_defined_vapor_generation,
)


@pytest.mark.parametrize(
    "fn",
    [
        cooling_tower_blowdown,
        cooling_tower_windage,
        cooling_tower_evaporative,
        user_defined_loss_rate,
    ],
)
def test_residual_shaped_models_use_LF_times_Amt(fn) -> None:  # type: ignore[no-untyped-def]
    out = fn(ResidualInput(Amt=500.0, LF=0.001, Freq=300.0, NS=2.0))
    assert math.isclose(float(out.DR.to("kilogram / (site * day)").magnitude), 0.5, rel_tol=1e-12)
    # AR = 0.5 × 300 × 2 = 300
    assert math.isclose(float(out.AR.to("kilogram / year").magnitude), 300.0, rel_tol=1e-12)


def test_dispatch_registers_phase2c_models() -> None:
    assert get_release_model(12) is cooling_tower_blowdown
    assert get_release_model(13) is cooling_tower_windage
    assert get_release_model(14) is cooling_tower_evaporative
    assert get_release_model(39) is user_defined_loss_rate
    assert get_release_model(43) is user_defined_vapor_generation


def test_user_defined_vapor_generation() -> None:
    """G supplied directly by user, applied through the standard outer shell."""
    out = user_defined_vapor_generation(UserDefinedGInput(G=0.001, OHa=8.0, Freq=250.0, NS=1.0))
    # DR = (0.001 × 3600 × 8) / 1000 = 0.0288 kg/site-day
    assert math.isclose(float(out.DR.to("kilogram / (site * day)").magnitude), 0.0288, rel_tol=1e-9)
    # AR = 0.0288 × 250 × 1 = 7.2 kg/year
    assert math.isclose(float(out.AR.to("kilogram / year").magnitude), 7.2, rel_tol=1e-9)


def test_user_defined_G_zero_yields_zero_release() -> None:
    out = user_defined_vapor_generation(UserDefinedGInput(G=0.0, OHa=8.0, Freq=250.0, NS=1.0))
    assert float(out.DR.to("kilogram / (site * day)").magnitude) == 0.0
    assert float(out.AR.to("kilogram / year").magnitude) == 0.0
