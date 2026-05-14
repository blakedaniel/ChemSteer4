#!/usr/bin/env python3
"""
build-docs.py — render mdb/tables.md and mdb/scenarios.md from the dumped
SQLite databases. Run after scripts/dump-mdb.py.

mdb/tables.md     — per-DB table catalog with row counts, columns, and a
                    short semantic note for each named table.
mdb/scenarios.md  — enumerated Generic Scenarios with the activity / model /
                    parameter set extracted for each.
"""
from __future__ import annotations

import sqlite3
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent
MDB = ROOT / "mdb"

# ---------------------------------------------------------------------------
# Semantic notes for tables. Keys match Access table names. Tables not in
# this map are still listed but with "(no annotation yet)".
NOTES: dict[str, str] = {
    # ChmSteer.epa
    "ListOfModels": "Master model registry. ModelID + Type (R=release, I=inhalation, D=dermal). The `Equation` column is the equation in plain text — defaults, equations, and basis notes all live here.",
    "ListOfActivities": "Activity registry. Each activity carries default models for release / inhalation / dermal — this is the data-driven model-selection backbone.",
    "ListOfValidModels": "Many-to-many: which models are valid for each activity. 298 rows = the full activity-to-model option matrix.",
    "ListOfValidActivities": "Operation→activity allowlist (4 rows).",
    "ListOfOperations": "Operation registry (8 rows). Operation = manufacturing / processing / use, etc.",
    "ListOfParms": "Parameter registry (161 rows). Defines every named parameter (e.g. MW, VP, LF) used in equations.",
    "ListOfMedia": "Release media (air, water, land, etc.) — 18 rows.",
    "ListOfChemStates": "Chemical states (volatile liquid, solid, etc.).",
    "ListOfPhyStates": "Physical states (S/L/G/...).",
    "ListOfOptData": "Optional-data flags (7 rows).",
    "ListOfAssessTypes": "Assessment types (15 rows).",
    "ListOfAssStatus": "Assessment status codes.",
    "ParmDefaults": "Per-parameter default values. The published 'Common Engineering Defaults' tables are reflected here.",
    "ParmLabelOverrides": "Per-context parameter label overrides.",
    "MediaDefaults": "Per-media default release values.",
    "Meta2Defaults": "Physico-chemical / meta defaults (72 rows).",
    "MostLikelyActs": "Operation→activity hint table (which activities are most likely for each operation).",
    "GssAutoSelectActs": "Auto-selected activities per Generic Scenario (16 rows).",
    "ActCats": "Activity categories (90 rows).",
    "ListOfActCats": "Activity-category lookup (18 rows).",
    "Codes": "Generic enum table (92 rows).",
    "Instructions": "Per-model textual instructions / notes (50 rows).",
    "NAICS": "NAICS industry codes (1814 rows) — used for OpNAICS lookups.",
    "States": "US states (51 rows).",
    "pel_rel_twa": "OSHA PEL / NIOSH REL / TWA chemical limits (652 rows). Indexed by NumericCas.",
    # MDBShell.epa — empty assessment template
    # scenarios.epa — Generic Scenarios
    "Operations": "The Generic Scenarios themselves. In `scenarios.epa` this is 34 rows = the 34 GSs that ship with v3.2.",
    "Activities": "Per-scenario activities (159 rows in scenarios.epa) — what the workers actually do at each scenario site.",
    "OpParms": "Per-operation parameter values (4992 rows) — the scenario-specific overrides of ParmDefaults.",
    "ActExpModels": "Per-activity exposure models (74 rows) — links activity to inhalation/dermal model.",
    "ActExpModParms": "Per-(activity, exposure model) parameter values (4864 rows).",
    "ActRelModels": "Per-activity release models (137 rows).",
    "ActRelModParms": "Per-(activity, release model) parameter values (9346 rows).",
    "ActRelModMedia": "Release-media partitioning per (activity, release model) (149 rows).",
    "ActContParms": "Containment / control-equipment parameters per activity (961 rows).",
    "GSSOptions": "Generic-Scenario options table (empty in v3.2).",
    "OpNAICS": "Per-operation NAICS codes (empty in v3.2 scenarios.epa).",
    # MDBShell-only template tables
    "Assessments": "User assessment records (empty template).",
    "Chemicals": "Per-assessment chemical records (empty template).",
    "ContactRpts": "Contact-report metadata (empty template).",
    "OpRel": "Operation-level release rollups (empty template).",
    "OpSites": "Per-operation site records (empty template).",
    "RelGroups": "Release groups (empty template).",
    "RevisionHistory": "Per-assessment revision log (empty template).",
    "SAT": "Source-allocation table (empty template).",
    "Tron": "Singleton config row (always 1 row).",
    "ActExpModEst": "Per-activity exposure-model estimates (empty template).",
    "MSDS_ExpLimits": "MSDS exposure-limit overrides (empty template).",
    "IrerRels": "IRER release records (empty template).",
}


