#!/usr/bin/env python3
"""
build-help-index.py — render help/topics.md cataloging the 32 PDFs that
ship with ChemSTEER under Help/.

For each PDF: pull the PDF's Title (or first-page text fallback), tag the
type (UserGuide / GenericScenario / CEBManual / Memo / Methodology /
Quick Start), and note whether it's referenced by any row in
scenarios.epa::Operations.GSS_PDF.
"""
from __future__ import annotations

import re
import sqlite3
import subprocess
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent
HELP_DIR = ROOT / "help"
SCENARIOS_DB = ROOT / "mdb/scenarios/scenarios.sqlite"
OUT = HELP_DIR / "topics.md"


def _pdfinfo(pdf: Path) -> dict[str, str]:
    try:
        out = subprocess.check_output(["pdfinfo", str(pdf)], text=True)
    except Exception:
        return {}
    info = {}
    for line in out.splitlines():
        if ":" in line:
            k, v = line.split(":", 1)
            info[k.strip()] = v.strip()
    return info


def _classify(name: str) -> str:
    n = name.lower()
    if n == "chemsteer.pdf":
        return "User Guide"
    if "quick_start" in n:
        return "Quick Start"
    if n.startswith("cebman"):
        return "Chem Eng Branch Manual chapter"
    if "memo" in n:
        return "Memo / policy note"
    if any(s in n for s in ("dermalexposure", "masstrancoeff", "dustmodel", "coolingtower", "relequipclean")):
        return "Methodology / model paper"
    return "Generic Scenario"


def _scenarios_using(stem: str, by_pdf: dict[str, list[str]]) -> list[str]:
    # GSS_PDF entries look like '\Help\Photoresist_Use_2010.pdf'
    return by_pdf.get(stem.lower(), [])


def main() -> None:
    con = sqlite3.connect(SCENARIOS_DB)
    cur = con.cursor()
    by_pdf: dict[str, list[str]] = {}
    for op_name, pdf_ref in cur.execute(
        "SELECT OpName, GSS_PDF FROM Operations "
        "WHERE GSS_PDF IS NOT NULL AND GSS_PDF != '';"
    ):
        if not pdf_ref:
            continue
        # strip leading \Help\ and lowercase for matching
        key = re.sub(r"^.*\\help\\", "", pdf_ref, flags=re.IGNORECASE).lower()
        by_pdf.setdefault(key, []).append(op_name)
    con.close()

    pdfs = sorted(HELP_DIR.glob("*.pdf"))
    out = ["# ChemSTEER bundled help PDFs\n",
           f"32 PDFs ship under `Help/` in the application install. ",
           "Cross-referenced with `scenarios.epa::Operations.GSS_PDF` to show ",
           "which Generic Scenarios cite each.\n",
           "| File | Type | Title (PDF metadata) | Pages | Referenced by N scenarios |",
           "|---|---|---|---:|---:|"]

    for pdf in pdfs:
        info = _pdfinfo(pdf)
        title = info.get("Title", "—") or "—"
        pages = info.get("Pages", "—")
        kind = _classify(pdf.name)
        scens = _scenarios_using(pdf.name, by_pdf)
        out.append(f"| `{pdf.name}` | {kind} | {title} | {pages} | {len(scens)} |")

    # Per-PDF detail with scenario list
    out.append("\n## Per-scenario references\n")
    for pdf in pdfs:
        scens = _scenarios_using(pdf.name, by_pdf)
        if not scens:
            continue
        out.append(f"### `{pdf.name}`")
        for s in scens:
            out.append(f"- {s}")
        out.append("")

    OUT.write_text("\n".join(out))
    print(f"wrote {OUT}")
    print(f"  {len(pdfs)} PDFs catalogued")
    print(f"  {sum(len(v) for v in by_pdf.values())} scenario references resolved")


if __name__ == "__main__":
    main()
