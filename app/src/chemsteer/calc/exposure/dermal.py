"""Dermal exposure models (#25 #26 #27 #28 #29 #44).

All six dermal models share identical arithmetic; only the canonical
defaults for ``S`` (skin surface area) and ``Qu`` (quantity per contact)
differ. The dispatcher and the per-scenario parameter-default lookup
supply the right values; this module is the math.

Equation (verbatim from `ListOfModels.Equation`)
------------------------------------------------
    Dexp = S × Qu × Wf × FT
    LADD = (Dexp × ED × Y) / (BW × ATc × 365 days/yr)
    ADD  = (Dexp × ED × Y) / (BW × AT  × 365 days/yr)
    APDR = Dexp / BW
    NW   = NWexp × NS

| ID | Model                                              | Default S (cm²) | Default Qu (mg/cm²/event) |
|----|----------------------------------------------------|----------------:|--------------------------:|
| 25 | EPA/OPPT 1-Hand Dermal Contact with Liquids        |             535 |                       2.1 |
| 26 | EPA/OPPT 2-Hand Dermal Contact with Liquid         |            1070 |                       2.1 |
| 27 | EPA/OPPT 2-Hand Dermal Immersion in Liquid         |            1070 |                10.3 (high)|
| 28 | EPA/OPPT Direct 2-Hand Dermal Contact with Solids  |            1070 |                       3.1 |
| 29 | EPA/OPPT 2-Hand Dermal Contact with Container...   |            1070 |                       1.0 |
| 44 | User-defined Dermal Model                          |               – |                         – |

Defaults from the EPA Common Engineering Defaults document
(EPA 740/B-25-005, Table 2).

Decompiled reference: ``decompilation/source/ChemSteer/ExpModels.cs``
``ExpDerLiquidModel``, ``ExpDerSolidModel``, ``ExpUserDerLiquidModel``.
"""

from __future__ import annotations

from chemsteer.calc.base import (
    CalcInput,
    DaysPerSiteYear,
    Dimensionless,
    EventsPerDay,
    ExposureOutput,
    Kilograms,
    MgPerCmSquaredEvent,
    Sites,
    SquareCmPerEvent,
    WorkersPerSite,
    Years,
)
from chemsteer.calc.units import Q_


class DermalInput(CalcInput):
    """Inputs to any of the six dermal-contact exposure models."""

    S: SquareCmPerEvent
    """Skin surface area contacted per event."""

    Qu: MgPerCmSquaredEvent
    """Quantity of liquid/solid that adheres per cm² per event."""

    Wf: Dimensionless
    """Weight fraction of the chemical in the contacted material."""

    FT: EventsPerDay
    """Frequency of contact events per day."""

    ED: DaysPerSiteYear
    """Exposure days per site per year."""

    Y: Years
    """Years of exposure."""

    BW: Kilograms
    """Body weight (default 80 kg per ChemSTEER User Guide)."""

    AT: Years
    """Averaging time (non-cancer)."""

    ATc: Years
    """Averaging time (cancer; typically 78 years)."""

    NWexp: WorkersPerSite
    """Workers exposed per site."""

    NS: Sites


def _dermal(inp: DermalInput) -> ExposureOutput:
    S_v = float(inp.S.to("centimeter ** 2 / event").magnitude)
    Qu_v = float(inp.Qu.to("milligram / centimeter ** 2 / event").magnitude)
    Wf_v = float(inp.Wf.to("dimensionless").magnitude)
    FT_v = float(inp.FT.to("event / day").magnitude)
    ED_v = float(inp.ED.to("day / (site * year)").magnitude)
    Y_v = float(inp.Y.to("year").magnitude)
    BW_v = float(inp.BW.to("kilogram").magnitude)
    AT_v = float(inp.AT.to("year").magnitude)
    ATc_v = float(inp.ATc.to("year").magnitude)
    NWexp_v = float(inp.NWexp.to("worker / site").magnitude)
    NS_v = float(inp.NS.to("site").magnitude)

    Dexp_v = S_v * Qu_v * Wf_v * FT_v  # mg/day
    LADD_v = (Dexp_v * ED_v * Y_v) / (BW_v * ATc_v * 365.0)
    ADD_v = (Dexp_v * ED_v * Y_v) / (BW_v * AT_v * 365.0)
    APDR_v = Dexp_v / BW_v
    NW_v = NWexp_v * NS_v

    return ExposureOutput(
        Dexp=Q_(Dexp_v, "milligram / day"),
        LADD=Q_(LADD_v, "milligram / kilogram / day"),
        ADD=Q_(ADD_v, "milligram / kilogram / day"),
        APDR=Q_(APDR_v, "milligram / kilogram / day"),
        NW=Q_(NW_v, "worker"),
    )


# Each named function is the same math; surfaced separately so the
# dispatcher and the API can map ModelID 1:1 to a callable. The
# canonical defaults (S, Qu) are documented per-function.


def dermal_1hand_liquid(inp: DermalInput) -> ExposureOutput:
    """ModelID 25 — EPA/OPPT 1-Hand Dermal Contact with Liquids.

    Defaults: S = 535 cm²/event, Qu = 2.1 mg/cm²/event.
    """
    return _dermal(inp)


def dermal_2hand_liquid(inp: DermalInput) -> ExposureOutput:
    """ModelID 26 — EPA/OPPT 2-Hand Dermal Contact with Liquid.

    Defaults: S = 1070 cm²/event, Qu = 2.1 mg/cm²/event.
    """
    return _dermal(inp)


def dermal_2hand_immersion(inp: DermalInput) -> ExposureOutput:
    """ModelID 27 — EPA/OPPT 2-Hand Dermal Immersion in Liquid.

    Defaults: S = 1070 cm²/event, Qu = 10.3 mg/cm²/event (immersion
    high-end per Barrett et al. 2023 Table 2).
    """
    return _dermal(inp)


def dermal_2hand_solids(inp: DermalInput) -> ExposureOutput:
    """ModelID 28 — EPA/OPPT Direct 2-Hand Dermal Contact with Solids.

    Defaults: S = 1070 cm²/event, Qu = 3.1 mg/cm²/event.
    """
    return _dermal(inp)


def dermal_2hand_container_solids(inp: DermalInput) -> ExposureOutput:
    """ModelID 29 — EPA/OPPT 2-Hand Dermal Contact with Container Surfaces (Solids).

    Defaults: S = 1070 cm²/event, Qu = 1.0 mg/cm²/event (residual on
    container surfaces).
    """
    return _dermal(inp)


def user_defined_dermal(inp: DermalInput) -> ExposureOutput:
    """ModelID 44 — User-defined Dermal Model.

    Same math; user supplies all inputs. No canonical defaults.
    """
    return _dermal(inp)
