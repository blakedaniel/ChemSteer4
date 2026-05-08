"""Hypothesis property-based tests for release-model invariants.

These don't validate against ChemSTEER v3.2 (see VALIDATION.md for the
golden-master capture plan), but they pin down the mathematical
invariants the equations must hold regardless of input.
"""

from __future__ import annotations

import math

from hypothesis import given, settings
from hypothesis import strategies as st

from chemsteer.calc.dispatch import RELEASE_MODELS
from chemsteer.calc.release.electroplating import (
    RinseWaterInput,
    SpentBathInput,
    rinse_water_loss,
    spent_bath_disposal,
)
from chemsteer.calc.release.residual import ResidualInput
from chemsteer.calc.release.water_saturation import (
    WaterSaturationInput,
    water_saturation,
)


# Reasonable industrial-screening ranges; avoid degenerate zero/inf cases.
_amt = st.floats(min_value=1e-3, max_value=1e6, allow_nan=False, allow_infinity=False)
_lf = st.floats(min_value=1e-6, max_value=1.0, allow_nan=False, allow_infinity=False)
_freq = st.floats(min_value=1.0, max_value=365.0, allow_nan=False, allow_infinity=False)
_ns = st.floats(min_value=1.0, max_value=10_000.0, allow_nan=False, allow_infinity=False)


def _kg_per_site_day(q: object) -> float:
    return float(q.to("kilogram / (site * day)").magnitude)  # type: ignore[union-attr]


def _kg_per_year(q: object) -> float:
    return float(q.to("kilogram / year").magnitude)  # type: ignore[union-attr]


@given(_amt, _lf, _freq, _ns)
@settings(max_examples=100)
def test_residual_DR_equals_LF_times_Amt(amt: float, lf: float, freq: float, ns: float) -> None:
    """Invariant: DR == LF × Amt for any (LF*Amt)-shaped model (1 of the 7).

    Picks ModelID 2 (drum residual) as the representative; all 7 share
    the same arithmetic so they collapse to the same property.
    """
    fn = RELEASE_MODELS[2]
    out = fn(ResidualInput(Amt=amt, LF=lf, Freq=freq, NS=ns))
    expected_DR = lf * amt
    assert math.isclose(_kg_per_site_day(out.DR), expected_DR, rel_tol=1e-9)


@given(_amt, _lf, _freq, _ns)
@settings(max_examples=100)
def test_AR_equals_DR_times_Freq_times_NS(amt: float, lf: float, freq: float, ns: float) -> None:
    """Mass-balance invariant for residual-shaped models."""
    fn = RELEASE_MODELS[2]
    out = fn(ResidualInput(Amt=amt, LF=lf, Freq=freq, NS=ns))
    DR = _kg_per_site_day(out.DR)
    expected_AR = DR * freq * ns
    assert math.isclose(_kg_per_year(out.AR), expected_AR, rel_tol=1e-9)


@given(_amt, _lf, _freq, _ns)
@settings(max_examples=50)
def test_DR_is_non_negative(amt: float, lf: float, freq: float, ns: float) -> None:
    """Release rate must be ≥ 0 for any non-negative inputs."""
    fn = RELEASE_MODELS[2]
    out = fn(ResidualInput(Amt=amt, LF=lf, Freq=freq, NS=ns))
    assert _kg_per_site_day(out.DR) >= 0.0
    assert _kg_per_year(out.AR) >= 0.0


@given(_amt, _lf, _freq, _ns, st.floats(min_value=0.1, max_value=100.0, allow_nan=False))
@settings(max_examples=50)
def test_DR_scales_linearly_with_Amt(
    amt: float, lf: float, freq: float, ns: float, scale: float
) -> None:
    """Doubling Amt should double DR (any positive scale)."""
    fn = RELEASE_MODELS[2]
    a1 = fn(ResidualInput(Amt=amt, LF=lf, Freq=freq, NS=ns))
    a2 = fn(ResidualInput(Amt=amt * scale, LF=lf, Freq=freq, NS=ns))
    DR1 = _kg_per_site_day(a1.DR)
    DR2 = _kg_per_site_day(a2.DR)
    assert math.isclose(DR2, DR1 * scale, rel_tol=1e-9)


@given(
    st.floats(min_value=1e-3, max_value=1000.0, allow_nan=False),  # WSchem
    st.floats(min_value=0.0, max_value=1.0, allow_nan=False),  # CF
    st.floats(min_value=0.0, max_value=1e6, allow_nan=False),  # Amt
    _freq,
    _ns,
)
@settings(max_examples=50)
def test_water_saturation_DR_formula(
    wsc: float, cf: float, amt: float, freq: float, ns: float
) -> None:
    """DR = WSchem × CF × Amt / 1000 (model #42)."""
    out = water_saturation(WaterSaturationInput(WSchem=wsc, CF=cf, Amt=amt, Freq=freq, NS=ns))
    expected = wsc * cf * amt / 1000.0
    assert math.isclose(_kg_per_site_day(out.DR), expected, rel_tol=1e-9)


@given(
    st.floats(min_value=0.0, max_value=1000.0, allow_nan=False),  # DVbath
    st.floats(min_value=0.0, max_value=1.0, allow_nan=False),  # Ybath
    st.floats(min_value=0.5, max_value=2.0, allow_nan=False),  # Dbath
    _freq,
    _ns,
)
@settings(max_examples=50)
def test_spent_bath_DR_formula(
    dv: float, y: float, d: float, freq: float, ns: float
) -> None:
    """DR = DVbath × 3.78 × Ybath × Dbath (model #51)."""
    out = spent_bath_disposal(SpentBathInput(DVbath=dv, Ybath=y, Dbath=d, Freq=freq, NS=ns))
    expected = dv * 3.78 * y * d
    assert math.isclose(_kg_per_site_day(out.DR), expected, rel_tol=1e-9)


@given(
    st.floats(min_value=0.0, max_value=1000.0, allow_nan=False),  # DVrinse
    st.floats(min_value=0.0, max_value=0.1, allow_nan=False),  # Yrinse
    st.floats(min_value=0.5, max_value=2.0, allow_nan=False),  # Drinse
    st.floats(min_value=0.0, max_value=1.0, allow_nan=False),  # RinseE
    _freq,
    _ns,
)
@settings(max_examples=50)
def test_rinse_water_full_recovery_implies_zero_release(
    dv: float, y: float, d: float, eff: float, freq: float, ns: float
) -> None:
    """RinseE = 1 ⇒ DR = 0 (model #52)."""
    out = rinse_water_loss(
        RinseWaterInput(
            DVrinse=dv, Yrinse=y, Drinse=d, RinseE=1.0, Freq=freq, NS=ns
        )
    )
    assert _kg_per_site_day(out.DR) == 0.0
    # And confirm a partial-recovery case is non-zero (non-trivial property)
    if dv > 0 and y > 0 and d > 0:
        out_partial = rinse_water_loss(
            RinseWaterInput(
                DVrinse=dv, Yrinse=y, Drinse=d, RinseE=0.5, Freq=freq, NS=ns
            )
        )
        assert _kg_per_site_day(out_partial.DR) > 0.0
