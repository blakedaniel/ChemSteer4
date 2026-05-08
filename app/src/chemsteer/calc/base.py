"""Shared types for the calc engine.

Each release / exposure model is a callable mapping a Pydantic input model
to a Pydantic output model. Inputs and outputs validate at the boundary
and serialize cleanly through the FastAPI layer.

Internally, every unit-bearing field is a `pint.Quantity`. The
``Annotated`` aliases below pre-bake the canonical unit for each
parameter family, so a model author writes::

    class Input(CalcInput):
        Amt: KgPerSiteDay
        LF:  Dimensionless

and Pydantic validates raw floats / strings / dicts into Quantities at
the right unit on input.
"""

from __future__ import annotations

from collections.abc import Callable
from typing import Annotated, Any

from pint import Quantity as PintQuantity
from pydantic import BaseModel, BeforeValidator, ConfigDict, PlainSerializer

from chemsteer.calc.units import Q_, ureg


def _make_coercer(unit: str) -> Callable[[Any], PintQuantity[float]]:
    """Build a BeforeValidator that maps raw input -> Quantity[unit]."""

    def _coerce(v: Any) -> PintQuantity[float]:
        if isinstance(v, PintQuantity):
            return v.to(unit)
        if isinstance(v, dict) and "value" in v and "unit" in v:
            return Q_(v["value"], v["unit"]).to(unit)
        if isinstance(v, int | float):
            return Q_(float(v), unit)
        if isinstance(v, str):
            # Route through our custom registry so app-defined units (site,
            # worker, container, ...) parse correctly. Pint's str overload
            # returns Quantity[str]; coerce magnitude to float for typing.
            parsed = ureg.Quantity(v)
            return ureg.Quantity(float(parsed.magnitude), parsed.units).to(unit)
        raise TypeError(f"cannot coerce {type(v).__name__} to Quantity[{unit}]")

    return _coerce


def _serialize_quantity(q: PintQuantity[float]) -> dict[str, Any]:
    return {"value": float(q.magnitude), "unit": str(q.units)}


_ToJson = PlainSerializer(_serialize_quantity, return_type=dict, when_used="json")


# --- Canonical typed-quantity aliases ------------------------------------
# Add new aliases as new units appear in models.

KgPerSiteDay = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("kilogram / (site * day)")),
    _ToJson,
]
KgPerYear = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("kilogram / year")),
    _ToJson,
]
Dimensionless = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("dimensionless")),
    _ToJson,
]
DaysPerYear = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("day / year")),
    _ToJson,
]
Sites = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("site")),
    _ToJson,
]
HoursPerSiteDay = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("hour / (site * day)")),
    _ToJson,
]
Torr = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("torr")),
    _ToJson,
]
GramsPerMole = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("gram / mole")),
    _ToJson,
]
Kelvin = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("kelvin")),
    _ToJson,
]
Atm = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("atm")),
    _ToJson,
]
Centimeter = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("centimeter")),
    _ToJson,
]
SquareCentimeter = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("centimeter ** 2")),
    _ToJson,
]
CmPerSecond = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("centimeter / second")),
    _ToJson,
]
GallonPerContainer = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("gallon / container")),
    _ToJson,
]
ContainerPerHour = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("container / hour")),
    _ToJson,
]
GasConstant = Annotated[
    # 82.057 atm·cm³/(mol·K)
    PintQuantity[float],
    BeforeValidator(_make_coercer("atm * centimeter ** 3 / mole / kelvin")),
    _ToJson,
]
GramsPerSecond = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("gram / second")),
    _ToJson,
]
GramsPerLiter = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("gram / liter")),
    _ToJson,
]
KgPerLiter = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("kilogram / liter")),
    _ToJson,
]
GallonsPerSiteDay = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("gallon / (site * day)")),
    _ToJson,
]
MgPerCmSquaredEvent = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("milligram / centimeter ** 2 / event")),
    _ToJson,
]
EventsPerDay = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("event / day")),
    _ToJson,
]
DaysPerSiteYear = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("day / (site * year)")),
    _ToJson,
]
Years = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("year")),
    _ToJson,
]
Kilograms = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("kilogram")),
    _ToJson,
]
Workers = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("worker")),
    _ToJson,
]
WorkersPerSite = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("worker / site")),
    _ToJson,
]
MgPerDay = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("milligram / day")),
    _ToJson,
]
MgPerKgPerDay = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("milligram / kilogram / day")),
    _ToJson,
]
MgPerEvent = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("milligram / event")),
    _ToJson,
]
SquareCmPerEvent = Annotated[
    PintQuantity[float],
    BeforeValidator(_make_coercer("centimeter ** 2 / event")),
    _ToJson,
]


class CalcInput(BaseModel):
    model_config = ConfigDict(arbitrary_types_allowed=True, populate_by_name=True)


class CalcOutput(BaseModel):
    model_config = ConfigDict(arbitrary_types_allowed=True)


# Loose model-function signature for the dispatch registry: every model has
# its own typed Pydantic input class, so the registry is heterogeneous —
# the precise per-model types live on the function itself, the dispatch is
# just a lookup by ID.
ModelFn = Callable[..., CalcOutput]


class ReleaseOutput(CalcOutput):
    """Standard ChemSTEER release outputs.

    ``DR`` is the per-site daily release; ``AR`` is the annual aggregate
    over all sites; ``NS`` is the number of sites the release occurs at.
    """

    DR: KgPerSiteDay
    AR: KgPerYear
    NS: Sites


class ExposureOutput(CalcOutput):
    """Standard ChemSTEER exposure outputs.

    Either ``I`` (inhalation intake, mg/day) or ``Dexp`` (dermal exposure,
    mg/day) is populated depending on the model's route. The
    derived dose metrics roll up from whichever is present:

    - ``LADD`` = Lifetime Average Daily Dose (mg/kg/day, cancer)
    - ``ADD``  = Average Daily Dose (mg/kg/day, non-cancer)
    - ``APDR`` = Acute Potential Dose Rate (mg/kg/day)
    - ``NW``   = total number of workers exposed (NWexp × NS)
    """

    I: MgPerDay | None = None  # noqa: E741 — canonical ChemSTEER output name (intake)
    Dexp: MgPerDay | None = None
    LADD: MgPerKgPerDay
    ADD: MgPerKgPerDay
    APDR: MgPerKgPerDay
    NW: Workers
