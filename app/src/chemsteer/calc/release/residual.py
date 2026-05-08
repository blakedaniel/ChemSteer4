"""Residual-loss release models.

ChemSTEER's six "residual" models all share the same arithmetic shape:

    DR (kg/site-day) = LF × Amt
    AR (kg/year)     = DR × Freq × NS

where ``LF`` is a model-specific default loss fraction (the fraction of
chemical that remains in the empty container after the bulk has been
transferred). Only the canonical default ``LF`` differs between the six.

| ModelID | Name                                                   | Default LF |
|---------|--------------------------------------------------------|------------|
| 1       | EPA/OPPT Bulk Transport Residual Model                 | 0.002      |
| 2       | EPA/OPPT Drum Residual Model                           | 0.025      |
| 3       | EPA/OPPT Multiple Process Vessel Residual Model        | 0.020      |
| 4       | EPA/OPPT Single Process Vessel Residual Model          | 0.010      |
| 5       | EPA/OPPT Small Container Residual Model                | 0.006      |
| 6       | EPA/OPPT Solid Residuals in Transport Containers Model | 0.010      |

Defaults sourced from EPA's Common Engineering Defaults document
(EPA 740/B-25-005, Table 1) and Barrett et al. 2023 Table 1.

Decompiled reference: ``decompilation/source/ChemSteer/RelModels.cs``
methods ``RelResidual``, ``RelKnown``.
"""

from __future__ import annotations

from chemsteer.calc.base import (
    CalcInput,
    DaysPerYear,
    Dimensionless,
    KgPerSiteDay,
    ReleaseOutput,
    Sites,
)


class ResidualInput(CalcInput):
    """Inputs to any of the six residual-loss release models.

    Equation
    --------
        DR (kg/site-day) = LF × Amt
        DR occurs over [Freq] days/year
        AR (kg/year)     = DR × Freq × NS
    """

    Amt: KgPerSiteDay
    """Daily amount of chemical-in-product handled per site."""

    LF: Dimensionless
    """Loss fraction (default depends on model — see module docstring)."""

    Freq: DaysPerYear
    """Frequency of release events per year per site."""

    NS: Sites
    """Number of sites where the release occurs."""


def _residual(inp: ResidualInput) -> ReleaseOutput:
    DR = inp.LF * inp.Amt
    AR = DR * inp.Freq * inp.NS
    return ReleaseOutput(DR=DR, AR=AR, NS=inp.NS)


# Each residual model is the same function with a different docstring;
# the loss-fraction default is supplied by the caller (or by the
# parameter-default lookup in Phase 4). We expose them as separate names
# so the dispatcher can map ModelID → function 1:1.


def bulk_transport_residual(inp: ResidualInput) -> ReleaseOutput:
    """ModelID 1 — EPA/OPPT Bulk Transport Residual Model.

    Equation: DR (kg/site-day) = LF × Amt; AR = DR × Freq × NS.
    Default LF: 0.002 (CEB Table 1; bulk tank trucks/rail cars).
    """
    return _residual(inp)


def drum_residual(inp: ResidualInput) -> ReleaseOutput:
    """ModelID 2 — EPA/OPPT Drum Residual Model.

    Equation: DR (kg/site-day) = LF × Amt; AR = DR × Freq × NS.
    Default LF: 0.025 (CEB Table 1; 55-gallon drums via pumping).
    """
    return _residual(inp)


def multiple_process_vessel_residual(inp: ResidualInput) -> ReleaseOutput:
    """ModelID 3 — EPA/OPPT Multiple Process Vessel Residual Model.

    Equation: DR (kg/site-day) = LF × Amt; AR = DR × Freq × NS.
    Default LF: 0.020 (CEB Table 1; multi-vessel cleaning).
    """
    return _residual(inp)


def single_process_vessel_residual(inp: ResidualInput) -> ReleaseOutput:
    """ModelID 4 — EPA/OPPT Single Process Vessel Residual Model.

    Equation: DR (kg/site-day) = LF × Amt; AR = DR × Freq × NS.
    Default LF: 0.010 (CEB Table 1; single vessel pumping).
    """
    return _residual(inp)


def small_container_residual(inp: ResidualInput) -> ReleaseOutput:
    """ModelID 5 — EPA/OPPT Small Container Residual Model.

    Equation: DR (kg/site-day) = LF × Amt; AR = DR × Freq × NS.
    Default LF: 0.006 (CEB Table 1; bottles, < 20-gal containers).
    """
    return _residual(inp)


def solid_transport_container_residual(inp: ResidualInput) -> ReleaseOutput:
    """ModelID 6 — EPA/OPPT Solid Residuals in Transport Containers Model.

    Equation: DR (kg/site-day) = LF × Amt; AR = DR × Freq × NS.
    Default LF: 0.010 (CEB Table 1; solids in any transport container).
    """
    return _residual(inp)
