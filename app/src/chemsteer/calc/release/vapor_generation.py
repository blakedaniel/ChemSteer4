"""Vapor-generation release models — outer DR/AR shell with three inner G expressions.

All three share::

    DR (kg/site-day) = (G [g/s] × 3600 × OHa) / 1000
    AR (kg/year)     = DR × Freq × NS

Differences are entirely in the inner ``G`` (vapor generation rate, g/s):

| ID | Model                                     | G expression |
|----|-------------------------------------------|--------------|
| 7  | EPA/OAQPS AP-42 Loading Model             | f × MW × (Vc × 3785.4) × r × X × (VP/760) / (3600 × T × R) |
| 8  | EPA/OPPT Mass Transfer Coefficient Model  | 1.93e-7 × MW^0.78 × X × VP × (1/29 + 1/MW)^0.33 × vz^0.78 × A / (T^0.4 × d^0.11 × (T^0.5 - 5.87)^(2/3)) |
| 9  | EPA/OPPT Penetration Model                | 8.24e-8 × MW^0.835 × X × VP × (1/29 + 1/MW)^0.25 × vz^0.5 × A / (T^0.05 × d^0.5 × P^0.5) |

The Mass Transfer model is for high-velocity air (≥ 100 ft/min ≈ 51 cm/s);
Penetration covers the low-velocity case (< 100 ft/min). The dispatcher
picks one based on ``vz`` in the model-selection layer (Phase 4).

Decompiled reference: ``decompilation/source/ChemSteer/RelModels.cs``
methods ``RelAp42``, ``RelMassTransfer``, ``RelPenetration``.
Equations cross-checked against ``mdb/ChmSteer/tables/ListOfModels.csv``
rows 7/8/9 and Barrett et al. 2023 Eqs 2/3/4.
"""

from __future__ import annotations

from chemsteer.calc.base import (
    Atm,
    CalcInput,
    Centimeter,
    CmPerSecond,
    ContainerPerHour,
    DaysPerYear,
    Dimensionless,
    GallonPerContainer,
    GasConstant,
    GramsPerMole,
    GramsPerSecond,
    HoursPerSiteDay,
    Kelvin,
    ReleaseOutput,
    Sites,
    SquareCentimeter,
    Torr,
)
from chemsteer.calc.units import Q_

# Standard universal-gas-constant default in ChemSTEER's atm·cm³/(mol·K).
DEFAULT_R_VALUE = 82.057


def _shell(
    G_g_per_s: float, OHa_h_per_site_day: float, Freq_d_per_y: float, NS_count: float
) -> ReleaseOutput:
    """Apply DR = (G × 3600 × OHa) / 1000 and AR = DR × Freq × NS."""
    DR_kg_per_site_day = (G_g_per_s * 3600.0 * OHa_h_per_site_day) / 1000.0
    AR_kg_per_year = DR_kg_per_site_day * Freq_d_per_y * NS_count
    return ReleaseOutput(
        DR=Q_(DR_kg_per_site_day, "kilogram / (site * day)"),
        AR=Q_(AR_kg_per_year, "kilogram / year"),
        NS=Q_(NS_count, "site"),
    )


# --- Model 7: AP-42 Loading -----------------------------------------------


class Ap42LoadingInput(CalcInput):
    """Inputs for EPA/OAQPS AP-42 Loading Model (#7).

    Equation
    --------
        G (g/s) = f × MW × (Vc × 3785.4) × r × X × (VP / 760)
                  / (3600 × T × R)
        DR (kg/site-day) = (G × 3600 × OHa) / 1000
        AR (kg/year)     = DR × Freq × NS
    """

    f: Dimensionless
    """Saturation factor (typical 1.0 for splash loading, 0.5 for submerged)."""

    MW: GramsPerMole
    """Molecular weight."""

    Vc: GallonPerContainer
    """Volume capacity per container."""

    r: ContainerPerHour
    """Container fill rate."""

    X: Dimensionless
    """Weight fraction of chemical in product."""

    VP: Torr
    """Vapor pressure."""

    T: Kelvin
    """Temperature."""

    R: GasConstant
    """Universal gas constant (defaults to 82.057 atm·cm³/(mol·K))."""

    OHa: HoursPerSiteDay
    """Activity duration per site per day."""

    Freq: DaysPerYear
    """Days per year activity occurs."""

    NS: Sites


def ap42_loading(inp: Ap42LoadingInput) -> ReleaseOutput:
    """ModelID 7 — EPA/OAQPS AP-42 Loading Model.

    G (g/s) = f × MW × (Vc × 3785.4) × r × X × (VP/760) / (3600 × T × R).
    Source: AP-42 Section 5.2 loading-loss equation, adapted by EPA/OPPT.
    """
    f_v = float(inp.f.to("dimensionless").magnitude)
    MW_v = float(inp.MW.to("gram / mole").magnitude)
    Vc_v = float(inp.Vc.to("gallon / container").magnitude)
    r_v = float(inp.r.to("container / hour").magnitude)
    X_v = float(inp.X.to("dimensionless").magnitude)
    VP_v = float(inp.VP.to("torr").magnitude)
    T_v = float(inp.T.to("kelvin").magnitude)
    R_v = float(inp.R.to("atm * centimeter ** 3 / mole / kelvin").magnitude)
    OHa_v = float(inp.OHa.to("hour / (site * day)").magnitude)
    Freq_v = float(inp.Freq.to("day / year").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)

    G = (f_v * MW_v * (Vc_v * 3785.4) * r_v * X_v * (VP_v / 760.0)) / (3600.0 * T_v * R_v)
    return _shell(G, OHa_v, Freq_v, NS_v)


