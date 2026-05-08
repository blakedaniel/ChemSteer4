"""Inhalation exposure models — 12 total across three structural families.

Family A: KCk-based (concentration-from-constant)
-------------------------------------------------
All seven of these compute ``Cm`` from a model-specific particulate-mass
constant (``KCk``) optionally scaled by chemical weight fraction
(``Ys``) or PEL adjustment (``Ypel``):

| ID | Model                                                | Cm formula        |
|----|------------------------------------------------------|-------------------|
| 18 | UV Roll Coating Inhalation                           | KCk × Ys          |
| 23 | OSHA PEL-Limiting (Particulates)                     | KCk × Ys / Ypel   |
| 24 | OSHA Total PNOR PEL-Limiting                         | KCk × Ys          |
| 40 | Auto Spray Coating (polyisocyanates)                 | KCk               |
| 47 | OSHA Respirable PNOR PEL-Limiting                    | KCk × Ys          |
| 49 | Auto OEM Spray (non-volatile non-polyisocyanates)    | KCk × Ys          |
| 50 | Auto Refinish Spray (non-volatiles)                  | KCk × Ys          |

Family B: Concentration-from-vapor (Mass Balance + user-defined)
----------------------------------------------------------------
Both build on ``Cv``-based concentration with explicit MW conversion:

| ID | Model                          | Cv formula                              |
|----|--------------------------------|-----------------------------------------|
| 22 | EPA/OPPT Mass Balance Model    | min((170000·T·G)/(MW·Q·k), 1e6·X·VP/760)|
| 46 | User-defined Inhalation        | user-supplied Cv (× Ys factor)          |

Family C: Special-shape models (Small Volume, OSHA Vapor PEL, NF/FF)
--------------------------------------------------------------------
These have unique structural shapes ported in subsequent commits:

| ID | Model                                                         |
|----|---------------------------------------------------------------|
| 21 | EPA Small Volume Handling — I = EF × AH × Ys × Sd             |
| 45 | OSHA PEL-Limiting (Vapor) — Cv = lesser of two vapor formulas |
| 54 | Near-Field/Far-Field — exponential-decay zone model           |

Decompiled reference: ``decompilation/source/ChemSteer/ExpModels.cs``
methods ``ExpOSHAPELLimiting``, ``ExpRollCoating``, ``ExpAuto``,
``ExpAutoPoly``, ``ExpMassBalance``, etc.
"""

from __future__ import annotations

from chemsteer.calc.base import (
    CalcInput,
    CubicMetersPerHour,
    DaysPerSiteYear,
    Dimensionless,
    ExposureOutput,
    GramsPerMole,
    GramsPerSecond,
    HoursPerDay,
    Kelvin,
    Kilograms,
    LitersPerMole,
    MgPerCubicMeter,
    Ppm,
    Sites,
    Torr,
    WorkersPerSite,
    Years,
)
from chemsteer.calc.units import Q_

# --- Common derivation: I = Cm × b × h, then dose rollups ---------------


def _from_Cm(
    Cm_mg_per_m3: float,
    *,
    b_m3_per_hr: float,
    h_hr_per_day: float,
    ED_d_per_site_y: float,
    Y_y: float,
    BW_kg: float,
    AT_y: float,
    ATc_y: float,
    NWexp_per_site: float,
    NS_count: float,
) -> ExposureOutput:
    """Apply the standard inhalation rollup once Cm is known.

    I (mg/day) = Cm × b × h  (units: mg/m³ × m³/hr × hr/day → mg/day)
    LADD/ADD/APDR/NW per the canonical formulas.
    """
    I_mg_per_day = Cm_mg_per_m3 * b_m3_per_hr * h_hr_per_day
    LADD = (I_mg_per_day * ED_d_per_site_y * Y_y) / (BW_kg * ATc_y * 365.0)
    ADD = (I_mg_per_day * ED_d_per_site_y * Y_y) / (BW_kg * AT_y * 365.0)
    APDR = I_mg_per_day / BW_kg
    NW = NWexp_per_site * NS_count
    return ExposureOutput(
        I=Q_(I_mg_per_day, "milligram / day"),
        LADD=Q_(LADD, "milligram / kilogram / day"),
        ADD=Q_(ADD, "milligram / kilogram / day"),
        APDR=Q_(APDR, "milligram / kilogram / day"),
        NW=Q_(NW, "worker"),
    )


