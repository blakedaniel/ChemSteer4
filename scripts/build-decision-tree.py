#!/usr/bin/env python3
"""
build-decision-tree.py — render decompilation/model-selection.md.

The model-selection logic in ChemSTEER is **data-driven**:
  Operation type        (8 rows in ChmSteer.ListOfOperations)
    -> Activity         (72 rows in ChmSteer.ListOfActivities, joined via
                         ListOfValidActivities by OpID)
       -> Default models (each Activity row carries DefaultRelModel /
                          DefaultInhModel / DefaultDrmModel)
       -> Valid model options (ListOfValidModels: many-to-many ActID→ModelID,
                               298 rows)
       -> Final equations (ListOfModels.Equation: stored as plain text)

This script renders that tree directly from ChmSteer.sqlite.
"""
from __future__ import annotations

import sqlite3
from pathlib import Path

ROOT = Path(__file__).resolve().parent.parent
CHM = ROOT / "mdb/ChmSteer/ChmSteer.sqlite"
OUT = ROOT / "decompilation/model-selection.md"


def main() -> None:
    con = sqlite3.connect(CHM)
    con.row_factory = sqlite3.Row
    cur = con.cursor()

    # Resolve model names by ID
    models = {
        int(r["ModelID"]): {"name": r["ModelName"], "type": r["Type"]}
        for r in cur.execute(
            "SELECT ModelID, ModelName, Type FROM ListOfModels WHERE ModelID GLOB '[0-9]*';"
        )
    }

    out = ["# Model-selection decision tree\n",
           "ChemSTEER's model-selection logic is encoded as **data**, not as ",
           "compiled branching. The tree below is rendered directly from ",
           "`ChmSteer.epa::ListOfActivities` joined with `ListOfValidModels` ",
           "and `ListOfModels`.\n",
           "Negative `Default*Model` IDs are sentinels (the app treats them ",
           "as 'use the global default for this category'); positive IDs ",
           "reference `ListOfModels.ModelID` directly.\n",
           "Source files implementing the dispatch (per cross-ref.md):\n",
           "- `frmSelectEasyModel.cs`, `frmModelsToBeRun.cs` — model picker UI",
           "- `frmMDAddRelModel.cs`, `frmMDAddExpModel.cs` — add-model dialogs",
           "- `RelModels.cs`, `ExpModels.cs` — per-model calculation routines",
           "- `DBFuncs.cs` — DB queries that pull the activity/model rows\n",
           "## By operation\n"]

    ops = list(cur.execute(
        "SELECT OpID, OpName, OpType FROM ListOfOperations ORDER BY CAST(OpID AS INTEGER);"
    ))

    for op in ops:
        op_id = int(op["OpID"]) if str(op["OpID"]).strip().isdigit() else op["OpID"]
        out.append(f"### Operation {op_id}: {op['OpName']}  (type `{op['OpType']}`)")
        out.append("")

        # Allowed activities for this operation
        acts = list(cur.execute(
            "SELECT a.ActID, a.ActName, a.RelActivity, a.ExpActivity, "
            "       a.DefaultRelModel, a.DefaultRelModel2, a.DefaultRelModel3, "
            "       a.DefaultInhModel, a.DefaultDrmModel "
            "FROM ListOfValidActivities v "
            "JOIN ListOfActivities a ON CAST(v.ActID AS INTEGER) = CAST(a.ActID AS INTEGER) "
            "WHERE CAST(v.OpID AS INTEGER) = ? "
            "ORDER BY CAST(a.ActID AS INTEGER);",
            (op_id,)
        ))
        if not acts:
            out.append("_(no activities allowed for this operation type — handled at runtime)_\n")
            continue

        for a in acts:
            aid = int(a["ActID"])
            out.append(f"- **Activity {aid}**: {a['ActName']}")

            # Defaults
            for label, key in (
                ("Default release model",     "DefaultRelModel"),
                ("Default release model 2",   "DefaultRelModel2"),
                ("Default release model 3",   "DefaultRelModel3"),
                ("Default inhalation model",  "DefaultInhModel"),
                ("Default dermal model",      "DefaultDrmModel"),
            ):
                val = a[key]
                if val is None or val == "" or val == "0":
                    continue
                try:
                    iv = int(val)
                except Exception:
                    out.append(f"    - {label}: `{val}`")
                    continue
                if iv == 0:
                    continue
                m = models.get(abs(iv))
                if m:
                    sign = "(global)" if iv < 0 else ""
                    out.append(f"    - {label}: `#{iv}` → {m['name']} {sign}")
                else:
                    out.append(f"    - {label}: `#{iv}` (unresolved)")

            # All valid model options for this activity
            valid = list(cur.execute(
                "SELECT ModelID FROM ListOfValidModels "
                "WHERE CAST(ActID AS INTEGER) = ? "
                "ORDER BY CAST(ModelID AS INTEGER);",
                (aid,)
            ))
            if valid:
                names = []
                for v in valid:
                    try:
                        mid = int(v["ModelID"])
                    except Exception:
                        continue
                    m = models.get(mid)
                    if m:
                        names.append(f"#{mid} ({m['type']}) {m['name']}")
                if names:
                    out.append(f"    - Valid model options ({len(names)}):")
                    for n in names:
                        out.append(f"      - {n}")

        out.append("")

    OUT.write_text("\n".join(out))
    con.close()
    print(f"  wrote {OUT}")


if __name__ == "__main__":
    main()
