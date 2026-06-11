"""ParmID → calc-input-field mapping.

ChemSTEER v3.2 stores model parameters as numeric ``ParmID`` rows (see
``ChmSteer.epa::ListOfParms``; the decompiled binary indexes
``Globals.arParmValues`` by the same IDs). Our calc input classes use
the human-readable abbreviations as field names (``Amt``, ``LF``,
``Freq``…), so anything that ingests v3.2-shaped parameter rows — the
``.cs2`` importer and the Generic-Scenario instantiation service — must
translate through this table.

Values in v3.2 data are stored in ``ListOfParms.StdUnits``. After the
ft³/min (Q) and ft/min (vz) canonical-unit fixes, those std units
coincide with our field units for every parameter except the ones given
an explicit ``unit`` here, which the Pint coercer converts on input.

A value of ``0`` means "not filled in" in v3.2 (the binary's
``missing_required_parameter`` treats 0 as missing), so callers should
drop zero-valued parms rather than feed literal zeros into a model.
"""

from __future__ import annotations

from typing import Any

from chemsteer.calc.dispatch import get_input_class

# ParmID -> (field name, unit override or None).
# Multiple ParmIDs may map to the same field (v3.2 registered duplicate
# parms per model family, e.g. S is 36 and 55); that is fine as long as
# only one of them appears on a given run's parameter rows.
PARM_TO_FIELD: dict[int, tuple[str, str | None]] = {
    1: ("NS", None),  # Number of Sites (sites)
    4: ("VP", None),  # Vapor Pressure (torr)
    5: ("MW", None),  # Molecular Weight (g/mol)
    6: ("R", None),  # Universal Gas Constant (atm cm3/gmol K)
    7: ("P", None),  # Atmospheric Pressure (atm)
    8: ("T", None),  # Temperature (K)
    19: ("Vc", None),  # Volume Capacity of container (gal/container)
    22: ("f", None),  # Saturation Factor (-)
    23: ("r", None),  # Container Rate (containers/hr)
    26: ("d", None),  # Diameter of Opening / Pool Length (cm)
    28: ("A", None),  # Area (cm2)
    31: ("OHa", None),  # Operating Hours for the Activity (hrs/day)
    36: ("S", None),  # Surface Area (cm2)
    37: ("Qu", None),  # Quantity for Chemical on Skin (mg/cm2-event)
    38: ("Ys", None),  # OBSO weight fraction (-)
    40: ("X", None),  # Vapor Pressure Correction Factor (-)
    41: ("Y", None),  # EY — Years of Occupational Exposure (years)
    42: ("BW", None),  # Body Weight (kg)
    44: ("b", None),  # Inhalation Rate (m3/hr)
    46: ("h", None),  # Exposure Duration (hrs/day)
    47: ("AT", None),  # Averaging Time (years)
    48: ("ATc", None),  # Averaging Time, chronic (years)
    49: ("G", None),  # Vapor Generation Rate (g/s)
    50: ("G", None),  # Vapor Generation Rate (g/s)
    51: ("k", None),  # Mixing Factor (-)
    53: ("Q", None),  # Ventilation Rate (ft3/min — canonical for Q)
    55: ("S", None),  # Surface Area (cm2)
    56: ("Qu", None),  # Quantity for Chemical on Skin (mg/cm2-event)
    57: ("KCk", None),  # Particulate mass concentration (mg/m3)
    60: ("FT", None),  # Frequency of Events (events/site-day)
    61: ("AH", None),  # Amount of Material Handled (kg/day)
    62: ("KCk", None),  # Particulate mass concentration (mg/m3)
    63: ("Vm", None),  # Molar Volume (L/mol)
    66: ("Cv", None),  # Volume Concentration (ppm)
    67: ("Cv", None),  # Volume Concentration (ppm)
    69: ("vz", None),  # Air Speed (ft/min — canonical for vz)
    70: ("KCk", None),  # Particulate mass concentration (mg/m3)
    71: ("h", None),  # Exposure Duration (hrs/day)
    72: ("Freq", None),  # Frequency of Use (days/site-yr)
    73: ("LF", None),  # Loss Fraction (-)
    74: ("LF", None),  # Loss Fraction (-)
    75: ("ED", None),  # Exposure Days (days/site-yr)
    77: ("Wf", None),  # Yderm — weight fraction in contacted material (-)
    78: ("Ys", None),  # Weight fraction in particulate/mist/mixture (-)
    79: ("CF", None),  # Correction Factor (-)
    80: ("WSchem", None),  # Water solubility (g/L)
    81: ("EF", None),  # Exposure Factor (mg/kg)
    82: ("Sd", None),  # Shifts worked (shifts/worker-day, dimensionless)
    90: ("Cvk", None),  # Vapor concentration of the chemical (ppm)
    91: ("NWexp", None),  # Number of Workers Exposed (workers/site)
    92: ("Amt", None),  # Amount to Use (kg/site-day)
    95: ("Vppel", None),  # VPpel — VP of pure PEL chemical (torr)
    96: ("Ypel", None),  # Weight fraction of PEL chemical (-)
    97: ("Mwpel", None),  # MWpel — MW of PEL chemical (g/mol)
    113: ("Ys", None),  # Weight fraction (-)
    117: ("LF", None),  # Loss Fraction (-)
    131: ("Ybath", None),  # Weight fraction in bath (-)
    132: ("Yrinse", None),  # Weight fraction in rinse water (-)
    133: ("Dbath", None),  # Density of bath (kg/L)
    134: ("Drinse", None),  # Density of rinse (kg/L)
    138: ("DVrinse", None),  # Daily rinse volume (gal/site-day)
    139: ("RinseE", None),  # Rinsewater recovery efficiency (-)
    141: ("DVbath", None),  # Daily volume of bath change (gal)
    145: ("VFF", None),  # Volume of Far-Field (m3)
    146: ("AER", None),  # Air Exchange Rate (1/hr)
    147: ("velocityNF", "meter / hour"),  # NF indoor wind speed (m/hr)
    148: ("LNF", None),  # Length of Near-Field (m)
    149: ("WNF", None),  # Width of Near-Field (m)
    150: ("HNF", None),  # Height of Near-Field (m)
    151: ("G", "milligram / hour"),  # NF/FF vapor generation rate (mg/hr)
}