# --- Model 8: Mass Transfer Coefficient (high-velocity air) ---------------


class MassTransferInput(CalcInput):
    """Inputs for EPA/OPPT Mass Transfer Coefficient Model (#8).

    Equation
    --------
        G (g/s) = 1.93e-7 × MW^0.78 × X × VP × (1/29 + 1/MW)^0.33
                  × vz^0.78 × A
                  / (T^0.4 × d^0.11 × (T^0.5 - 5.87)^(2/3))
        DR (kg/site-day) = (G × 3600 × OHa) / 1000
        AR (kg/year)     = DR × Freq × NS
    """

    MW: GramsPerMole
    X: Dimensionless
    VP: Torr
    vz: CmPerSecond
    """Air velocity over the open surface."""
    A: SquareCentimeter
    """Open surface area."""
    T: Kelvin
    d: Centimeter
    """Pool length (or diameter of opening)."""
    OHa: HoursPerSiteDay
    Freq: DaysPerYear
    NS: Sites


def mass_transfer_coefficient(inp: MassTransferInput) -> ReleaseOutput:
    """ModelID 8 — EPA/OPPT Mass Transfer Coefficient Model.

    Empirical correlation for vapor generation from an open liquid surface
    with high-velocity air (≥ 100 ft/min). See Barrett et al. 2023 Eq. 4.
    """
    MW_v = float(inp.MW.to("gram / mole").magnitude)
    X_v = float(inp.X.to("dimensionless").magnitude)
    VP_v = float(inp.VP.to("torr").magnitude)
    vz_v = float(inp.vz.to("centimeter / second").magnitude)
    A_v = float(inp.A.to("centimeter ** 2").magnitude)
    T_v = float(inp.T.to("kelvin").magnitude)
    d_v = float(inp.d.to("centimeter").magnitude)
    OHa_v = float(inp.OHa.to("hour / (site * day)").magnitude)
    Freq_v = float(inp.Freq.to("day / year").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)

    numerator = (
        1.93e-7 * MW_v**0.78 * X_v * VP_v * (1.0 / 29.0 + 1.0 / MW_v) ** 0.33 * vz_v**0.78 * A_v
    )
    denominator = T_v**0.4 * d_v**0.11 * (T_v**0.5 - 5.87) ** (2.0 / 3.0)
    G = numerator / denominator
    return _shell(G, OHa_v, Freq_v, NS_v)


# --- Model 9: Penetration (low-velocity air) ------------------------------


class PenetrationInput(CalcInput):
    """Inputs for EPA/OPPT Penetration Model (#9).

    Equation
    --------
        G (g/s) = 8.24e-8 × MW^0.835 × X × VP × (1/29 + 1/MW)^0.25
                  × vz^0.5 × A
                  / (T^0.05 × d^0.5 × P^0.5)
        DR (kg/site-day) = (G × 3600 × OHa) / 1000
        AR (kg/year)     = DR × Freq × NS
    """

    MW: GramsPerMole
    X: Dimensionless
    VP: Torr
    vz: CmPerSecond
    A: SquareCentimeter
    T: Kelvin
    d: Centimeter
    P: Atm
    """Atmospheric pressure."""
    OHa: HoursPerSiteDay
    Freq: DaysPerYear
    NS: Sites


class UserDefinedGInput(CalcInput):
    """Inputs for the User-Defined Vapor Generation Rate Model (#43).

    The user supplies G directly; the shell applies the standard outer
    DR / AR conversion::

        DR (kg/site-day) = (G × 3600 × OHa) / 1000
        AR (kg/year)     = DR × Freq × NS
    """

    G: GramsPerSecond
    """User-supplied vapor generation rate (g/s)."""

    OHa: HoursPerSiteDay
    Freq: DaysPerYear
    NS: Sites


def user_defined_vapor_generation(inp: UserDefinedGInput) -> ReleaseOutput:
    """ModelID 43 — User-Defined Vapor Generation Rate Model.

    Pass-through wrapper: the user supplies G directly; the shell
    converts to DR / AR. Used when none of the empirical models (#7–#9)
    is appropriate or when monitoring data give a measured G.
    """
    G_v = float(inp.G.to("gram / second").magnitude)
    OHa_v = float(inp.OHa.to("hour / (site * day)").magnitude)
    Freq_v = float(inp.Freq.to("day / year").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)
    return _shell(G_v, OHa_v, Freq_v, NS_v)


def penetration(inp: PenetrationInput) -> ReleaseOutput:
    """ModelID 9 — EPA/OPPT Penetration Model.

    Vapor generation from an open liquid surface with low-velocity air
    (< 100 ft/min). See Barrett et al. 2023 Eq. 3.
    """
    MW_v = float(inp.MW.to("gram / mole").magnitude)
    X_v = float(inp.X.to("dimensionless").magnitude)
    VP_v = float(inp.VP.to("torr").magnitude)
    vz_v = float(inp.vz.to("centimeter / second").magnitude)
    A_v = float(inp.A.to("centimeter ** 2").magnitude)
    T_v = float(inp.T.to("kelvin").magnitude)
    d_v = float(inp.d.to("centimeter").magnitude)
    P_v = float(inp.P.to("atm").magnitude)
    OHa_v = float(inp.OHa.to("hour / (site * day)").magnitude)
    Freq_v = float(inp.Freq.to("day / year").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)

    numerator = (
        8.24e-8 * MW_v**0.835 * X_v * VP_v * (1.0 / 29.0 + 1.0 / MW_v) ** 0.25 * vz_v**0.5 * A_v
    )
    denominator = T_v**0.05 * d_v**0.5 * P_v**0.5
    G = numerator / denominator
    return _shell(G, OHa_v, Freq_v, NS_v)
