"""Parameter-default lookup over ``chmsteer.db::ParmDefaults``.

v3.2 pre-fills model dialogs from a 249-row defaults table keyed by
``(ParmID, ModelID, ActID, GSSID)`` where at most one of the last three
is non-zero per row:

- ``GSSID`` — operation-specific default for a Generic-Scenario op
  (e.g. operating days 360 for the cooling-tower op 103)
- ``ActID`` — activity-specific default
- ``ModelID`` — model-specific default (e.g. dermal S/Qu per model)
- all zero — global default

Specific beats general: GSS > Act > Model > global.

Negative ``DefaultValue`` entries are *second-level sentinels*: the
binary dispatches them to ``GetParmDefaults.GetParmDefaultXXXX``
(``ChemStrX.cs:2236-2420`` → ``GetParmDefaults.cs``). Three families:

- **constants per output characterization** — e.g. -3110 is the
  container-residue LF (0.0007 Central Tendency / 0.002 High End,
  ``GetParmDefault3110``). Ported in ``CONSTANT_SENTINELS`` below.
- **chemical-record pulls** — -3108/-3109 resolve to the assessment
  chemical's vapor pressure (``GetParmDefault3108/3109`` read
  ``frmMain.lblVP``). Resolved from :class:`ChemicalProps`. MW (ParmID
  5) and WSchem (ParmID 80) skip ParmDefaults entirely — their
  ``ListOfParms.DefaultSource`` is -1102/-1104, the direct
  chemical-record branch of ``GetModelDefault`` (ChemStrX.cs:2127/2135).
- **operation-parameter references** — e.g. -1107 means "use op parm
  130 (DRRchem)", -1110 "use op parm 2 (OD)". These need a live
  operation context; the Generic-Scenario instantiation reproduces the
  important ones (Amt←DRRchem for cooling-tower models, Freq←OD) via
  its op-parm merge, and the rest stay user-input — matching how the
  port surfaces missing parameters.

Unhandled sentinels are dropped (the parameter stays user-input).
"""

from __future__ import annotations

from dataclasses import dataclass
from functools import cache

from sqlalchemy import text

from chemsteer.db.seed import get_engine

VP_PARM = 4
MW_PARM = 5
WSCHEM_PARM = 80


@dataclass(frozen=True)
class ChemicalProps:
    """The chemical-record values the defaults sentinels can pull.

    Units are v3.2 standard units (torr, g/mol, kg/L, g/L) — identical
    to the calc-input canonical units, so no conversion happens here.
    """

    mw: float | None = None
    vp_torr: float | None = None
    density_kg_l: float | None = None
    solubility_g_l: float | None = None


# Second-level ParmDefaults sentinels that resolve to constants, as
# (Central Tendency, High End) per GetParmDefaults.cs. Where the binary
# offers a single "Conservative"/"not characterized" value, both outputs
# share it.
CONSTANT_SENTINELS: dict[int, tuple[float, float]] = {
    -3106: (0.5, 0.1),  # k mixing factor — GetParmDefault3106
    -3110: (0.0007, 0.002),  # LF, container residue (#1) — GetParmDefault3110
    -3111: (0.025, 0.03),  # LF, drum residue (#2) — GetParmDefault3111
    -3112: (0.002, 0.01),  # LF, multiple vessels (#4) — GetParmDefault3112
    -3113: (0.003, 0.006),  # LF, single vessel (#5) — GetParmDefault3113
    -3114: (0.01, 0.01),  # LF, small containers (#6) — GetParmDefault3114
    -3115: (0.02, 0.02),  # LF, bulk transport (#3) — GetParmDefault3115
    -3128: (0.005, 0.005),  # LF, solids transfer dust (#53) — GetParmDefault3128
}

# Sentinels that resolve to the chemical record's vapor pressure
# (GetParmDefault3108 reads lblVP directly; 3109 prefers an associated
# release model's VP, falling back to lblVP — without a live form the
# fallback IS the behaviour).
VP_SENTINELS = frozenset({-3108, -3109})


