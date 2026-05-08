"""EPA Small Volume Handling Inhalation Model (#21).

For low-throughput operations where the standard Mass Balance / KCk models
are inappropriate. The intake is computed directly from a tabulated
exposure factor.

Equation (verbatim from `ListOfModels.Equation`)
------------------------------------------------
    I    = EF × AH × Ys × Sd
    LADD = (I × ED × Y) / (BW × ATc × 365 days/yr)
    ADD  = (I × ED × Y) / (BW × AT  × 365 days/yr)
    APDR = I / BW
    NW   = NWexp × NS

Parameters
----------
    EF : mg/kg-handled — Exposure Factor (canonical 0.1 mg/kg per EPA)
    AH : kg/day        — Amount Handled per day
    Ys : –             — Weight fraction of chemical in product
    Sd : shifts/worker/day  — Number of shifts (typically 1)

Decompiled reference: ``decompilation/source/ChemSteer/ExpModels.cs``
``ExpSmallVolumeHandling``.
"""

from __future__ import annotations

from chemsteer.calc.base import (
    CalcInput,
    DaysPerSiteYear,
    Dimensionless,
    ExposureFactor,
    ExposureOutput,
    KgPerDay,
    Kilograms,
    Sites,
    WorkersPerSite,
    Years,
)
from chemsteer.calc.units import Q_


class SmallVolumeInput(CalcInput):
    """Inputs for ModelID 21 — EPA Small Volume Handling."""

    EF: ExposureFactor
    """Exposure factor (canonical 0.1 mg/kg-handled)."""

    AH: KgPerDay
    """Amount of material handled per day."""

    Ys: Dimensionless
    Sd: Dimensionless
    """Shifts per worker per day (typically 1; treated as dimensionless count)."""

    ED: DaysPerSiteYear
    Y: Years
    BW: Kilograms
    AT: Years
    ATc: Years
    NWexp: WorkersPerSite
    NS: Sites


def small_volume_handling(inp: SmallVolumeInput) -> ExposureOutput:
    """ModelID 21 — EPA Small Volume Handling Inhalation Model."""
    EF_v = float(inp.EF.to("milligram / kilogram").magnitude)
    AH_v = float(inp.AH.to("kilogram / day").magnitude)
    Ys_v = float(inp.Ys.to("dimensionless").magnitude)
    Sd_v = float(inp.Sd.to("dimensionless").magnitude)

    I_v = EF_v * AH_v * Ys_v * Sd_v  # mg/day

    ED_v = float(inp.ED.to("day / (site * year)").magnitude)
    Y_v = float(inp.Y.to("year").magnitude)
    BW_v = float(inp.BW.to("kilogram").magnitude)
    AT_v = float(inp.AT.to("year").magnitude)
    ATc_v = float(inp.ATc.to("year").magnitude)
    NWexp_v = float(inp.NWexp.to("worker / site").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)

    return ExposureOutput(
        I=Q_(I_v, "milligram / day"),
        LADD=Q_(I_v * ED_v * Y_v / (BW_v * ATc_v * 365.0), "milligram / kilogram / day"),
        ADD=Q_(I_v * ED_v * Y_v / (BW_v * AT_v * 365.0), "milligram / kilogram / day"),
        APDR=Q_(I_v / BW_v, "milligram / kilogram / day"),
        NW=Q_(NWexp_v * NS_v, "worker"),
    )
