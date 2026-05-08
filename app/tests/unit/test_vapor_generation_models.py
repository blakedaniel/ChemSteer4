"""Unit tests for the three vapor-generation release models.

Hand-computed expected values are derived directly from the equations in
``ListOfModels.Equation`` (cross-referenced with Barrett et al. 2023 Eqs
2/3/4) using carefully-chosen inputs that keep the arithmetic tractable.
"""

from __future__ import annotations

import math

import pytest

from chemsteer.calc.dispatch import get_release_model
from chemsteer.calc.release.vapor_generation import (
    Ap42LoadingInput,
    MassTransferInput,
    PenetrationInput,
    ap42_loading,
    mass_transfer_coefficient,
    penetration,
)


def _G_from_DR(out: object, OHa: float) -> float:
    """Recover G (g/s) from DR (kg/site-day) for sanity-checking."""
    DR = float(out.DR.to("kilogram / (site * day)").magnitude)  # type: ignore[union-attr]
    # DR = (G × 3600 × OHa) / 1000 → G = DR × 1000 / (3600 × OHa)
    return DR * 1000.0 / (3600.0 * OHa)


# --- Model 7: AP-42 Loading ----------------------------------------------


def test_ap42_loading_against_hand_calculation() -> None:
    """G = f × MW × (Vc × 3785.4) × r × X × (VP / 760) / (3600 × T × R)
    With f=1, MW=100, Vc=55, r=10, X=0.5, VP=10, T=298, R=82.057, OHa=8.

    G = 1 × 100 × (55 × 3785.4) × 10 × 0.5 × (10/760) / (3600 × 298 × 82.057)
      = 100 × 208197 × 10 × 0.5 × 0.013158 / 88,029,778.96
      = 100 × 208197 × 5 × 0.013158 / 88,029,778.96
      = 13697.7 / 88,029,778.96  (numerator after the multiplications)
      ≈ 1.5560e-4 g/s
    DR = (G × 3600 × 8) / 1000 = G × 28.8 = 4.481e-3 kg/site-day
    """
    out = ap42_loading(
        Ap42LoadingInput(
            f=1.0,
            MW=100.0,
            Vc=55.0,
            r=10.0,
            X=0.5,
            VP=10.0,
            T=298.0,
            R=82.057,
            OHa=8.0,
            Freq=250.0,
            NS=1.0,
        )
    )

    # Expected G computed in pure Python with the same constants
    expected_G = (1.0 * 100.0 * (55.0 * 3785.4) * 10.0 * 0.5 * (10.0 / 760.0)) / (
        3600.0 * 298.0 * 82.057
    )
    expected_DR = expected_G * 3600.0 * 8.0 / 1000.0
    expected_AR = expected_DR * 250.0 * 1.0

    assert math.isclose(_G_from_DR(out, 8.0), expected_G, rel_tol=1e-9)
    assert math.isclose(
        float(out.DR.to("kilogram / (site * day)").magnitude),
        expected_DR,
        rel_tol=1e-9,
    )
    assert math.isclose(
        float(out.AR.to("kilogram / year").magnitude),
        expected_AR,
        rel_tol=1e-9,
    )


def test_ap42_zero_vapor_pressure_yields_zero_release() -> None:
    out = ap42_loading(
        Ap42LoadingInput(
            f=1.0,
            MW=100.0,
            Vc=55.0,
            r=10.0,
            X=0.5,
            VP=0.0,
            T=298.0,
            R=82.057,
            OHa=8.0,
            Freq=250.0,
            NS=1.0,
        )
    )
    assert float(out.DR.to("kilogram / (site * day)").magnitude) == 0.0
    assert float(out.AR.to("kilogram / year").magnitude) == 0.0


# --- Model 8: Mass Transfer Coefficient ----------------------------------


