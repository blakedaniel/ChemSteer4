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
"""

from __future__ import annotations

from functools import cache

from sqlalchemy import text

from chemsteer.db.seed import get_engine


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


def defaults_for(model_id: int, *, act_id: int = 0, gss_id: int = 0) -> dict[int, float]:
    """Resolve ``{ParmID: default}`` for a model in an (activity, GS-op) context."""
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
    # Zero means "no default"; negative values are v3.2 sentinels
    # ("take from the chemical record"), not usable literals.
    return {pid: v for pid, (_rank, v) in by_specificity.items() if v > 0.0}
