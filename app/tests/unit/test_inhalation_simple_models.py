"""Unit tests for the KCk-based + Cv-based inhalation models.

Covers Family A (KCk-based: #18 #23 #24 #40 #47 #49 #50) and
Family B (Mass Balance #22 + user-defined Cv #46).
"""

from __future__ import annotations

import math

import pytest

from chemsteer.calc.dispatch import EXPOSURE_MODELS, get_exposure_model
from chemsteer.calc.exposure.inhalation import (
    KCkInhalationInput,
    KCkOnlyInput,
    MassBalanceInput,
    OshaPelParticulatesInput,
    UserDefinedInhalationInput,
    auto_oem_spray,
    auto_refinish_spray,
    auto_spray_polyiso,
    mass_balance,
    osha_pel_particulates,
    osha_respirable_pnor,
    osha_total_pnor,
    user_defined_inhalation,
    uv_roll_coating,
)


def _mg_per_day(q: object) -> float:
    return float(q.to("milligram / day").magnitude)  # type: ignore[union-attr]


def _mg_per_kg_per_day(q: object) -> float:
    return float(q.to("milligram / kilogram / day").magnitude)  # type: ignore[union-attr]


# --- KCk-based family ----------------------------------------------------


def test_kck_ys_inhalation_arithmetic() -> None:
    """Cm = KCk × Ys; I = Cm × b × h.

    With KCk=15 mg/m³, Ys=0.10, b=1.25 m³/hr, h=8 hrs/day:
      Cm = 1.5 mg/m³
      I  = 1.5 × 1.25 × 8 = 15 mg/day
    """
    out = uv_roll_coating(
        KCkInhalationInput(
            KCk=15.0,
            Ys=0.10,
            b=1.25,
            h=8.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=10.0,
            NS=2.0,
        )
    )
    assert out.I is not None
    assert math.isclose(_mg_per_day(out.I), 15.0, rel_tol=1e-12)
    # APDR = 15 / 80
    assert math.isclose(_mg_per_kg_per_day(out.APDR), 15.0 / 80.0, rel_tol=1e-12)


@pytest.mark.parametrize(
    "fn",
    [
        uv_roll_coating,
        osha_total_pnor,
        osha_respirable_pnor,
        auto_oem_spray,
        auto_refinish_spray,
    ],
)
def test_kck_ys_family_share_arithmetic(fn) -> None:  # type: ignore[no-untyped-def]
    inp = KCkInhalationInput(
        KCk=10.0,
        Ys=0.5,
        b=1.0,
        h=8.0,
        ED=250.0,
        Y=40.0,
        BW=80.0,
        AT=40.0,
        ATc=78.0,
        NWexp=1.0,
        NS=1.0,
    )
    out = fn(inp)
    # Cm = 10 × 0.5 = 5 mg/m³ → I = 5 × 1 × 8 = 40 mg/day
    assert out.I is not None
    assert math.isclose(_mg_per_day(out.I), 40.0, rel_tol=1e-12)


