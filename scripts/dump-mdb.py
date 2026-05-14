#!/usr/bin/env python3
"""
dump-mdb.py — dump every .epa (MS Access) DB to per-table CSV + a single
SQLite database, using pandas_access (which handles embedded newlines and
quotes correctly via Python's csv module).

This supersedes scripts/dump-mdb.sh, which used mdb-export + sqlite3 .import
and lost rows on tables with multi-line text cells.

Outputs per DB <name>.epa:
    mdb/<name>/tables/<table>.csv      one CSV per table (with header)
    mdb/<name>/<name>.sqlite           SQLite DB with all tables loaded
    mdb/<name>/manifest.json           per-table row counts + columns
"""
from __future__ import annotations

import json
import shutil
import sqlite3
from pathlib import Path

import numpy as np

# pandas_access is unmaintained and references removed numpy aliases.
# Patch them back in before importing.
if not hasattr(np, "float_"):
    np.float_ = np.float64  # type: ignore[attr-defined]
if not hasattr(np, "int_"):
    np.int_ = np.int64  # type: ignore[attr-defined]
if not hasattr(np, "bool_"):
    np.bool_ = bool  # type: ignore[attr-defined]

import pandas as pd
import pandas_access as mdb

ROOT = Path(__file__).resolve().parent.parent
SRC_DIR = ROOT / "extracted/msi-app"
OUT_DIR = ROOT / "mdb"


def dump_db(epa_path: Path) -> None:
    name = epa_path.stem
    out = OUT_DIR / name
    print(f">>> {epa_path} -> {out}/")

    if out.exists():
        shutil.rmtree(out)
    (out / "tables").mkdir(parents=True)

    sqlite_path = out / f"{name}.sqlite"
    con = sqlite3.connect(sqlite_path)

    tables = [t for t in mdb.list_tables(str(epa_path))
              if not (t.startswith("$") or t.startswith("~"))]

    import io
    import subprocess

    def _fallback_read(table: str) -> pd.DataFrame:
        """Use mdb-export with tab delimiter when pandas_access dtype
        inference fails. Tab is safer than comma when fields contain commas
        in unquoted/lightly-quoted text."""
        out = subprocess.check_output(
            ["mdb-export", "-d", "\t", "-Q",
             "-D", "%Y-%m-%dT%H:%M:%S", str(epa_path), table],
            text=True,
        )
        return pd.read_csv(io.StringIO(out), sep="\t",
                           dtype=str, keep_default_na=False)

    manifest: dict[str, dict] = {}
    for tbl in tables:
        try:
            df = mdb.read_table(str(epa_path), tbl)
        except Exception as exc:
            try:
                df = _fallback_read(tbl)
                print(f"  [fb]   {tbl:30s} (mdb-export fallback after: {type(exc).__name__})")
            except Exception as exc2:
                print(f"  [warn] {tbl}: both readers failed ({exc2})")
                manifest[tbl] = {"error": str(exc2), "rows": 0, "columns": []}
                continue

        # CSV with proper quoting (csv.QUOTE_MINIMAL handles newlines/commas)
        csv_path = out / "tables" / f"{tbl}.csv"
        df.to_csv(csv_path, index=False)

        # SQLite — replace if exists, dtype=str to preserve raw values
        df.to_sql(tbl, con, if_exists="replace", index=False)

        manifest[tbl] = {
            "rows": int(len(df)),
            "columns": list(df.columns),
        }
        print(f"  [ok]   {tbl:30s} rows={len(df):6d} cols={len(df.columns)}")

    con.commit()
    con.close()

    with (out / "manifest.json").open("w") as f:
        json.dump(manifest, f, indent=2, default=str)

    n_tables = sum(1 for v in manifest.values() if "error" not in v)
    print(f"    -> {n_tables} tables, sqlite at {sqlite_path}")


def main() -> None:
    epas = sorted(SRC_DIR.glob("*.epa"))
    if not epas:
        raise SystemExit(f"no .epa files in {SRC_DIR}")
    OUT_DIR.mkdir(exist_ok=True)
    for epa in epas:
        dump_db(epa)
    print(">>> done")


if __name__ == "__main__":
    main()