@cache
def _all_rows() -> tuple[tuple[int, int, int, int, float], ...]:
    """(ParmID, ModelID, ActID, GSSID, DefaultValue) rows, cached."""
    with get_engine("chmsteer").connect() as con:
        rows = con.execute(
            text('SELECT "ParmID", "ModelID", "ActID", "GSSID", "DefaultValue" FROM "ParmDefaults"')
        ).all()
    out: list[tuple[int, int, int, int, float]] = []
    for parm_id, model_id, act_id, gss_id, value in rows:
        try:
            out.append(
                (
                    int(float(parm_id or 0)),
                    int(float(model_id or 0)),
                    int(float(act_id or 0)),
                    int(float(gss_id or 0)),
                    float(value or 0.0),
                )
            )
        except ValueError:
            continue
    return tuple(out)


def defaults_for(
    model_id: int,
    *,
    act_id: int = 0,
    gss_id: int = 0,
    output: int = 0,
    chemical: ChemicalProps | None = None,
) -> dict[int, float]:
    """Resolve ``{ParmID: default}`` for a model in an (activity, GS-op)
    context.

    ``output`` is the v3.2 output characterization index (0 = Central
    Tendency / Output1, 1 = High End / Output2) — some sentinel defaults
    differ per output. ``chemical`` supplies the assessment's chemical
    record for the VP/MW/WSchem pulls.
    """
    by_specificity: dict[int, tuple[int, float]] = {}
    for parm_id, m, a, g, value in _all_rows():
        if m == 0 and a == 0 and g == 0:
            rank = 0
        elif m != 0:
            if m != model_id:
                continue
            rank = 1
        elif a != 0:
            if a != act_id:
                continue
            rank = 2
        else:  # g != 0
            if g != gss_id:
                continue
            rank = 3
        prev = by_specificity.get(parm_id)
        if prev is None or rank >= prev[0]:
            by_specificity[parm_id] = (rank, value)

    out_index = 1 if output else 0
    resolved: dict[int, float] = {}
    for pid, (_rank, v) in by_specificity.items():
        if v > 0.0:
            resolved[pid] = v
        else:
            sentinel = int(v)
            if sentinel in CONSTANT_SENTINELS:
                resolved[pid] = CONSTANT_SENTINELS[sentinel][out_index]
            elif sentinel in VP_SENTINELS and chemical and chemical.vp_torr:
                resolved[pid] = chemical.vp_torr
            # Anything else (op-parm references, zero) stays unset.

    # Direct chemical-record DefaultSources (ListOfParms, not ParmDefaults):
    # MW is -1102, WSchem is -1104; VP also lands here when no model row
    # gave it a sentinel.
    if chemical:
        if chemical.mw and MW_PARM not in resolved:
            resolved[MW_PARM] = chemical.mw
        if chemical.solubility_g_l and WSCHEM_PARM not in resolved:
            resolved[WSCHEM_PARM] = chemical.solubility_g_l
        if chemical.vp_torr and VP_PARM not in resolved:
            resolved[VP_PARM] = chemical.vp_torr
    return resolved


@cache
def media_defaults_for(model_id: int) -> dict[int, float]:
    """Default release-media split ``{MediaID: pct}`` for a release model
    (``chmsteer.db::MediaDefaults``). Empty when v3.2 ships none."""
    with get_engine("chmsteer").connect() as con:
        rows = con.execute(
            text('SELECT "MediaID", "Pct" FROM "MediaDefaults" WHERE CAST("ModelID" AS INT) = :m'),
            {"m": model_id},
        ).all()
    out: dict[int, float] = {}
    for media_id, pct in rows:
        try:
            out[int(float(media_id))] = float(pct or 0.0)
        except ValueError:
            continue
    return out
