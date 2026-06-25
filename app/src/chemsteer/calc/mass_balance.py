"""Operation-level mass-balance solver (frmMDUpdOpIP ``CalcRest``).

v3.2's "Update Operation Input Parameters" form relates five quantities
through two equations:

    DMOchem = Yprod × DMOprod                 (chemical in product)
    PV      = NS × T × DMOchem                (annual production volume)

where ``T`` is operating days OD (continuous mode) or total batches Nby
(batch mode). The user marks three of {NS, T, DMOchem, Yprod, DMOprod}
as known and the form derives the rest (``frmMDUpdOpIP.cs:6471-6623``):

- NS & T known    → DMOchem = PV/(NS·T), then the missing one of
                    Yprod/DMOprod from DMOchem.
- Yprod & DMOprod → DMOchem = Yprod·DMOprod, then T = PV/(NS·DMOchem)
                    or NS = PV/(T·DMOchem).
- DMOchem known   → the missing one of NS/T from PV, then the missing
                    one of Yprod/DMOprod.

Whole-count results round per the original:

- ``MyRoundIt`` (lines 7074-7122): ``round(x + 0.1)`` (half-to-even,
  matching .NET ``Math.Round``), floor of 1; if the rounded value
  differs from the exact one by ≥ 5 % a *mass-balance discrepancy*
  warning is raised (the original pops a MsgBox and stores the % in
  the MassBalDisc fields).
- ``MassBalanceRoundUp`` (lines 7034-7045): plain ceiling — used for
  NS when the electroplating flow forces a recount (``iReCalcNS``);
  exposed here as ``round_up_ns``.

Validation, also from the original: derived OD > 365 is an error
(line 6533); derived Yprod outside (0, 1] is an error (line 6615).
"""

from __future__ import annotations

import math
from dataclasses import dataclass, field
from typing import Literal

Mode = Literal["continuous", "batch"]


class MassBalanceError(ValueError):
    """Raised when the knowns are insufficient/contradictory or a derived
    value is invalid (OD > 365, Yprod out of range)."""


@dataclass
class MassBalanceResult:
    NS: float
    """Number of sites (ParmID 1)."""
    T: float
    """Operating days OD (ParmID 2) or batches Nby (ParmID 16) per mode."""
    DMOchem: float
    """Daily mass of chemical in product, kg/site-day (ParmID 13)."""
    Yprod: float | None
    """Weight fraction of chemical in product (ParmID 10)."""
    DMOprod: float | None
    """Daily mass of product, kg/site-day (ParmID 12)."""
    derived: list[str] = field(default_factory=list)
    """Field names this solve computed (vs. user-supplied)."""
    warnings: list[str] = field(default_factory=list)
    """v3.2 mass-balance discrepancy messages (rounding ≥ 5 %)."""


def _round_half_even(x: float) -> int:
    # .NET Math.Round and Python round() both round half to even.
    return round(x)


def _my_round_it(value: float, abbr: str, warnings: list[str]) -> int:
    """``MyRoundIt``: round(value + 0.1), floor 1, ≥5 % discrepancy warning."""
    rounded = _round_half_even(value + 0.1)
    if rounded == 0:
        rounded = 1
    if value > 0.0:
        pct = _round_half_even(abs(rounded / value - 1.0) * 100.0)
        if pct >= 5:
            warnings.append(
                f"A mass balance discrepancy of {pct} percent due to rounding of "
                f"{abbr} exists based on current parameter values and relational "
                f"equations. The calculated value was {value:.4g} and the value "
                f"after rounding was {rounded}."
            )
    return rounded


def _round_up(value: float) -> int:
    """``MassBalanceRoundUp``: ceiling (exact integers stay put)."""
    base = int(value)
    return base if float(base) == value else base + 1


def solve_mass_balance(
    pv_kg_yr: float,
    *,
    mode: Mode = "continuous",
    NS: float | None = None,
    T: float | None = None,
    DMOchem: float | None = None,
    Yprod: float | None = None,
    DMOprod: float | None = None,
    round_up_ns: bool = False,
) -> MassBalanceResult:
    """Solve the operation mass balance from the supplied knowns.

    ``T`` is OD (days/site-yr, continuous) or Nby (batches/site-yr,
    batch). Requires enough knowns to pin down NS, T and DMOchem —
    v3.2's three checkboxes; Yprod/DMOprod stay ``None`` when neither
    is given (the original then leaves both rows blank).
    """
    if pv_kg_yr <= 0:
        raise MassBalanceError("production volume must be positive")
    for name, v in (
        ("NS", NS),
        ("T", T),
        ("DMOchem", DMOchem),
        ("Yprod", Yprod),
        ("DMOprod", DMOprod),
    ):
        if v is not None and v <= 0:
            raise MassBalanceError(f"{name} must be positive when supplied")
    if Yprod is not None and Yprod > 1.0:
        raise MassBalanceError("Yprod must be in (0, 1]")

    derived: list[str] = []
    warnings: list[str] = []
    t_abbr = "OD" if mode == "continuous" else "Nby"

    if DMOchem is None and Yprod is not None and DMOprod is not None:
        DMOchem = Yprod * DMOprod
        derived.append("DMOchem")

    if NS is not None and T is not None:
        # CalcRest's first branch always recomputes DMOchem from PV when
        # NS and T are known (line 6511) — even a supplied value is
        # overwritten, exactly like the original form.
        if "DMOchem" in derived:
            derived.remove("DMOchem")
        DMOchem = pv_kg_yr / NS / T
        derived.append("DMOchem")
    elif DMOchem is not None:
        if NS is not None:
            T = float(_my_round_it(pv_kg_yr / NS / DMOchem, t_abbr, warnings))
            derived.append(t_abbr)
        elif T is not None:
            exact_ns = pv_kg_yr / T / DMOchem
            NS = float(
                _round_up(exact_ns) if round_up_ns else _my_round_it(exact_ns, "NS", warnings)
            )
            derived.append("NS")
        else:
            raise MassBalanceError(
                "need NS or OD/Nby as a third known (only DMOchem-side values given)"
            )
    else:
        raise MassBalanceError(
            "insufficient knowns: supply NS+T, or DMOchem (directly or as "
            "Yprod×DMOprod) plus one of NS/T"
        )

    assert NS is not None and T is not None and DMOchem is not None

    if mode == "continuous" and T > 365.0:
        raise MassBalanceError(
            f"derived Operating Days ({T:g}) is greater than 365, which is invalid"
        )

    if Yprod is not None and DMOprod is None:
        DMOprod = DMOchem / Yprod
        derived.append("DMOprod")
    elif DMOprod is not None and ("DMOchem" in derived or Yprod is None):
        derived_yprod = DMOchem / DMOprod
        if Yprod is None:
            Yprod = derived_yprod
            derived.append("Yprod")
            if not (0.0 < Yprod <= 1.0) or not math.isfinite(Yprod):
                raise MassBalanceError(
                    f"derived Yprod ({Yprod:.4g}) must be greater than zero and "
                    "less than or equal to one"
                )

    return MassBalanceResult(
        NS=NS,
        T=T,
        DMOchem=DMOchem,
        Yprod=Yprod,
        DMOprod=DMOprod,
        derived=derived,
        warnings=warnings,
    )
