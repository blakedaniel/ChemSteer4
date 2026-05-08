"""EPA/OPPT Near-Field / Far-Field Inhalation Exposure Model (#54).

Two-zone box model for occupational exposure where the worker stands in
a small "near field" zone surrounded by a larger "far field" room. Vapor
generated near the worker partially mixes into the far field and decays
back via the room's air exchange rate.

Equations (verbatim from `ListOfModels.Equation`)
-------------------------------------------------
Near-field concentration (Cnf, mg/m³)::

    Cnf = ((G × 3600000 × (k1 × h
                           + k2 × EXP(λ1 × h) / λ1
                           − k3 × EXP(λ2 × h) / λ2))
          − (G × 3600000 × (k2 / λ1 − k3 / λ2))) / h

Far-field concentration (Cff, mg/m³)::

    Cff = ((G × 3600000 × (h / QFF
                           + k4 × EXP(λ1 × h) / λ1
                           − k5 × EXP(λ2 × h) / λ2))
          − (G × 3600000 × (k4 / λ1 − k5 / λ2))) / h

Constants and zone parameters::

    VNF      = LNF × WNF × HNF                       (near-field volume)
    FSA      = 2(LNF·HNF) + 2(WNF·HNF) + LNF·WNF     (free surface area)
    QNF      = 0.5 × FSA × velocityNF                (near-field flow)
    QFF      = VFF × AER                              (far-field flow)
    Y        = (QNF × VFF + VNF × (QNF + QFF)) / (VNF × VFF)
    Z        = 4 × QNF × QFF / (VNF × VFF)
    λ1       = 0.5 × (−Y + √(Y² − Z))
    λ2       = 0.5 × (−Y − √(Y² − Z))
    k1       = 1 / ((QNF / (QNF + QFF)) × QFF)
    k2       = (QNF·QFF + λ2·VNF·(QNF+QFF)) / (QNF·QFF·VNF·(λ1−λ2))
    k3       = (QNF·QFF + λ1·VNF·(QNF+QFF)) / (QNF·QFF·VNF·(λ1−λ2))
    k4       = ((λ1·VNF + QNF) / QNF) × k2
    k5       = ((λ2·VNF + QNF) / QNF) × k3

Then the standard rollup with whichever Cm the caller picks (typically
Cnf for the near-field worker)::

    I = Cm × b × h
    LADD/ADD/APDR/NW per the canonical formulas.

The 3,600,000 factor converts G from g/s to mg/hr (× 1000 for g→mg
× 3600 for s→hr); the / h at the end converts a time-integrated dose
back to an average concentration over the exposure period.

Decompiled reference: ``decompilation/source/ChemSteer/ExpModels.cs``
``ExpNearFarField``.
"""

from __future__ import annotations

import math

from chemsteer.calc.base import (
    CalcInput,
    CubicMeters,
    CubicMetersPerHour,
    DaysPerSiteYear,
    ExposureOutput,
    GramsPerSecond,
    HoursPerDay,
    Kilograms,
    Meters,
    MetersPerSecond,
    PerHour,
    Sites,
    WorkersPerSite,
    Years,
)
from chemsteer.calc.units import Q_


class NearFarFieldInput(CalcInput):
    """Inputs for ModelID 54 (Near-Field/Far-Field Inhalation)."""

    G: GramsPerSecond
    """Vapor generation rate."""

    LNF: Meters
    """Near-field length."""
    WNF: Meters
    """Near-field width."""
    HNF: Meters
    """Near-field height."""
    velocityNF: MetersPerSecond
    """Near-field cross-flow air velocity."""

    VFF: CubicMeters
    """Far-field volume."""
    AER: PerHour
    """Far-field air-exchange rate."""

    h: HoursPerDay
    """Exposure duration."""

    b: CubicMetersPerHour
    """Worker inhalation rate."""

    ED: DaysPerSiteYear
    Y: Years
    BW: Kilograms
    AT: Years
    ATc: Years
    NWexp: WorkersPerSite
    NS: Sites


