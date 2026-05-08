"""Unit tests for the six EPA/OPPT residual-loss release models.

All six share the same arithmetic shape (DR = LF × Amt; AR = DR × Freq × NS);
only the canonical default LF differs. We test the math once with the
shared `_residual` and once per named function so the dispatcher's mapping
stays honest.

Worked example
--------------
A user PMN reports a chemical at 0.15 mass fraction in a product handled
at 1000 kg/site-day, 250 days/year, at 3 sites. With the EPA standard
2.5% drum residual:

    LF   = 0.025
    Amt  = 1000 × 0.15 = 150 kg-chem/site-day
    DR   = LF × Amt    = 3.75 kg-chem/site-day
    Freq = 250 days/year
    NS   = 3 sites
    AR   = DR × Freq × NS = 2812.5 kg-chem/year
"""

from __future__ import annotations

import math

import pytest

from chemsteer.calc.dispatch import RELEASE_MODELS, get_release_model
from chemsteer.calc.release.residual import (
    ResidualInput,
    bulk_transport_residual,
    drum_residual,
    multiple_process_vessel_residual,
    single_process_vessel_residual,
    small_container_residual,
    solid_transport_container_residual,
)


def _approx_kg_per_site_day(q: object) -> float:
    return float(q.to("kilogram / (site * day)").magnitude)  # type: ignore[union-attr]


def _approx_kg_per_year(q: object) -> float:
    return float(q.to("kilogram / year").magnitude)  # type: ignore[union-attr]


def test_drum_residual_user_guide_example() -> None:
    out = drum_residual(
        ResidualInput(
            Amt=150.0,
            LF=0.025,
            Freq=250.0,
            NS=3.0,
        )
    )
    assert math.isclose(_approx_kg_per_site_day(out.DR), 3.75, rel_tol=1e-9)
    assert math.isclose(_approx_kg_per_year(out.AR), 2812.5, rel_tol=1e-9)
    assert float(out.NS.to("site").magnitude) == 3.0


@pytest.mark.parametrize(
    "fn",
    [
        bulk_transport_residual,
        drum_residual,
        multiple_process_vessel_residual,
        single_process_vessel_residual,
        small_container_residual,
        solid_transport_container_residual,
    ],
)
def test_residual_shape_DR_eq_LF_times_Amt(fn) -> None:  # type: ignore[no-untyped-def]
    out = fn(ResidualInput(Amt=200.0, LF=0.05, Freq=100.0, NS=2.0))
    assert math.isclose(_approx_kg_per_site_day(out.DR), 10.0)
    # AR = DR × Freq × NS = 10 × 100 × 2 = 2000
    assert math.isclose(_approx_kg_per_year(out.AR), 2000.0)


def test_zero_amount_yields_zero_release() -> None:
    out = drum_residual(ResidualInput(Amt=0.0, LF=0.025, Freq=250.0, NS=3.0))
    assert _approx_kg_per_site_day(out.DR) == 0.0
    assert _approx_kg_per_year(out.AR) == 0.0


def test_dispatch_registry_maps_residual_models() -> None:
    assert get_release_model(1) is bulk_transport_residual
    assert get_release_model(2) is drum_residual
    assert get_release_model(3) is multiple_process_vessel_residual
    assert get_release_model(4) is single_process_vessel_residual
    assert get_release_model(5) is small_container_residual
    assert get_release_model(6) is solid_transport_container_residual
    assert {1, 2, 3, 4, 5, 6}.issubset(RELEASE_MODELS.keys())


def test_input_accepts_unit_strings() -> None:
    """Pint accepts string-form quantities; useful for API roundtrip."""
    out = drum_residual(
        ResidualInput(
            Amt="150 kilogram / (site * day)",
            LF="0.025 dimensionless",
            Freq="250 day / year",
            NS="3 site",
        )
    )
    assert math.isclose(_approx_kg_per_year(out.AR), 2812.5)