def test_mass_transfer_against_hand_calculation() -> None:
    """G = 1.93e-7 × MW^0.78 × X × VP × (1/29 + 1/MW)^0.33
    × vz^0.78 × A
    / (T^0.4 × d^0.11 × (T^0.5 - 5.87)^(2/3))
    """
    MW, X, VP, vz, A, T, d = 100.0, 0.5, 10.0, 100.0, 1000.0, 298.0, 30.0
    OHa, Freq, NS = 8.0, 250.0, 2.0

    out = mass_transfer_coefficient(
        MassTransferInput(MW=MW, X=X, VP=VP, vz=vz, A=A, T=T, d=d, OHa=OHa, Freq=Freq, NS=NS)
    )

    num = 1.93e-7 * MW**0.78 * X * VP * (1.0 / 29.0 + 1.0 / MW) ** 0.33 * vz**0.78 * A
    den = T**0.4 * d**0.11 * (T**0.5 - 5.87) ** (2.0 / 3.0)
    expected_G = num / den
    expected_DR = expected_G * 3600.0 * OHa / 1000.0
    expected_AR = expected_DR * Freq * NS

    assert math.isclose(_G_from_DR(out, OHa), expected_G, rel_tol=1e-9)
    assert math.isclose(
        float(out.DR.to("kilogram / (site * day)").magnitude), expected_DR, rel_tol=1e-9
    )
    assert math.isclose(float(out.AR.to("kilogram / year").magnitude), expected_AR, rel_tol=1e-9)


# --- Model 9: Penetration -------------------------------------------------


def test_penetration_against_hand_calculation() -> None:
    """G = 8.24e-8 × MW^0.835 × X × VP × (1/29 + 1/MW)^0.25
    × vz^0.5 × A
    / (T^0.05 × d^0.5 × P^0.5)
    """
    MW, X, VP, vz, A, T, d, P = 100.0, 0.5, 10.0, 30.0, 1000.0, 298.0, 30.0, 1.0
    OHa, Freq, NS = 8.0, 250.0, 1.0

    out = penetration(
        PenetrationInput(MW=MW, X=X, VP=VP, vz=vz, A=A, T=T, d=d, P=P, OHa=OHa, Freq=Freq, NS=NS)
    )

    num = 8.24e-8 * MW**0.835 * X * VP * (1.0 / 29.0 + 1.0 / MW) ** 0.25 * vz**0.5 * A
    den = T**0.05 * d**0.5 * P**0.5
    expected_G = num / den
    expected_DR = expected_G * 3600.0 * OHa / 1000.0

    assert math.isclose(_G_from_DR(out, OHa), expected_G, rel_tol=1e-9)
    assert math.isclose(
        float(out.DR.to("kilogram / (site * day)").magnitude), expected_DR, rel_tol=1e-9
    )


# --- Dispatch wiring ------------------------------------------------------


@pytest.mark.parametrize(
    "model_id, fn",
    [
        (7, ap42_loading),
        (8, mass_transfer_coefficient),
        (9, penetration),
    ],
)
def test_dispatch_registers_vapor_models(model_id, fn) -> None:  # type: ignore[no-untyped-def]
    assert get_release_model(model_id) is fn


# --- Unit-conversion smoke ------------------------------------------------


def test_ap42_accepts_mw_in_kilograms_per_kmol() -> None:
    """Pint should auto-convert kg/kmol → g/mol (they're equal)."""
    out_g_per_mol = ap42_loading(
        Ap42LoadingInput(
            f=1.0,
            MW=100.0,
            Vc=55.0,
            r=10.0,
            X=0.5,
            VP=10.0,
            T=298.0,
            R=82.057,
            OHa=8.0,
            Freq=250.0,
            NS=1.0,
        )
    )
    out_kg_per_kmol = ap42_loading(
        Ap42LoadingInput(
            f=1.0,
            MW="100 kilogram / kilomole",
            Vc=55.0,
            r=10.0,
            X=0.5,
            VP=10.0,
            T=298.0,
            R=82.057,
            OHa=8.0,
            Freq=250.0,
            NS=1.0,
        )
    )
    assert math.isclose(
        float(out_g_per_mol.DR.to("kilogram / (site * day)").magnitude),
        float(out_kg_per_kmol.DR.to("kilogram / (site * day)").magnitude),
        rel_tol=1e-12,
    )
