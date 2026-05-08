"""EPA/OPPT Water Saturation Loss Model (#42).

Used when a chemical is dissolved in water at saturation (or near-
saturation) concentration and discharged with the wash/process water.
The release rate is the chemical's water solubility times the volume of
water generated.

Equation
--------
    DR (kg/site-day) = WSchem × CF × Amt / 1000
    DR occurs over [Freq] days/year
    AR (kg/year)     = DR × Freq × NS

Parameters
----------
    WSchem : g/L      — water solubility of the chemical
    CF     : -        — correction factor (default 1.0; user-tunable to
                          account for sub-saturation, partial mixing,
                          etc.)
    Amt    : kg/site-day — daily mass of water generated/discharged
    Freq, NS — standard.

Units note: ``WSchem × Amt`` has dimensions g·kg / (L·site·day). With
the implicit assumption that 1 L of water ≈ 1 kg, the product is
g²/(L·site·day) which collapses to g/(site·day) after canceling the kg/L
density. The factor of 1/1000 converts to kg/(site·day). This is how
EPA's reference equation is written; we replicate it as bare-float
arithmetic on the canonical-unit magnitudes.

Decompiled reference: ``decompilation/source/ChemSteer/RelModels.cs``
``RelWaterSat`` — uses ParmIDs 79 (CF), 80 (WSchem), 92 (Amt).
"""

from __future__ import annotations

from chemsteer.calc.base import (
    CalcInput,
    DaysPerYear,
    Dimensionless,
    GramsPerLiter,
    KgPerSiteDay,
    ReleaseOutput,
    Sites,
)
from chemsteer.calc.units import Q_


class WaterSaturationInput(CalcInput):
    """Inputs for EPA/OPPT Water Saturation Loss Model (#42)."""

    WSchem: GramsPerLiter
    """Water solubility of the chemical."""

    CF: Dimensionless
    """Correction factor (default 1.0)."""

    Amt: KgPerSiteDay
    """Daily mass of water generated per site."""

    Freq: DaysPerYear
    NS: Sites


def water_saturation(inp: WaterSaturationInput) -> ReleaseOutput:
    """ModelID 42 — EPA/OPPT Water Saturation Loss Model.

    DR (kg/site-day) = WSchem × CF × Amt / 1000.
    """
    WSchem_v = float(inp.WSchem.to("gram / liter").magnitude)
    CF_v = float(inp.CF.to("dimensionless").magnitude)
    Amt_v = float(inp.Amt.to("kilogram / (site * day)").magnitude)
    Freq_v = float(inp.Freq.to("day / year").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)

    DR_v = WSchem_v * CF_v * Amt_v / 1000.0
    AR_v = DR_v * Freq_v * NS_v

    return ReleaseOutput(
        DR=Q_(DR_v, "kilogram / (site * day)"),
        AR=Q_(AR_v, "kilogram / year"),
        NS=Q_(NS_v, "site"),
    )
