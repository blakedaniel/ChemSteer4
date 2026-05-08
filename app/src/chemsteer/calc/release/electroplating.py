"""Electroplating release models (#51 #52).

Two related models for electroplating bath operations:

#51 — EPA/OPPT Electroplating Spent Bath Disposal Model
    DR (kg/site-day) = DVbath × 3.78 (L/gal) × Ybath × Dbath
        - DVbath: gallons of bath disposed per site-day
        - Ybath:  weight fraction of chemical in the bath
        - Dbath:  density of the bath, kg/L

#52 — EPA/OPPT Electroplating Rinse Water Loss Model
    DR (kg/site-day) = DVrinse × 3.78 × Yrinse × Drinse × (1 − RinseE)
        - DVrinse: gallons of rinse water generated per site-day
        - Yrinse:  weight fraction of chemical in rinse water
        - Drinse:  density of rinse water, kg/L
        - RinseE:  rinse-water recovery efficiency (default 0.9)

AR (kg/year) = DR × Freq × NS  for both.

Decompiled reference: ``decompilation/source/ChemSteer/RelModels.cs``
``RelSpentBath`` and ``RelRinseWater``.
"""

from __future__ import annotations

from chemsteer.calc.base import (
    CalcInput,
    DaysPerYear,
    Dimensionless,
    GallonsPerSiteDay,
    KgPerLiter,
    ReleaseOutput,
    Sites,
)
from chemsteer.calc.units import Q_

L_PER_GAL = 3.78  # ChemSTEER's canonical L/gal conversion (see equation strings).


# --- Model 51: Spent Bath Disposal ---------------------------------------


class SpentBathInput(CalcInput):
    """Inputs for EPA/OPPT Electroplating Spent Bath Disposal Model (#51)."""

    DVbath: GallonsPerSiteDay
    """Daily volume of bath disposed."""

    Ybath: Dimensionless
    """Weight fraction of the chemical in the bath."""

    Dbath: KgPerLiter
    """Density of the bath."""

    Freq: DaysPerYear
    NS: Sites


def spent_bath_disposal(inp: SpentBathInput) -> ReleaseOutput:
    """ModelID 51 — Electroplating Spent Bath Disposal.

    DR (kg/site-day) = DVbath × 3.78 × Ybath × Dbath.
    """
    DVbath_v = float(inp.DVbath.to("gallon / (site * day)").magnitude)
    Ybath_v = float(inp.Ybath.to("dimensionless").magnitude)
    Dbath_v = float(inp.Dbath.to("kilogram / liter").magnitude)
    Freq_v = float(inp.Freq.to("day / year").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)

    DR_v = DVbath_v * L_PER_GAL * Ybath_v * Dbath_v
    AR_v = DR_v * Freq_v * NS_v

    return ReleaseOutput(
        DR=Q_(DR_v, "kilogram / (site * day)"),
        AR=Q_(AR_v, "kilogram / year"),
        NS=Q_(NS_v, "site"),
    )


# --- Model 52: Rinse Water Loss ------------------------------------------


class RinseWaterInput(CalcInput):
    """Inputs for EPA/OPPT Electroplating Rinse Water Loss Model (#52)."""

    DVrinse: GallonsPerSiteDay
    """Daily volume of rinse water generated."""

    Yrinse: Dimensionless
    """Weight fraction of the chemical in the rinse water."""

    Drinse: KgPerLiter
    """Density of the rinse water."""

    RinseE: Dimensionless
    """Rinse water recovery efficiency (default 0.9)."""

    Freq: DaysPerYear
    NS: Sites


def rinse_water_loss(inp: RinseWaterInput) -> ReleaseOutput:
    """ModelID 52 — Electroplating Rinse Water Loss.

    DR (kg/site-day) = DVrinse × 3.78 × Yrinse × Drinse × (1 − RinseE).
    """
    DVrinse_v = float(inp.DVrinse.to("gallon / (site * day)").magnitude)
    Yrinse_v = float(inp.Yrinse.to("dimensionless").magnitude)
    Drinse_v = float(inp.Drinse.to("kilogram / liter").magnitude)
    RinseE_v = float(inp.RinseE.to("dimensionless").magnitude)
    Freq_v = float(inp.Freq.to("day / year").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)

    DR_v = DVrinse_v * L_PER_GAL * Yrinse_v * Drinse_v * (1.0 - RinseE_v)
    AR_v = DR_v * Freq_v * NS_v

    return ReleaseOutput(
        DR=Q_(DR_v, "kilogram / (site * day)"),
        AR=Q_(AR_v, "kilogram / year"),
        NS=Q_(NS_v, "site"),
    )