# Cooling-tower models (#12 blowdown, #13 windage, #14 evaporative) take
# their Amt from the daily recirculation rate of chemical (DRRchem, 130)
# and their LF from the per-route loss fractions (127/128/129), not from
# the generic Amt/LF parms — which also ride along on scenario rows as
# mass-balance work fields and must NOT be mapped for these models.
MODEL_PARM_OVERRIDES: dict[tuple[str, int], dict[int, tuple[str, str | None]]] = {
    ("release", 12): {130: ("Amt", None), 127: ("LF", None)},
    ("release", 13): {130: ("Amt", None), 128: ("LF", None)},
    ("release", 14): {130: ("Amt", None), 129: ("LF", None)},
}


def map_parms(
    model_kind: str,
    model_id: int,
    parms: dict[int, float],
) -> tuple[dict[str, Any], dict[int, float]]:
    """Translate ``{ParmID: value}`` rows into calc-input kwargs.

    Returns ``(inputs, unmapped)``: ``inputs`` holds only fields that
    exist on the model's input class, with unit-override values wrapped
    as ``{"value", "unit"}`` dicts for the Pint coercer; ``unmapped``
    holds non-zero parms that don't correspond to any input field (mass
    -balance work fields, alternate-route values, …) for transparency.

    Zero-valued parms are dropped: v3.2 uses 0 to mean "not filled in".
    """
    input_cls = get_input_class(model_kind, model_id)
    field_names = set(input_cls.model_fields.keys())
    overrides = MODEL_PARM_OVERRIDES.get((model_kind, model_id), {})
    overridden_fields = {field for field, _unit in overrides.values()}

    inputs: dict[str, Any] = {}
    unmapped: dict[int, float] = {}
    for parm_id, value in parms.items():
        if value == 0.0:
            continue
        if parm_id in overrides:
            field, unit = overrides[parm_id]
        else:
            mapped = PARM_TO_FIELD.get(parm_id)
            # When a model has overrides for a field, the generic parm
            # for that same field is a work field — ignore it.
            if mapped is None or mapped[0] in overridden_fields:
                if mapped is None:
                    unmapped[parm_id] = value
                continue
            field, unit = mapped
        if field not in field_names:
            unmapped[parm_id] = value
            continue
        inputs[field] = {"value": value, "unit": unit} if unit else value
    return inputs, unmapped
