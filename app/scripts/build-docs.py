#!/usr/bin/env python3
"""Generate MkDocs pages from the seed DB.

Renders:
  app/docs/models.md      One section per ModelID with name, type, equation,
                          and a link to the implementation file.
  app/docs/parameters.md  Table of every ListOfParms row with units.

Run from app/ before `mkdocs build` (or wire into a CI step).
"""

from __future__ import annotations

import sqlite3
import sys
from pathlib import Path

APP = Path(__file__).resolve().parent.parent
SEED = APP / "src/chemsteer/seed_data/chmsteer.db"
DOCS = APP / "docs"


def _impl_link(model_id: int, model_kind: str) -> str:
    """Best-effort link to the Python file that implements a given model."""
    if model_kind == "R":
        return "../src/chemsteer/calc/release/"
    if model_kind in ("I", "D"):
        return "../src/chemsteer/calc/exposure/"
    return "#"


def render_models() -> None:
    if not SEED.exists():
        sys.stderr.write(
            f"missing seed DB at {SEED}; run scripts/build-seed-db.py first\n"
        )
        sys.exit(1)
    con = sqlite3.connect(SEED)

    out = ["# Model registry\n",
           "Every release / inhalation / dermal model that ships in the v3.2 ",
           "seed data, with its equation as ChemSTEER stores it. ",
           "Equations are reproduced verbatim from `ListOfModels.Equation`.\n"]

    rows = list(
        con.execute(
            """
            SELECT ModelID, ModelName, Type, Equation, Basis, Mechanism
            FROM ListOfModels
            WHERE ModelID GLOB '[0-9]*'
            ORDER BY Type, CAST(ModelID AS INTEGER)
            """
        )
    )

    by_type: dict[str, list[tuple[int, str, str, str, str]]] = {"R": [], "I": [], "D": []}
    for mid_s, name, kind, eq, basis, mech in rows:
        if kind not in by_type:
            continue
        by_type[kind].append((int(mid_s), name or "", eq or "", basis or "", mech or ""))

    headings = {"R": "Release models", "I": "Inhalation models", "D": "Dermal models"}
    for kind in ("R", "I", "D"):
        out.append(f"## {headings[kind]}\n")
        for mid, name, eq, basis, mech in by_type[kind]:
            out.append(f"### #{mid} — {name}")
            out.append("")
            if mech:
                out.append(f"**Mechanism:** {mech}")
                out.append("")
            if basis:
                out.append(f"**Basis:** {basis}")
                out.append("")
            out.append("**Equation:**")
            out.append("")
            out.append("```")
            out.append(eq.strip())
            out.append("```")
            out.append("")

    con.close()
    (DOCS / "models.md").write_text("\n".join(out))
    print(f"wrote {DOCS / 'models.md'}  ({len(rows)} models)")


def render_parameters() -> None:
    con = sqlite3.connect(SEED)
    rows = list(
        con.execute(
            """
            SELECT ParmID, ParmName, Abbr, StdUnits, Notes
            FROM ListOfParms
            ORDER BY CAST(ParmID AS INTEGER)
            """
        )
    )
    con.close()

    out = ["# Parameter registry\n",
           "Every parameter referenced by the calc engine, with its ",
           "canonical units. The Pint registry in ",
           "`chemsteer.calc.units` mirrors this column for unit-safe ",
           "arithmetic.\n",
           "| ID | Abbr | Name | Units | Notes |",
           "|---:|---|---|---|---|"]

    for pid, name, abbr, units, notes in rows:
        n = (notes or "").replace("|", "\\|").replace("\n", " ")[:80]
        out.append(f"| {pid} | `{abbr}` | {name} | `{units or ''}` | {n} |")

    (DOCS / "parameters.md").write_text("\n".join(out))
    print(f"wrote {DOCS / 'parameters.md'}  ({len(rows)} parameters)")


if __name__ == "__main__":
    render_models()
    render_parameters()
