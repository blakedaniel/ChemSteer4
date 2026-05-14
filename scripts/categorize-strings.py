#!/usr/bin/env python3
"""
categorize-strings.py — slice strings/all-unique.txt into useful buckets
and write strings/categorized.md.

Categories (in render order):
  1. SQL fragments
  2. Error / status messages
  3. Form / dialog class names (VB.NET WinForms)
  4. Calculation method names
  5. Model / table / parameter references
  6. File system & resource paths
"""
from __future__ import annotations

import re
from collections import OrderedDict
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent
SRC = ROOT / "strings/all-unique.txt"
OUT = ROOT / "strings/categorized.md"

PATTERNS: "OrderedDict[str, re.Pattern[str]]" = OrderedDict([
    ("SQL fragments",
        re.compile(r"^\s*(SELECT|INSERT|UPDATE|DELETE)\b", re.IGNORECASE)),
    ("Form / dialog classes",
        re.compile(r"^frm[A-Z][A-Za-z0-9_]+(\.vb|_[A-Z][a-z]+)?$")),
    ("Calc / model methods",
        re.compile(r"^(Calc|Compute|Estimate|Update|Get|Set)[A-Z]")),
    ("File / resource paths",
        re.compile(r"\\[A-Za-z][A-Za-z0-9_]+\\[A-Za-z0-9_.]+\.[a-zA-Z]{2,4}$|^\\Help\\")),
    ("Visible UI text (suspect)",
        re.compile(r"^[A-Z][a-zA-Z ,.'\-/&():;\d]{15,200}[.?!:]?$")),
])


def main() -> None:
    if not SRC.exists():
        raise SystemExit(f"missing {SRC}")
    lines = [s.strip() for s in SRC.read_text(errors="ignore").splitlines() if s.strip()]
    print(f"  {len(lines)} unique strings to scan")

    buckets: dict[str, list[str]] = {k: [] for k in PATTERNS}
    used: set[str] = set()
    for line in lines:
        for cat, pat in PATTERNS.items():
            if pat.search(line):
                buckets[cat].append(line)
                used.add(line)
                break

    out = ["# ChemSteer.exe — categorized strings\n",
           f"Slices of `strings/all-unique.txt` ({len(lines)} unique entries) ",
           "into categories that surface application logic and structure ",
           "without needing decompilation.\n"]

    for cat, hits in buckets.items():
        out.append(f"## {cat}  ({len(hits)} hits)")
        out.append("")
        # sort + de-dupe; cap noisy categories
        seen = set()
        cap = 200 if cat == "Visible UI text (suspect)" else 500
        for s in sorted(hits):
            if s in seen:
                continue
            seen.add(s)
            out.append(f"```")
            out.append(s)
            out.append("```")
            if len(seen) >= cap:
                out.append(f"_... {len(hits) - cap} more truncated_")
                break
        out.append("")

    OUT.write_text("\n".join(out))
    print(f"  wrote {OUT}")


if __name__ == "__main__":
    main()