def render_tables_md() -> None:
    out = ["# Access database — table catalog\n",
           "Per-DB index of every Access table dumped under `mdb/<db>/`.",
           "Row counts are post-load (post-Python-pandas_access dump).\n"]

    for db_dir in sorted(MDB.iterdir()):
        if not db_dir.is_dir():
            continue
        sqlite_path = db_dir / f"{db_dir.name}.sqlite"
        if not sqlite_path.exists():
            continue

        out.append(f"## `{db_dir.name}.epa`")
        out.append("")
        out.append("| Table | Rows | Cols | Notes |")
        out.append("|---|---:|---:|---|")

        con = sqlite3.connect(sqlite_path)
        cur = con.cursor()
        tbls = [r[0] for r in cur.execute(
            "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;"
        )]
        for t in tbls:
            n = cur.execute(f'SELECT COUNT(*) FROM "{t}";').fetchone()[0]
            ncols = len(cur.execute(f'PRAGMA table_info("{t}");').fetchall())
            note = NOTES.get(t, "")
            out.append(f"| `{t}` | {n} | {ncols} | {note} |")
        con.close()
        out.append("")

    (MDB / "tables.md").write_text("\n".join(out))
    print(f"wrote {MDB / 'tables.md'}")


def render_scenarios_md() -> None:
    """Enumerate Generic Scenarios from scenarios.epa, joining their
    activities, exposure models, and release models."""
    sqlite_path = MDB / "scenarios" / "scenarios.sqlite"
    con = sqlite3.connect(sqlite_path)
    con.row_factory = sqlite3.Row
    cur = con.cursor()

    out = ["# Generic Scenarios (v3.2)\n",
           "The 34 Generic Scenarios shipped in `scenarios.epa`. Each ",
           "section lists the activities defined for the scenario and the ",
           "release / exposure models attached to each activity.\n",
           "Source: `mdb/scenarios/scenarios.sqlite`.\n"]

    ops = cur.execute(
        "SELECT OpID, OpName, ScenarioID, OpType, GSS_PDF "
        "FROM Operations ORDER BY CAST(OpID AS INTEGER), OpName;"
    ).fetchall()

    for op in ops:
        scen = op["ScenarioID"]
        out.append(f"## {op['OpName']}")
        out.append("")
        out.append(f"- ScenarioID: `{scen}`  · OpID: `{op['OpID']}`  · OpType: `{op['OpType']}`")
        if op["GSS_PDF"]:
            out.append(f"- Reference PDF: `{op['GSS_PDF']}`")
        out.append("")

        # Activities for this scenario
        acts = cur.execute(
            "SELECT a.* FROM Activities a "
            "WHERE a.ScenarioID = ? ORDER BY CAST(a.ActID AS INTEGER);",
            (scen,)
        ).fetchall()
        if not acts:
            out.append("_(no Activities rows joined on ScenarioID — schema may key differently.)_\n")
            continue

        out.append(f"### Activities ({len(acts)})")
        out.append("")
        out.append("| ActID | ActName | RelMdls | ExpMdls |")
        out.append("|---|---|---:|---:|")
        for a in acts:
            # Activities↔ActRelModels/ActExpModels join on ScenActID, not ActID.
            n_rel = cur.execute(
                "SELECT COUNT(*) FROM ActRelModels WHERE ScenActID=?;",
                (a["ScenActID"],)
            ).fetchone()[0]
            n_exp = cur.execute(
                "SELECT COUNT(*) FROM ActExpModels WHERE ScenActID=?;",
                (a["ScenActID"],)
            ).fetchone()[0]
            name = a["ActName"] if "ActName" in a.keys() else "?"
            out.append(f"| `{a['ActID']}` | {name} | {n_rel} | {n_exp} |")
        out.append("")

    (MDB / "scenarios.md").write_text("\n".join(out))
    con.close()
    print(f"wrote {MDB / 'scenarios.md'}")


if __name__ == "__main__":
    render_tables_md()
    render_scenarios_md()
