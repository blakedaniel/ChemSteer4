"""Operation mass-balance solver vs frmMDUpdOpIP.CalcRest semantics."""

from __future__ import annotations

import math

import pytest

from chemsteer.calc.mass_balance import MassBalanceError, solve_mass_balance


def test_ns_and_od_known_derives_dmochem_and_dmoprod() -> None:
    # CalcRest branch 1 (line 6511): DMOchem = PV / NS / OD, exact (no
    # rounding — it's a rate, not a count); then DMOprod = DMOchem / Yprod.
    r = solve_mass_balance(500_000, NS=2, T=250, Yprod=0.5)
    assert math.isclose(r.DMOchem, 500_000 / 2 / 250)
    assert r.DMOprod is not None and math.isclose(r.DMOprod, 1000 / 0.5)
    assert set(r.derived) == {"DMOchem", "DMOprod"}
    assert r.warnings == []


def test_ns_and_od_known_overwrites_supplied_dmochem() -> None:
    # The original recomputes DMOchem whenever NS and OD are checked,
    # even if a value sits in the textbox.
    r = solve_mass_balance(500_000, NS=2, T=250, DMOchem=999.0)
    assert math.isclose(r.DMOchem, 1000.0)


def test_yprod_dmoprod_known_derives_od_with_my_round_it() -> None:
    # Branch 2 (line 6523-6532): DMOchem = Yprod·DMOprod, OD = PV/(NS·DMOchem)
    # rounded via MyRoundIt (round(x + 0.1), floor 1).
    r = solve_mass_balance(100_000, NS=1, Yprod=0.5, DMOprod=800)
    assert math.isclose(r.DMOchem, 400.0)
    assert r.T == 250.0  # exact 250 → round(250.1) = 250
    assert "OD" in r.derived


def test_derived_od_above_365_is_an_error() -> None:
    with pytest.raises(MassBalanceError, match="365"):
        solve_mass_balance(1_000_000, NS=1, Yprod=1.0, DMOprod=1000, mode="continuous")


def test_batch_mode_allows_t_above_365() -> None:
    r = solve_mass_balance(1_000_000, NS=1, Yprod=1.0, DMOprod=1000, mode="batch")
    assert r.T == 1000.0


def test_ns_rounding_my_round_it_vs_round_up() -> None:
    # exact NS = 2.0833…: MyRoundIt rounds to round(2.1833) = 2,
    # MassBalanceRoundUp ceilings to 3.
    kwargs = dict(T=240, DMOchem=1000.0)
    nearest = solve_mass_balance(500_000, **kwargs)  # type: ignore[arg-type]
    assert nearest.NS == 2.0
    ceil = solve_mass_balance(500_000, round_up_ns=True, **kwargs)  # type: ignore[arg-type]
    assert ceil.NS == 3.0


def test_rounding_discrepancy_warning_at_5_percent() -> None:
    # exact OD = PV/(NS·DMOchem) = 2.6 → round(2.7) = 3 → 15 % discrepancy.
    r = solve_mass_balance(2_600, NS=1, DMOchem=1000.0)
    assert r.T == 3.0
    assert len(r.warnings) == 1
    assert "15 percent" in r.warnings[0]
    assert "OD" in r.warnings[0]


def test_round_floor_is_one() -> None:
    # MyRoundIt never returns 0 — tiny exact values round up to 1.
    r = solve_mass_balance(100, NS=1, DMOchem=1000.0)
    assert r.T == 1.0


def test_derived_yprod_out_of_range_is_an_error() -> None:
    # DMOchem > DMOprod ⇒ Yprod > 1, invalid (line 6615).
    with pytest.raises(MassBalanceError, match="Yprod"):
        solve_mass_balance(250_000, NS=1, T=250, DMOprod=500)


def test_insufficient_knowns_raise() -> None:
    with pytest.raises(MassBalanceError):
        solve_mass_balance(100_000, NS=1)
    with pytest.raises(MassBalanceError):
        solve_mass_balance(100_000, Yprod=0.5, DMOprod=100)  # no NS/T


def test_yprod_above_one_rejected() -> None:
    with pytest.raises(MassBalanceError):
        solve_mass_balance(100_000, NS=1, T=10, Yprod=1.5)