def test_auto_spray_polyiso_kck_only() -> None:
    """ModelID 40: Cm = KCk (no Ys factor)."""
    out = auto_spray_polyiso(
        KCkOnlyInput(
            KCk=2.0,
            b=1.25,
            h=8.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    assert out.I is not None
    # I = 2 × 1.25 × 8 = 20 mg/day
    assert math.isclose(_mg_per_day(out.I), 20.0, rel_tol=1e-12)


def test_osha_pel_particulates_includes_ypel_division() -> None:
    """Cm = KCk × Ys / Ypel — substance-specific PEL adjustment."""
    out = osha_pel_particulates(
        OshaPelParticulatesInput(
            KCk=5.0,
            Ys=0.5,
            Ypel=0.25,
            b=1.25,
            h=8.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    assert out.I is not None
    # Cm = 5 × 0.5 / 0.25 = 10 mg/m³ → I = 10 × 1.25 × 8 = 100 mg/day
    assert math.isclose(_mg_per_day(out.I), 100.0, rel_tol=1e-12)


# --- Mass Balance --------------------------------------------------------


def test_mass_balance_takes_lesser_of_two_Cv() -> None:
    """Mass Balance: Cv = min(generation-limited, saturation-limited).

    Generation-limited: Cv1 = (170000 × T × G) / (MW × Q × k), Q in ft³/min
    Saturation-limited: Cv2 = 1e6 × X × VP / 760

    With G=0.001, T=298, MW=100, Q=10 ft³/min, k=0.5, X=0.5, VP=10, Vm=24.45:
      Cv1 = (170000 × 298 × 0.001) / (100 × 10 × 0.5) = 50660 / 500 = 101.32
      Cv2 = 1e6 × 0.5 × 10 / 760 = 6578.95
      Cv  = min(101.32, 6578.95) = 101.32 (generation-limited)
      Cm  = Cv × MW / Vm = 101.32 × 100 / 24.45 ≈ 414.41 mg/m³
      I   = Cm × b × h = 414.41 × 1.25 × 8 ≈ 4144.1 mg/day
    """
    out = mass_balance(
        MassBalanceInput(
            G=0.001,
            MW=100.0,
            T=298.0,
            Q=10.0,
            k=0.5,
            X=0.5,
            VP=10.0,
            Vm=24.45,
            b=1.25,
            h=8.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    Cv1 = (170000.0 * 298.0 * 0.001) / (100.0 * 10.0 * 0.5)
    Cv2 = 1_000_000.0 * 0.5 * 10.0 / 760.0
    Cv = min(Cv1, Cv2)
    Cm = Cv * 100.0 / 24.45
    I_expected = Cm * 1.25 * 8.0

    assert out.I is not None
    assert math.isclose(_mg_per_day(out.I), I_expected, rel_tol=1e-9)


def test_mass_balance_saturation_limited_branch() -> None:
    """When Cv2 < Cv1, the model caps at saturation."""
    # Choose inputs where Cv1 is huge but Cv2 is small (low VP)
    out = mass_balance(
        MassBalanceInput(
            G=1.0,  # huge G → huge Cv1
            MW=100.0,
            T=298.0,
            Q=10.0,
            k=0.5,
            X=0.5,
            VP=0.001,  # tiny VP → tiny Cv2
            Vm=24.45,
            b=1.25,
            h=8.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    Cv1 = (170000.0 * 298.0 * 1.0) / (100.0 * 10.0 * 0.5)
    Cv2 = 1_000_000.0 * 0.5 * 0.001 / 760.0
    assert Cv2 < Cv1
    Cm_expected = Cv2 * 100.0 / 24.45
    I_expected = Cm_expected * 1.25 * 8.0
    assert out.I is not None
    assert math.isclose(_mg_per_day(out.I), I_expected, rel_tol=1e-9)


def test_mass_balance_Q_unit_is_cfm() -> None:
    """Bare-float Q means ft³/min (v3.2 ParmID 53); explicit units convert.

    Passing Q as 1.699011 m³/hr (= 1 ft³/min) must equal passing Q=1.0.
    """
    kwargs = dict(
        G=0.001,
        MW=100.0,
        T=298.0,
        k=0.5,
        X=0.5,
        VP=10.0,
        Vm=24.45,
        b=1.25,
        h=8.0,
        ED=250.0,
        Y=40.0,
        BW=80.0,
        AT=40.0,
        ATc=78.0,
        NWexp=1.0,
        NS=1.0,
    )
    bare = mass_balance(MassBalanceInput(Q=1.0, **kwargs))
    explicit = mass_balance(
        MassBalanceInput(Q={"value": 1.0, "unit": "foot ** 3 / minute"}, **kwargs)
    )
    metric = mass_balance(
        MassBalanceInput(Q={"value": 1.699011, "unit": "meter ** 3 / hour"}, **kwargs)
    )
    assert bare.I is not None and explicit.I is not None and metric.I is not None
    assert math.isclose(_mg_per_day(bare.I), _mg_per_day(explicit.I), rel_tol=1e-9)
    assert math.isclose(_mg_per_day(bare.I), _mg_per_day(metric.I), rel_tol=1e-4)


# --- User-defined Cv ------------------------------------------------------


def test_user_defined_inhalation() -> None:
    """Cm = Cv × MW / Vm × Ys."""
    out = user_defined_inhalation(
        UserDefinedInhalationInput(
            Cv=100.0,
            MW=100.0,
            Vm=24.45,
            Ys=0.5,
            b=1.25,
            h=8.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    Cm_expected = 100.0 * 100.0 / 24.45 * 0.5
    I_expected = Cm_expected * 1.25 * 8.0
    assert out.I is not None
    assert math.isclose(_mg_per_day(out.I), I_expected, rel_tol=1e-12)


# --- Dispatch coverage ----------------------------------------------------


def test_dispatch_registers_phase3b_models() -> None:
    expected = {
        18: uv_roll_coating,
        22: mass_balance,
        23: osha_pel_particulates,
        24: osha_total_pnor,
        40: auto_spray_polyiso,
        46: user_defined_inhalation,
        47: osha_respirable_pnor,
        49: auto_oem_spray,
        50: auto_refinish_spray,
    }
    for mid, fn in expected.items():
        assert get_exposure_model(mid) is fn, f"#{mid} → wrong dispatch"
    assert set(expected.keys()).issubset(EXPOSURE_MODELS.keys())
