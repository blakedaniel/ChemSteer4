#!/usr/bin/env python3
"""
analyze-source.py — walk decompilation/source/ChemSteer/*.cs and emit:
  * decompilation/forms.md          — form/dialog catalog with line counts
  * decompilation/cross-ref.md      — DB-table ↔ .cs file mapping
  * decompilation/sql-queries.md    — every literal SQL string with the file
                                      and approximate line where it appears

The mappings are best-effort (regex over decompiled C#) but good enough
to give a rebuild project a starting catalog.
"""
from __future__ import annotations

import re
import sqlite3
from collections import defaultdict
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent
SRC = ROOT / "decompilation/source/ChemSteer"
OUT_DIR = ROOT / "decompilation"

CHM = ROOT / "mdb/ChmSteer/ChmSteer.sqlite"
SCEN = ROOT / "mdb/scenarios/scenarios.sqlite"
SHELL = ROOT / "mdb/MDBShell/MDBShell.sqlite"


def collect_table_names() -> set[str]:
    names: set[str] = set()
    for db in (CHM, SCEN, SHELL):
        if not db.exists():
            continue
        con = sqlite3.connect(db)
        for (n,) in con.execute(
            "SELECT name FROM sqlite_master WHERE type='table';"
        ):
            names.add(n)
        con.close()
    return names


SQL_LITERAL = re.compile(
    r'"\s*(SELECT|INSERT|UPDATE|DELETE)\b[^"]{0,400}"',
    re.IGNORECASE | re.DOTALL,
)


def render_forms_md() -> None:
    out = ["# Forms / dialogs (decompiled)\n",
           "Catalog of `frm*.cs` files in the decompiled source. Line counts ",
           "indicate UI complexity; event handlers ending in `_Click`, ",
           "`_Load`, `_TextChanged` etc. are flagged.\n",
           "| File | Lines | Class | Event handlers |",
           "|---|---:|---|---:|"]

    for cs in sorted(SRC.glob("frm*.cs")):
        text = cs.read_text(errors="ignore")
        nlines = len(text.splitlines())
        m = re.search(r"(?:public|internal|sealed|partial|class)\s+(?:partial\s+)?class\s+(\w+)", text)
        cls = m.group(1) if m else "?"
        evt = len(re.findall(r"\b(\w+)_(Click|Load|Closed|Closing|TextChanged|"
                             r"SelectedIndexChanged|CheckedChanged|Enter|Leave|Activated|Resize|Shown)\b",
                             text))
        out.append(f"| `{cs.name}` | {nlines} | `{cls}` | {evt} |")

    (OUT_DIR / "forms.md").write_text("\n".join(out))
    print(f"  wrote {OUT_DIR / 'forms.md'}  ({len(list(SRC.glob('frm*.cs')))} forms)")


def render_cross_ref() -> None:
    tables = collect_table_names()
    print(f"  scanning {len(tables)} known table names against decompiled source")

    table_files: dict[str, set[str]] = defaultdict(set)
    for cs in SRC.glob("*.cs"):
        text = cs.read_text(errors="ignore")
        for tbl in tables:
            # Match table name as whole-word inside string literals or SQL.
            # Cheap heuristic — won't catch dynamic table refs but enough.
            if re.search(rf'\b{re.escape(tbl)}\b', text):
                table_files[tbl].add(cs.name)

    out = ["# DB tables ↔ decompiled C# files\n",
           "Map of every table in the three Access DBs to the decompiled ",
           "source files that reference it (literal-string match).\n",
           "| Table | DB | Files referencing |",
           "|---|---|---|"]

    db_of: dict[str, str] = {}
    for label, path in (("ChmSteer", CHM), ("MDBShell", SHELL), ("scenarios", SCEN)):
        if not path.exists():
            continue
        con = sqlite3.connect(path)
        for (n,) in con.execute(
            "SELECT name FROM sqlite_master WHERE type='table';"
        ):
            # Tables that exist in both DBs: prefer ChmSteer
            db_of.setdefault(n, label)
        con.close()

    for tbl in sorted(tables):
        files = sorted(table_files.get(tbl, set()))
        if not files:
            files_str = "_(no references found)_"
        else:
            files_str = ", ".join(f"`{f}`" for f in files[:8])
            if len(files) > 8:
                files_str += f" + {len(files) - 8} more"
        out.append(f"| `{tbl}` | {db_of.get(tbl, '?')} | {files_str} |")

    (OUT_DIR / "cross-ref.md").write_text("\n".join(out))
    print(f"  wrote {OUT_DIR / 'cross-ref.md'}")


def render_sql_queries() -> None:
    out = ["# Literal SQL queries embedded in ChemSteer.exe\n",
           "Every `\"SELECT/INSERT/UPDATE/DELETE...\"` string literal in the ",
           "decompiled C# source. Roughly 1:1 with the SQL ChemSTEER actually ",
           "issues at runtime.\n"]
    by_file: dict[str, list[tuple[int, str]]] = {}
    for cs in sorted(SRC.glob("*.cs")):
        text = cs.read_text(errors="ignore")
        hits = []
        for m in SQL_LITERAL.finditer(text):
            line_no = text.count("\n", 0, m.start()) + 1
            sql = m.group(0).strip('"').strip()
            hits.append((line_no, sql))
        if hits:
            by_file[cs.name] = hits

    total = sum(len(v) for v in by_file.values())
    out.append(f"_{total} SQL literals across {len(by_file)} files._\n")
    for fn in sorted(by_file):
        out.append(f"## `{fn}`")
        out.append("")
        for ln, sql in by_file[fn]:
            sql_one_line = re.sub(r"\s+", " ", sql).strip()
            out.append(f"- L{ln}: `{sql_one_line[:240]}`")
        out.append("")
    (OUT_DIR / "sql-queries.md").write_text("\n".join(out))
    print(f"  wrote {OUT_DIR / 'sql-queries.md'}  ({total} SQL literals)")


def main() -> None:
    OUT_DIR.mkdir(exist_ok=True)
    render_forms_md()
    render_cross_ref()
    render_sql_queries()


if __name__ == "__main__":
    main()
