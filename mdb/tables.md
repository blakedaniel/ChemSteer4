# Access database — table catalog

Per-DB index of every Access table dumped under `mdb/<db>/`.
Row counts are post-load (post-Python-pandas_access dump).

## `ChmSteer.epa`

| Table | Rows | Cols | Notes |
|---|---:|---:|---|
| `ActCats` | 90 | 2 | Activity categories (90 rows). |
| `Codes` | 92 | 4 | Generic enum table (92 rows). |
| `GssAutoSelectActs` | 16 | 4 | Auto-selected activities per Generic Scenario (16 rows). |
| `Instructions` | 50 | 3 | Per-model textual instructions / notes (50 rows). |
| `ListOfActCats` | 18 | 3 | Activity-category lookup (18 rows). |
| `ListOfActivities` | 72 | 13 | Activity registry. Each activity carries default models for release / inhalation / dermal — this is the data-driven model-selection backbone. |
| `ListOfAssStatus` | 10 | 3 | Assessment status codes. |
| `ListOfAssessTypes` | 15 | 4 | Assessment types (15 rows). |
| `ListOfChemStates` | 6 | 2 | Chemical states (volatile liquid, solid, etc.). |
| `ListOfMedia` | 18 | 3 | Release media (air, water, land, etc.) — 18 rows. |
| `ListOfModels` | 38 | 18 | Master model registry. ModelID + Type (R=release, I=inhalation, D=dermal). The `Equation` column is the equation in plain text — defaults, equations, and basis notes all live here. |
| `ListOfOperations` | 8 | 15 | Operation registry (8 rows). Operation = manufacturing / processing / use, etc. |
| `ListOfOptData` | 7 | 2 | Optional-data flags (7 rows). |
| `ListOfParms` | 161 | 32 | Parameter registry (161 rows). Defines every named parameter (e.g. MW, VP, LF) used in equations. |
| `ListOfPhyStates` | 6 | 2 | Physical states (S/L/G/...). |
| `ListOfValidActivities` | 4 | 2 | Operation→activity allowlist (4 rows). |
| `ListOfValidModels` | 298 | 2 | Many-to-many: which models are valid for each activity. 298 rows = the full activity-to-model option matrix. |
| `MediaDefaults` | 25 | 3 | Per-media default release values. |
| `Meta2Defaults` | 72 | 7 | Physico-chemical / meta defaults (72 rows). |
| `MostLikelyActs` | 31 | 3 | Operation→activity hint table (which activities are most likely for each operation). |
| `NAICS` | 1814 | 3 | NAICS industry codes (1814 rows) — used for OpNAICS lookups. |
| `ParmDefaults` | 249 | 6 | Per-parameter default values. The published 'Common Engineering Defaults' tables are reflected here. |
| `ParmLabelOverrides` | 22 | 4 | Per-context parameter label overrides. |
| `States` | 51 | 2 | US states (51 rows). |
| `pel_rel_twa` | 652 | 34 | OSHA PEL / NIOSH REL / TWA chemical limits (652 rows). Indexed by NumericCas. |

## `MDBShell.epa`

| Table | Rows | Cols | Notes |
|---|---:|---:|---|
| `ActContParms` | 0 | 6 | Containment / control-equipment parameters per activity (961 rows). |
| `ActExpModEst` | 0 | 20 | Per-activity exposure-model estimates (empty template). |
| `ActExpModParms` | 0 | 6 | Per-(activity, exposure model) parameter values (4864 rows). |
| `ActExpModels` | 0 | 36 | Per-activity exposure models (74 rows) — links activity to inhalation/dermal model. |
| `ActRelModMedia` | 0 | 6 | Release-media partitioning per (activity, release model) (149 rows). |
| `ActRelModParms` | 0 | 6 | Per-(activity, release model) parameter values (9346 rows). |
| `ActRelModels` | 0 | 31 | Per-activity release models (137 rows). |
| `Activities` | 0 | 15 | Per-scenario activities (159 rows in scenarios.epa) — what the workers actually do at each scenario site. |
| `Assessments` | 0 | 58 | User assessment records (empty template). |
| `Chemicals` | 0 | 37 | Per-assessment chemical records (empty template). |
| `Codes` | 90 | 4 | Generic enum table (92 rows). |
| `ContactRpts` | 0 | 12 | Contact-report metadata (empty template). |
| `GSSOptions` | 0 | 5 | Generic-Scenario options table (empty in v3.2). |
| `IrerRels` | 0 | 21 | IRER release records (empty template). |
| `ListOfAssStatus` | 10 | 3 | Assessment status codes. |
| `ListOfAssessTypes` | 15 | 4 | Assessment types (15 rows). |
| `ListOfChemStates` | 6 | 2 | Chemical states (volatile liquid, solid, etc.). |
| `ListOfModels` | 36 | 18 | Master model registry. ModelID + Type (R=release, I=inhalation, D=dermal). The `Equation` column is the equation in plain text — defaults, equations, and basis notes all live here. |
| `MSDS_ExpLimits` | 0 | 8 | MSDS exposure-limit overrides (empty template). |
| `OpNAICS` | 0 | 4 | Per-operation NAICS codes (empty in v3.2 scenarios.epa). |
| `OpParms` | 0 | 5 | Per-operation parameter values (4992 rows) — the scenario-specific overrides of ParmDefaults. |
| `OpRel` | 0 | 6 | Operation-level release rollups (empty template). |
| `OpSites` | 0 | 10 | Per-operation site records (empty template). |
| `Operations` | 0 | 34 | The Generic Scenarios themselves. In `scenarios.epa` this is 34 rows = the 34 GSs that ship with v3.2. |
| `RelGroups` | 0 | 6 | Release groups (empty template). |
| `RevisionHistory` | 0 | 14 | Per-assessment revision log (empty template). |
| `SAT` | 0 | 30 | Source-allocation table (empty template). |
| `States` | 57 | 2 | US states (51 rows). |
| `Tron` | 1 | 3 | Singleton config row (always 1 row). |

## `scenarios.epa`

| Table | Rows | Cols | Notes |
|---|---:|---:|---|
| `ActContParms` | 961 | 5 | Containment / control-equipment parameters per activity (961 rows). |
| `ActExpModParms` | 4864 | 6 | Per-(activity, exposure model) parameter values (4864 rows). |
| `ActExpModels` | 74 | 35 | Per-activity exposure models (74 rows) — links activity to inhalation/dermal model. |
| `ActRelModMedia` | 149 | 5 | Release-media partitioning per (activity, release model) (149 rows). |
| `ActRelModParms` | 9346 | 6 | Per-(activity, release model) parameter values (9346 rows). |
| `ActRelModels` | 137 | 30 | Per-activity release models (137 rows). |
| `Activities` | 159 | 14 | Per-scenario activities (159 rows in scenarios.epa) — what the workers actually do at each scenario site. |
| `GSSOptions` | 0 | 4 | Generic-Scenario options table (empty in v3.2). |
| `OpNAICS` | 0 | 3 | Per-operation NAICS codes (empty in v3.2 scenarios.epa). |
| `OpParms` | 4992 | 4 | Per-operation parameter values (4992 rows) — the scenario-specific overrides of ParmDefaults. |
| `Operations` | 34 | 33 | The Generic Scenarios themselves. In `scenarios.epa` this is 34 rows = the 34 GSs that ship with v3.2. |