# =========================================================================
# Family A: KCk-based
# =========================================================================


class KCkInhalationInput(CalcInput):
    """Inputs for the KCk × Ys inhalation models (#18 #24 #47 #49 #50)."""

    KCk: MgPerCubicMeter
    """Mass concentration of total/respirable particulate in air."""

    Ys: Dimensionless
    """Weight fraction of chemical in particulate / solids of mist / mixture."""

    b: CubicMetersPerHour
    """Worker inhalation rate (default 1.25 m³/hr light work)."""

    h: HoursPerDay
    """Exposure duration."""

    ED: DaysPerSiteYear
    Y: Years
    BW: Kilograms
    AT: Years
    ATc: Years
    NWexp: WorkersPerSite
    NS: Sites


def _kck_ys(inp: KCkInhalationInput) -> ExposureOutput:
    KCk_v = float(inp.KCk.to("milligram / meter ** 3").magnitude)
    Ys_v = float(inp.Ys.to("dimensionless").magnitude)
    Cm = KCk_v * Ys_v
    return _from_Cm(
        Cm,
        b_m3_per_hr=float(inp.b.to("meter ** 3 / hour").magnitude),
        h_hr_per_day=float(inp.h.to("hour / day").magnitude),
        ED_d_per_site_y=float(inp.ED.to("day / (site * year)").magnitude),
        Y_y=float(inp.Y.to("year").magnitude),
        BW_kg=float(inp.BW.to("kilogram").magnitude),
        AT_y=float(inp.AT.to("year").magnitude),
        ATc_y=float(inp.ATc.to("year").magnitude),
        NWexp_per_site=float(inp.NWexp.to("worker / site").magnitude),
        NS_count=float(inp.NS.to("site").magnitude),
    )


def uv_roll_coating(inp: KCkInhalationInput) -> ExposureOutput:
    """ModelID 18 — UV Roll Coating Inhalation Model.

    Cm = KCk × Ys; I = Cm × b × h.
    """
    return _kck_ys(inp)


def osha_total_pnor(inp: KCkInhalationInput) -> ExposureOutput:
    """ModelID 24 — OSHA Total PNOR PEL-Limiting Model.

    Cm = KCk × Ys; KCk default 15 mg/m³ (OSHA total dust PEL).
    """
    return _kck_ys(inp)


def osha_respirable_pnor(inp: KCkInhalationInput) -> ExposureOutput:
    """ModelID 47 — OSHA Respirable PNOR PEL-Limiting Model.

    Cm = KCk × Ys; KCk default 5 mg/m³ (OSHA respirable PNOR PEL).
    """
    return _kck_ys(inp)


def auto_oem_spray(inp: KCkInhalationInput) -> ExposureOutput:
    """ModelID 49 — Auto OEM Spray Coating Inhalation (non-volatile non-poly).

    Cm = KCk × Ys; KCk default per Auto OEM ESD.
    """
    return _kck_ys(inp)


def auto_refinish_spray(inp: KCkInhalationInput) -> ExposureOutput:
    """ModelID 50 — Auto Refinish Spray Coating Inhalation (non-volatiles).

    Cm = KCk × Ys; KCk default per Auto Refinish ESD.
    """
    return _kck_ys(inp)


class KCkOnlyInput(CalcInput):
    """Inputs for ModelID 40 (KCk-only — no Ys factor)."""

    KCk: MgPerCubicMeter
    b: CubicMetersPerHour
    h: HoursPerDay
    ED: DaysPerSiteYear
    Y: Years
    BW: Kilograms
    AT: Years
    ATc: Years
    NWexp: WorkersPerSite
    NS: Sites


