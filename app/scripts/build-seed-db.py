#!/usr/bin/env python3
"""
build-seed-db.py — assemble bundled seed SQLite databases from the
extraction-time CSVs at ../mdb/<db>/tables/*.csv.

Output: app/src/chemsteer/seed_data/{chmsteer,scenarios,mdbshell}.db

Run at packaging time (or any time the upstream extraction is refreshed).
The resulting .db files are checked into git so that `pip install` /
`docker build` does not need access to the extraction tree.
"""
from __future__ import annotations

import csv
import sqlite3
import sys
from pathlib import Path

APP_DIR = Path(__file__).resolve().parent.parent
WORKSPACE = APP_DIR.parent
MDB_DIR = WORKSPACE / "mdb"
OUT_DIR = APP_DIR / "src" / "chemsteer" / "seed_data"

SOURCE_DBS = ("ChmSteer", "MDBShell", "scenarios")
OUTPUT_NAMES = {
    "ChmSteer": "chmsteer.db",
    "MDBShell": "mdbshell.db",
    "scenarios": "scenarios.db",
}


def load_csv(path: Path) -> tuple[list[str], list[list[str]]]:
    with path.open(newline="", encoding="utf-8") as f:
        reader = csv.reader(f)
        rows = list(reader)
    if not rows:
        return [], []
    header, *data = rows
    return header, data


def build_one(src_db: str) -> None:
    src = MDB_DIR / src_db / "tables"
    if not src.exists():
        raise SystemExit(f"missing source CSV dir: {src}")

    out_path = OUT_DIR / OUTPUT_NAMES[src_db]
    if out_path.exists():
        out_path.unlink()
    OUT_DIR.mkdir(parents=True, exist_ok=True)

    con = sqlite3.connect(out_path)
    cur = con.cursor()
    n_tables = 0
    n_rows_total = 0

    for csv_path in sorted(src.glob("*.csv")):
        table = csv_path.stem
        header, rows = load_csv(csv_path)
        if not header:
            continue

        cols_def = ", ".join(f'"{c}" TEXT' for c in header)
        cur.execute(f'DROP TABLE IF EXISTS "{table}";')
        cur.execute(f'CREATE TABLE "{table}" ({cols_def});')

        if rows:
            placeholders = ", ".join("?" for _ in header)
            cur.executemany(
                f'INSERT INTO "{table}" VALUES ({placeholders});',
                rows,
            )

        n_tables += 1
        n_rows_total += len(rows)

    con.commit()
    con.close()

    rel = out_path.relative_to(APP_DIR)
    print(f"  built {rel}: {n_tables} tables, {n_rows_total} rows")


def main() -> None:
    print(f"  workspace: {WORKSPACE}")
    print(f"  output:    {OUT_DIR}")
    for db in SOURCE_DBS:
        build_one(db)

    # Sanity-check: ListOfModels in chmsteer.db should have 38 rows
    chm = OUT_DIR / "chmsteer.db"
    con = sqlite3.connect(chm)
    n = con.execute('SELECT COUNT(*) FROM "ListOfModels";').fetchone()[0]
    con.close()
    if n < 30:
        print(f"  WARN: ListOfModels has only {n} rows (expected ~38)", file=sys.stderr)
    else:
        print(f"  sanity: ListOfModels has {n} rows")
    print("  done")


if __name__ == "__main__":
    main()
