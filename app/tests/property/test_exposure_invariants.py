"""Hypothesis property-based tests for exposure-model invariants."""

from __future__ import annotations

import math

from hypothesis import assume, given, settings
from hypothesis import strategies as st

from chemsteer.calc.exposure.dermal import DermalInput, dermal_2hand_liquid
from chemsteer.calc.exposure.inhalation import (
    KCkInhalationInput,
    UserDefinedInhalationInput,
    user_defined_inhalation,
    uv_roll_coating,
)


def _mg_per_day(q: object) -> float:
    return float(q.to("milligram / day").magnitude)  # type: ignore[union-attr]


def _mg_per_kg_per_day(q: object) -> float:
    return float(q.to("milligram / kilogram / day").magnitude)  # type: ignore[union-attr]


def _workers(q: object) -> float:
    return float(q.to("worker").magnitude)  # type: ignore[union-attr]


# Plausible industrial ranges
_S = st.floats(min_value=100.0, max_value=2000.0)  # cm²/event
_Qu = st.floats(min_value=0.1, max_value=20.0)
_Wf = st.floats(min_value=0.0, max_value=1.0)
_FT = st.floats(min_value=1.0, max_value=10.0)
_ED = st.floats(min_value=1.0, max_value=365.0)
_Y = st.floats(min_value=1.0, max_value=70.0)
_BW = st.floats(min_value=40.0, max_value=120.0)
_AT = st.floats(min_value=1.0, max_value=70.0)
_ATc = st.floats(min_value=70.0, max_value=80.0)
_NWexp = st.floats(min_value=1.0, max_value=100.0)
_NS = st.floats(min_value=1.0, max_value=10_000.0)

_KCk = st.floats(min_value=0.001, max_value=100.0)  # mg/m³
_Ys = st.floats(min_value=0.0, max_value=1.0)
_b = st.floats(min_value=0.5, max_value=3.0)  # m³/hr
_h = st.floats(min_value=0.5, max_value=12.0)  # hr/day


# --- Dermal --------------------------------------------------------------


@given(_S, _Qu, _Wf, _FT, _ED, _Y, _BW, _AT, _ATc, _NWexp, _NS)
@settings(max_examples=50)
def test_dermal_Dexp_equals_S_Qu_Wf_FT(
    S: float,
    Qu: float,
    Wf: float,
    FT: float,
    ED: float,
    Y: float,
    BW: float,
    AT: float,
    ATc: float,
    NWexp: float,
    NS: float,
) -> None:
    """Dexp = S × Qu × Wf × FT for any dermal model."""
    out = dermal_2hand_liquid(
        DermalInput(
            S=S,
            Qu=Qu,
            Wf=Wf,
            FT=FT,
            ED=ED,
            Y=Y,
            BW=BW,
            AT=AT,
            ATc=ATc,
            NWexp=NWexp,
            NS=NS,
        )
    )
    expected = S * Qu * Wf * FT
    assert out.Dexp is not None
    assert math.isclose(_mg_per_day(out.Dexp), expected, rel_tol=1e-9)


@given(_S, _Qu, _Wf, _FT, _ED, _Y, _BW, _AT, _ATc, _NWexp, _NS)
@settings(max_examples=50)
def test_APDR_equals_Dexp_over_BW(
    S: float,
    Qu: float,
    Wf: float,
    FT: float,
    ED: float,
    Y: float,
    BW: float,
    AT: float,
    ATc: float,
    NWexp: float,
    NS: float,
) -> None:
    """APDR ≡ Dexp / BW exactly."""
    out = dermal_2hand_liquid(
        DermalInput(
            S=S,
            Qu=Qu,
            Wf=Wf,
            FT=FT,
            ED=ED,
            Y=Y,
            BW=BW,
            AT=AT,
            ATc=ATc,
            NWexp=NWexp,
            NS=NS,
        )
    )
    assert out.Dexp is not None
    Dexp = _mg_per_day(out.Dexp)
    APDR = _mg_per_kg_per_day(out.APDR)
    assert math.isclose(APDR, Dexp / BW, rel_tol=1e-9)


