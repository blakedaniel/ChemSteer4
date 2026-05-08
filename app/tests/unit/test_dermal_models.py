"""Unit tests for the six dermal exposure models (#25-29, #44)."""

from __future__ import annotations

import math

import pytest

from chemsteer.calc.dispatch import EXPOSURE_MODELS, get_exposure_model
from chemsteer.calc.exposure.dermal import (
    DermalInput,
    dermal_1hand_liquid,
    dermal_2hand_container_solids,
    dermal_2hand_immersion,
    dermal_2hand_liquid,
    dermal_2hand_solids,
    user_defined_dermal,
)


def _mg_per_day(q: object) -> float:
    return float(q.to("milligram / day").magnitude)  # type: ignore[union-attr]


def _mg_per_kg_per_day(q: object) -> float:
    return float(q.to("milligram / kilogram / day").magnitude)  # type: ignore[union-attr]


def _workers(q: object) -> float:
    return float(q.to("worker").magnitude)  # type: ignore[union-attr]


def test_dermal_2hand_liquid_user_guide_example() -> None:
    """2-Hand contact w/ liquid using EPA defaults from CEB Table 2.

    With S=1070 cm²/event, Qu=2.1 mg/cm²/event, Wf=0.5, FT=1 event/day:
      Dexp = 1070 × 2.1 × 0.5 × 1 = 1123.5 mg/day
    With BW=80 kg, ED=250 d/site/y, Y=40 y, AT=40 y, ATc=78 y:
      ADD  = 1123.5 × 250 × 40 / (80 × 40 × 365)  = 9.6189...
      LADD = 1123.5 × 250 × 40 / (80 × 78 × 365)  = 4.9328...
      APDR = 1123.5 / 80 = 14.04375
    """
    out = dermal_2hand_liquid(
        DermalInput(
            S=1070.0,
            Qu=2.1,
            Wf=0.5,
            FT=1.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=10.0,
            NS=3.0,
        )
    )

    Dexp = 1070.0 * 2.1 * 0.5 * 1.0
    ADD = Dexp * 250.0 * 40.0 / (80.0 * 40.0 * 365.0)
    LADD = Dexp * 250.0 * 40.0 / (80.0 * 78.0 * 365.0)
    APDR = Dexp / 80.0
    NW = 10.0 * 3.0

    assert out.Dexp is not None
    assert math.isclose(_mg_per_day(out.Dexp), Dexp, rel_tol=1e-12)
    assert math.isclose(_mg_per_kg_per_day(out.ADD), ADD, rel_tol=1e-12)
    assert math.isclose(_mg_per_kg_per_day(out.LADD), LADD, rel_tol=1e-12)
    assert math.isclose(_mg_per_kg_per_day(out.APDR), APDR, rel_tol=1e-12)
    assert math.isclose(_workers(out.NW), NW)


@pytest.mark.parametrize(
    "fn",
    [
        dermal_1hand_liquid,
        dermal_2hand_liquid,
        dermal_2hand_immersion,
        dermal_2hand_solids,
        dermal_2hand_container_solids,
        user_defined_dermal,
    ],
)
def test_all_dermal_models_share_arithmetic(fn) -> None:  # type: ignore[no-untyped-def]
    """Same Dexp = S×Qu×Wf×FT regardless of which named function is called."""
    inp = DermalInput(
        S=1000.0,
        Qu=2.0,
        Wf=0.5,
        FT=1.0,
        ED=200.0,
        Y=20.0,
        BW=70.0,
        AT=20.0,
        ATc=78.0,
        NWexp=5.0,
        NS=2.0,
    )
    out = fn(inp)
    assert out.Dexp is not None
    # Dexp = 1000 × 2 × 0.5 × 1 = 1000 mg/day
    assert math.isclose(_mg_per_day(out.Dexp), 1000.0, rel_tol=1e-12)


def test_zero_weight_fraction_yields_zero_exposure() -> None:
    out = dermal_1hand_liquid(
        DermalInput(
            S=535.0,
            Qu=2.1,
            Wf=0.0,
            FT=1.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    assert out.Dexp is not None
    assert _mg_per_day(out.Dexp) == 0.0
    assert _mg_per_kg_per_day(out.ADD) == 0.0


def test_dispatch_registers_all_dermal_models() -> None:
    assert get_exposure_model(25) is dermal_1hand_liquid
    assert get_exposure_model(26) is dermal_2hand_liquid
    assert get_exposure_model(27) is dermal_2hand_immersion
    assert get_exposure_model(28) is dermal_2hand_solids
    assert get_exposure_model(29) is dermal_2hand_container_solids
    assert get_exposure_model(44) is user_defined_dermal
    assert {25, 26, 27, 28, 29, 44}.issubset(EXPOSURE_MODELS.keys())
