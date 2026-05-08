"""Pint unit registry for ChemSTEER's calc engine.

The seed-data `ListOfParms.StdUnits` column drives this. Most units are
already defined by Pint's default registry; we extend it with the few
custom units ChemSTEER uses (`site`, `worker`, `container`, `day`-batch
shorthand, etc.) so equation strings translate cleanly.

Use the module-level `ureg` everywhere — registries don't compose, so
all `Quantity` instances must come from the same one.
"""

from __future__ import annotations

from pint import Quantity, UnitRegistry

ureg: UnitRegistry = UnitRegistry()  # type: ignore[type-arg]
Q_ = ureg.Quantity

# --- Custom dimensionless / counting units -------------------------------
# ChemSTEER tracks counts of things alongside masses — Pint requires us to
# define them as units (or use plain dimensionless floats). Defining them
# avoids losing the semantic distinction between "5 sites" and "5 days".
for _u in ("site", "worker", "container", "batch", "event", "car", "operation"):
    ureg.define(f"{_u} = [{_u}]")

# --- Parameter-abbreviation → canonical-unit map -------------------------
# Mirror of `ListOfParms.StdUnits` but normalised to Pint syntax. Used by
# the calc engine to wrap raw floats in `Q_` at the boundary.
PARM_UNITS: dict[str, str] = {
    "NS": "site",
    "OD": "day / (site * year)",
    "OH": "hour / (site * day)",
    "VP": "torr",
    "MW": "gram / mol",
    "R": "atm * centimeter ** 3 / (gram / mol) / kelvin",
    "P": "atm",
    "T": "kelvin",
    "WFused": "dimensionless",
    "Yprod": "dimensionless",
    "Yrm": "dimensionless",
    "DMOprod": "kilogram / (site * day)",
    "DMOchem": "kilogram / (site * day)",
    "DMIrm": "kilogram / (site * day)",
    "DMIchem": "kilogram / (site * day)",
    "Nby": "batch / (site * year)",
    "Nbd": "batch / (site * day)",
    "ODmax": "day",
    "Vc": "gallon / container",
    "fc": "dimensionless",
    "vCar": "liter / car",
    "f": "dimensionless",
    "r": "container / hour",
    "Nbld": "batch / day",  # per-line per-day
    "Ncar": "car / (site * day)",
    "d": "centimeter",
    "A": "centimeter ** 2",
    "Drm": "kilogram / liter",
    "Dprod": "kilogram / liter",
    # --- Frequency / amount / loss-fraction (commonly used core trio) ----
    "Freq": "day / year",
    "Amt": "kilogram / (site * day)",
    "LF": "dimensionless",
    # Outputs
    "DR": "kilogram / (site * day)",
    "AR": "kilogram / year",
}


def units_for(abbr: str) -> str:
    """Return the canonical unit string for a parameter abbreviation, or
    'dimensionless' if unknown."""
    return PARM_UNITS.get(abbr, "dimensionless")


def quantity(value: float, abbr: str) -> Quantity[float]:
    """Wrap a raw float in the canonical units for the named parameter."""
    return Q_(value, units_for(abbr))