def near_far_field(inp: NearFarFieldInput) -> ExposureOutput:
    """ModelID 54 — EPA/OPPT Near-Field/Far-Field Inhalation Model.

    Returns the near-field concentration scenario (worker in NF zone).
    """
    G_v = float(inp.G.to("gram / second").magnitude)
    LNF = float(inp.LNF.to("meter").magnitude)
    WNF = float(inp.WNF.to("meter").magnitude)
    HNF = float(inp.HNF.to("meter").magnitude)
    vel = float(inp.velocityNF.to("meter / second").magnitude)
    VFF = float(inp.VFF.to("meter ** 3").magnitude)
    AER = float(inp.AER.to("1 / hour").magnitude)
    h = float(inp.h.to("hour / day").magnitude)

    VNF = LNF * WNF * HNF
    FSA = 2.0 * (LNF * HNF) + 2.0 * (WNF * HNF) + (LNF * WNF)
    # vel is m/s; FSA is m²; multiplying gives m³/s — convert to m³/hr for
    # consistency with QFF and the 3.6M (g/s→mg/hr) constant in Cnf.
    QNF = 0.5 * FSA * vel * 3600.0  # m³/hr
    QFF = VFF * AER  # m³/hr (AER per hour × m³ volume)

    Y_const = (QNF * VFF + VNF * (QNF + QFF)) / (VNF * VFF)
    Z_const = 4.0 * QNF * QFF / (VNF * VFF)
    discriminant = max(Y_const**2 - Z_const, 0.0)
    sqrt_disc = math.sqrt(discriminant)
    lambda1 = 0.5 * (-Y_const + sqrt_disc)
    lambda2 = 0.5 * (-Y_const - sqrt_disc)

    # Guard: degenerate cases (lambda1 == lambda2) would divide by zero.
    if math.isclose(lambda1, lambda2, rel_tol=1e-12):
        raise ValueError("Near/Far-Field model: lambda1 == lambda2 (degenerate geometry)")

    k1 = 1.0 / ((QNF / (QNF + QFF)) * QFF)
    k2 = (QNF * QFF + lambda2 * VNF * (QNF + QFF)) / (QNF * QFF * VNF * (lambda1 - lambda2))
    k3 = (QNF * QFF + lambda1 * VNF * (QNF + QFF)) / (QNF * QFF * VNF * (lambda1 - lambda2))

    # The equation uses the literal "G × 3600000": with G in g/s, this
    # converts to mg over 1 hour (1000 mg/g × 3600 s/hr).
    g_const = G_v * 3_600_000.0

    Cnf = (
        (
            g_const
            * (k1 * h + k2 * math.exp(lambda1 * h) / lambda1 - k3 * math.exp(lambda2 * h) / lambda2)
        )
        - (g_const * (k2 / lambda1 - k3 / lambda2))
    ) / h

    # Roll up with Cnf as the worker's mass concentration
    Cm_mg_per_m3 = Cnf
    I_v = Cm_mg_per_m3 * float(inp.b.to("meter ** 3 / hour").magnitude) * h

    ED_v = float(inp.ED.to("day / (site * year)").magnitude)
    Y_y = float(inp.Y.to("year").magnitude)
    BW_v = float(inp.BW.to("kilogram").magnitude)
    AT_v = float(inp.AT.to("year").magnitude)
    ATc_v = float(inp.ATc.to("year").magnitude)
    NWexp_v = float(inp.NWexp.to("worker / site").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)

    return ExposureOutput(
        I=Q_(I_v, "milligram / day"),
        LADD=Q_(I_v * ED_v * Y_y / (BW_v * ATc_v * 365.0), "milligram / kilogram / day"),
        ADD=Q_(I_v * ED_v * Y_y / (BW_v * AT_v * 365.0), "milligram / kilogram / day"),
        APDR=Q_(I_v / BW_v, "milligram / kilogram / day"),
        NW=Q_(NWexp_v * NS_v, "worker"),
    )
