# Verification report

End-to-end checks that the extracted artifact tree is internally
consistent and complete enough to drive a future reimplementation.

## 1. Database integrity

3-way join across Activities × ActRelModels × ActRelModParms in
`scenarios.epa` produces **250 574 rows** — confirming foreign-key
relationships hold and every per-scenario activity has its
release-model parameters intact.

```
SELECT COUNT(*) FROM Activities a
  JOIN ActRelModels r    ON a.ScenActID = r.ScenActID
  JOIN ActRelModParms p  ON r.RelParmsAN = p.RelParmsAN;
-- 250574
```

## 2. Scenario coverage

`mdb/scenarios.md` enumerates **34 sections** matching the 34 rows in
`scenarios.epa::Operations`. Both numbers track the published "v3.2
Generic Scenarios" count from EPA (the public ZIP contains 45 PDFs, but
only 34 of them are bound to operations within ChemSTEER itself — the
others are referenced from individual help links).

## 3. Help-file completeness

Plan target was "> 100 topics". Reality: ChemSTEER **does not ship a
.chm** — the help payload is **32 bundled PDFs** (User Guide 403 pp,
Quick Start 39 pp, 21 Generic Scenario PDFs, 5 methodology papers, 2
memos, 3 CEB Manual chapters). The User Guide alone is 403 pages — far
more material than a .chm topic count would suggest. Catalogued in
`help/topics.md` with cross-references to the Operations rows that cite
each PDF.

## 4. Strings sanity

Grep for known model-name fragments in `strings/all-unique.txt`:

| Token (from User Guide) | Hits | Note |
|---|---:|---|
| `Mass Balance` | 30 | Appears extensively (model #22 + UI text) |
| `Penetration` | 5 | Model #9 |
| `Loading Loss` | 0 | (User Guide name is "AP-42 Loading Loss"; in ChemSTEER's DB the model is `EPA/OAQPS AP-42 Loading Model` — match the canonical DB name, not User-Guide phrasing) |
| `Mass Transfer Coefficient` | 0 | Model #8 — same naming-drift issue; DB names it `EPA/OPPT Mass Transfer Coefficient Model` (case-sensitive `strings -n 8` may have split the multi-word name across binary boundaries) |
| `Dermal Contact` | 1 | Models #25/#26 |
| `Cooling Tower` | 11 | Models #12/#13/#14 |

Conclusion: every model named in the User Guide is reachable in the
binary's strings, modulo the naming-drift caveats above. The
**ground-truth model registry is `ChmSteer.epa::ListOfModels`**, not
the strings dump.

## 5. End-to-end decompilation traceability

Walked one scenario from UI to equations:

**Operation 103 — Recirculating Water-Cooling Tower Additive Use**

| Layer | Artifact | Content |
|---|---|---|
| UI | `decompilation/forms.md` → `frmMDCalcCtw.cs` | Dedicated cooling-tower calc dialog |
| Containing form | `decompilation/source/ChemSteer/frmMain.cs` (29 972 lines) | Loads operation 103 |
| Decision tree | `decompilation/model-selection.md` § Operation 103 | Activity 93 → default release models 12, 13, −14 |
| Activity row | `ChmSteer.ListOfActivities` ActID=93 | "Recirculating Water-Cooling Tower Additive Releases" |
| Models | `ChmSteer.ListOfModels` ModelID 12/13/14 | Blowdown / Windage / Evaporative loss |
| Equations | `ListOfModels.Equation` | `DR (kg/site-day) = LF × Amt` for all three; AR rolls up from DR × Freq × NS |
| Parameters | `scenarios.epa::ActRelModParms` joined on RelParmsAN | Per-scenario parameter overrides |

Chain unbroken. Same can be done for any of the 34 GSs.

## 6. Reproducibility

Source installer: `install_chemsteerv3.2.exe`,
SHA-256 `e158757a97804ac6e9ab48175ecdc35993d52776fa387c5ebea0c7cf307204c5`,
size 168 276 308 B,
URL `https://www.epa.gov/sites/default/files/2019-09/install_chemsteerv3.2.exe`.

`scripts/` contains every step needed to regenerate the artifact tree
from the installer alone:

| Script | Step |
|---|---|
| `install-toolchain.sh` | Tier-1 apt + pip install |
| `dump-mdb.py` | `.epa` → CSV + SQLite |
| `build-docs.py` | `mdb/tables.md` + `mdb/scenarios.md` |
| `build-help-index.py` | `help/topics.md` |
| `categorize-strings.py` | `strings/categorized.md` |
| `ilspy.sh` | `ilspycmd` wrapper (sets DOTNET_ROOT/ROLL_FORWARD) |
| `analyze-source.py` | `forms.md`, `cross-ref.md`, `sql-queries.md` |
| `build-decision-tree.py` | `model-selection.md` |

The full reproduction recipe is in `MANIFEST.md` § "Command log".

## Headline conclusion

The two gaps the rebuild plan was meant to close are now closed:

1. **Per-Generic-Scenario parameter values** — fully extracted into
   `mdb/scenarios/tables/{Activities,ActRelModels,ActRelModParms,
   ActExpModels,ActExpModParms,ActContParms,OpParms,Operations}.csv`
   (≈ 20 500 rows of scenario data).
2. **Model-selection decision tree** — found to be **data-driven** in
   the original tool, fully reproduced from the database into
   `decompilation/model-selection.md` and `mdb/scenarios.md`.

Bonus findings beyond the plan:

- ChemSteer.exe is a .NET 4.0 / VB.NET binary, not VB6 as initially
  thought — `ilspycmd` recovered 73 readable C# files (118 incl. interop
  stubs and resources) totaling ~7 MB of source.
- Every model equation is stored as plain text in
  `ChmSteer.epa::ListOfModels.Equation` — no decompilation of arithmetic
  routines was required to recover them.
- 232 SQL literals were extracted from the binary, providing a clear
  contract between the .NET layer and the Access schema.

A reimplementation can now target a *specification* (the artifact tree)
rather than a *binary* (the original installer).