def auto_spray_polyiso(inp: KCkOnlyInput) -> ExposureOutput:
    """ModelID 40 — Auto Spray Coating Inhalation (polyisocyanates).

    Cm = KCk (no Ys multiplication — KCk is already the chemical-specific
    concentration in the polyiso ESD).
    """
    KCk_v = float(inp.KCk.to("milligram / meter ** 3").magnitude)
    return _from_Cm(
        KCk_v,
        b_m3_per_hr=float(inp.b.to("meter ** 3 / hour").magnitude),
        h_hr_per_day=float(inp.h.to("hour / day").magnitude),
        ED_d_per_site_y=float(inp.ED.to("day / (site * year)").magnitude),
        Y_y=float(inp.Y.to("year").magnitude),
        BW_kg=float(inp.BW.to("kilogram").magnitude),
        AT_y=float(inp.AT.to("year").magnitude),
        ATc_y=float(inp.ATc.to("year").magnitude),
        NWexp_per_site=float(inp.NWexp.to("worker / site").magnitude),
        NS_count=float(inp.NS.to("site").magnitude),
    )


class OshaPelParticulatesInput(CalcInput):
    """Inputs for ModelID 23 (KCk × Ys / Ypel)."""

    KCk: MgPerCubicMeter
    Ys: Dimensionless
    Ypel: Dimensionless
    """Weight fraction of the PEL-bearing chemical in the mixture."""
    b: CubicMetersPerHour
    h: HoursPerDay
    ED: DaysPerSiteYear
    Y: Years
    BW: Kilograms
    AT: Years
    ATc: Years
    NWexp: WorkersPerSite
    NS: Sites


def osha_pel_particulates(inp: OshaPelParticulatesInput) -> ExposureOutput:
    """ModelID 23 — OSHA PEL-Limiting (Substance-specific Particulates).

    Cm = KCk × Ys / Ypel; substance-specific PEL adjustment.
    """
    KCk_v = float(inp.KCk.to("milligram / meter ** 3").magnitude)
    Ys_v = float(inp.Ys.to("dimensionless").magnitude)
    Ypel_v = float(inp.Ypel.to("dimensionless").magnitude)
    Cm = KCk_v * Ys_v / Ypel_v
    return _from_Cm(
        Cm,
        b_m3_per_hr=float(inp.b.to("meter ** 3 / hour").magnitude),
        h_hr_per_day=float(inp.h.to("hour / day").magnitude),
        ED_d_per_site_y=float(inp.ED.to("day / (site * year)").magnitude),
        Y_y=float(inp.Y.to("year").magnitude),
        BW_kg=float(inp.BW.to("kilogram").magnitude),
        AT_y=float(inp.AT.to("year").magnitude),
        ATc_y=float(inp.ATc.to("year").magnitude),
        NWexp_per_site=float(inp.NWexp.to("worker / site").magnitude),
        NS_count=float(inp.NS.to("site").magnitude),
    )


# =========================================================================
# Family B: Mass Balance / user-defined Cv
# =========================================================================


class MassBalanceInput(CalcInput):
    """Inputs for ModelID 22 (EPA/OPPT Mass Balance Model).

    Cv = lesser of (170000 × T × G) / (MW × Q × k) or 1,000,000 × X × VP / 760
    Cm = Cv × MW / Vm
    I  = Cm × b × h

    The min() over the two Cv expressions caps concentration at saturation.
    Note: the constant 170,000 already embeds unit conversions; we treat
    each value as a bare float once coerced to its canonical unit.
    """

    G: GramsPerSecond
    """Vapor generation rate (g/s) from the release calc."""

    MW: GramsPerMole
    T: Kelvin
    Q: CubicMetersPerHour
    """Ventilation rate (Pint accepts ft³/min and converts)."""

    k: Dimensionless
    """Mixing factor."""

    X: Dimensionless
    """Weight fraction of chemical in product."""

    VP: Torr

    Vm: LitersPerMole
    """Molar volume at T (default 24.45 L/mol at 25°C, 1 atm)."""

    b: CubicMetersPerHour
    h: HoursPerDay
    ED: DaysPerSiteYear
    Y: Years
    BW: Kilograms
    AT: Years
    ATc: Years
    NWexp: WorkersPerSite
    NS: Sites