@given(_S, _Qu, _Wf, _FT, _ED, _Y, _BW, _AT, _ATc, _NWexp, _NS)
@settings(max_examples=50)
def test_LADD_le_ADD_when_ATc_ge_AT(
    S: float,
    Qu: float,
    Wf: float,
    FT: float,
    ED: float,
    Y: float,
    BW: float,
    AT: float,
    ATc: float,
    NWexp: float,
    NS: float,
) -> None:
    """ATc (lifetime) ≥ AT (working) ⇒ LADD ≤ ADD (longer averaging dilutes)."""
    assume(ATc >= AT)
    out = dermal_2hand_liquid(
        DermalInput(
            S=S,
            Qu=Qu,
            Wf=Wf,
            FT=FT,
            ED=ED,
            Y=Y,
            BW=BW,
            AT=AT,
            ATc=ATc,
            NWexp=NWexp,
            NS=NS,
        )
    )
    LADD = _mg_per_kg_per_day(out.LADD)
    ADD = _mg_per_kg_per_day(out.ADD)
    assert LADD <= ADD + 1e-12


@given(_S, _Qu, _Wf, _FT, _ED, _Y, _BW, _AT, _ATc, _NWexp, _NS)
@settings(max_examples=30)
def test_NW_equals_NWexp_times_NS(
    S: float,
    Qu: float,
    Wf: float,
    FT: float,
    ED: float,
    Y: float,
    BW: float,
    AT: float,
    ATc: float,
    NWexp: float,
    NS: float,
) -> None:
    out = dermal_2hand_liquid(
        DermalInput(
            S=S,
            Qu=Qu,
            Wf=Wf,
            FT=FT,
            ED=ED,
            Y=Y,
            BW=BW,
            AT=AT,
            ATc=ATc,
            NWexp=NWexp,
            NS=NS,
        )
    )
    assert math.isclose(_workers(out.NW), NWexp * NS, rel_tol=1e-9)


# --- Inhalation: KCk-based -----------------------------------------------


@given(_KCk, _Ys, _b, _h, _ED, _Y, _BW, _AT, _ATc, _NWexp, _NS)
@settings(max_examples=50)
def test_inhalation_I_equals_Cm_b_h(
    KCk: float,
    Ys: float,
    b: float,
    h: float,
    ED: float,
    Y: float,
    BW: float,
    AT: float,
    ATc: float,
    NWexp: float,
    NS: float,
) -> None:
    """I = Cm × b × h, with Cm = KCk × Ys for the simple family."""
    out = uv_roll_coating(
        KCkInhalationInput(
            KCk=KCk,
            Ys=Ys,
            b=b,
            h=h,
            ED=ED,
            Y=Y,
            BW=BW,
            AT=AT,
            ATc=ATc,
            NWexp=NWexp,
            NS=NS,
        )
    )
    expected_Cm = KCk * Ys
    expected_I = expected_Cm * b * h
    assert out.I is not None
    assert math.isclose(_mg_per_day(out.I), expected_I, rel_tol=1e-9)


# --- User-defined inhalation: regression prevention ----------------------


@given(
    st.floats(min_value=0.0, max_value=10000.0),  # Cv (ppm)
    st.floats(min_value=10.0, max_value=400.0),  # MW
    st.floats(min_value=20.0, max_value=30.0),  # Vm (~24.45)
    _Ys,
    _b,
    _h,
    _ED,
    _Y,
    _BW,
    _AT,
    _ATc,
    _NWexp,
    _NS,
)
@settings(max_examples=30)
def test_user_defined_inhalation_Cm_formula(
    Cv: float,
    MW: float,
    Vm: float,
    Ys: float,
    b: float,
    h: float,
    ED: float,
    Y: float,
    BW: float,
    AT: float,
    ATc: float,
    NWexp: float,
    NS: float,
) -> None:
    """Cm = Cv × MW / Vm × Ys for the user-defined inhalation model."""
    out = user_defined_inhalation(
        UserDefinedInhalationInput(
            Cv=Cv,
            MW=MW,
            Vm=Vm,
            Ys=Ys,
            b=b,
            h=h,
            ED=ED,
            Y=Y,
            BW=BW,
            AT=AT,
            ATc=ATc,
            NWexp=NWexp,
            NS=NS,
        )
    )
    expected_Cm = Cv * MW / Vm * Ys
    expected_I = expected_Cm * b * h
    assert out.I is not None
    assert math.isclose(_mg_per_day(out.I), expected_I, rel_tol=1e-9)