def mass_balance(inp: MassBalanceInput) -> ExposureOutput:
    """ModelID 22 — EPA/OPPT Mass Balance Model.

    The classic EPA/OPPT box-model derivation: Cv is min of generation-
    limited and saturation-limited concentrations; Cm = Cv × MW / Vm
    converts to mass concentration; I = Cm × b × h yields daily intake.
    """
    G_v = float(inp.G.to("gram / second").magnitude)
    MW_v = float(inp.MW.to("gram / mole").magnitude)
    T_v = float(inp.T.to("kelvin").magnitude)
    Q_v = float(inp.Q.to("meter ** 3 / hour").magnitude)
    k_v = float(inp.k.to("dimensionless").magnitude)
    X_v = float(inp.X.to("dimensionless").magnitude)
    VP_v = float(inp.VP.to("torr").magnitude)
    Vm_v = float(inp.Vm.to("liter / mole").magnitude)

    # Cv1: vapor-generation-limited (ppm)
    Cv1 = (170000.0 * T_v * G_v) / (MW_v * Q_v * k_v)
    # Cv2: saturation-limited (ppm)
    Cv2 = 1_000_000.0 * X_v * VP_v / 760.0
    Cv = min(Cv1, Cv2)
    # Cm (mg/m³) = Cv (ppm) × MW / Vm
    Cm = Cv * MW_v / Vm_v

    return _from_Cm(
        Cm,
        b_m3_per_hr=float(inp.b.to("meter ** 3 / hour").magnitude),
        h_hr_per_day=float(inp.h.to("hour / day").magnitude),
        ED_d_per_site_y=float(inp.ED.to("day / (site * year)").magnitude),
        Y_y=float(inp.Y.to("year").magnitude),
        BW_kg=float(inp.BW.to("kilogram").magnitude),
        AT_y=float(inp.AT.to("year").magnitude),
        ATc_y=float(inp.ATc.to("year").magnitude),
        NWexp_per_site=float(inp.NWexp.to("worker / site").magnitude),
        NS_count=float(inp.NS.to("site").magnitude),
    )


class UserDefinedInhalationInput(CalcInput):
    """Inputs for ModelID 46 (user-defined inhalation; user supplies Cv)."""

    Cv: Ppm
    """User-supplied volume concentration of chemical in air (ppm; treated as a dimensionless ratio)."""

    MW: GramsPerMole
    Vm: LitersPerMole
    """Molar volume (default 24.45 L/mol)."""

    Ys: Dimensionless
    """Weight fraction adjustment (default 1.0)."""

    b: CubicMetersPerHour
    h: HoursPerDay
    ED: DaysPerSiteYear
    Y: Years
    BW: Kilograms
    AT: Years
    ATc: Years
    NWexp: WorkersPerSite
    NS: Sites


def user_defined_inhalation(inp: UserDefinedInhalationInput) -> ExposureOutput:
    """ModelID 46 — User-defined Inhalation Model.

    Cm = Cv × MW / Vm × Ys; user supplies Cv directly.
    """
    Cv_v = float(inp.Cv.to("dimensionless").magnitude)
    MW_v = float(inp.MW.to("gram / mole").magnitude)
    Vm_v = float(inp.Vm.to("liter / mole").magnitude)
    Ys_v = float(inp.Ys.to("dimensionless").magnitude)
    Cm = Cv_v * MW_v / Vm_v * Ys_v
    return _from_Cm(
        Cm,
        b_m3_per_hr=float(inp.b.to("meter ** 3 / hour").magnitude),
        h_hr_per_day=float(inp.h.to("hour / day").magnitude),
        ED_d_per_site_y=float(inp.ED.to("day / (site * year)").magnitude),
        Y_y=float(inp.Y.to("year").magnitude),
        BW_kg=float(inp.BW.to("kilogram").magnitude),
        AT_y=float(inp.AT.to("year").magnitude),
        ATc_y=float(inp.ATc.to("year").magnitude),
        NWexp_per_site=float(inp.NWexp.to("worker / site").magnitude),
        NS_count=float(inp.NS.to("site").magnitude),
    )
