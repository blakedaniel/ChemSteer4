# Changelog

## 1.2.0 — 2026-06-25

Closes the largest remaining parity gaps against v3.2: the per-assessment
chemical record (and the defaults sentinels that read it), the
operation-level mass-balance solver, release-media partitioning, and an
IRER-shaped report.

### Added
- **Per-assessment chemical record** — `GET`/`PUT
  /api/assessments/{id}/chemical` stores MW, vapor pressure (torr),
  density (kg/L), water solubility (g/L), measurement temperatures,
  melting/boiling points, production volume, and physical state, in
  v3.2's standard units (the binary reads them raw into formulas).
  Mirrors v3.2's `Chemicals` table + `frmMDUpdChem`.
- **Chemical-record defaults sentinels.** `defaults_for` now resolves
  v3.2's *second-level* negative `ParmDefaults` sentinels
  (`GetParmDefaults.cs`): the chemical-record pulls (-3108/-3109 → VP,
  plus MW/WSchem via `ListOfParms.DefaultSource` -1102/-1104) and the
  per-output-characterization loss-fraction / mixing-factor constants
  (-3106, -3110…-3115, -3128). `GET /api/models/{id}/defaults` gained
  `output=` (Central Tendency / High End) and `assessment_id=` (pull the
  chemical record) parameters.
- **Operation mass-balance solver** — `POST /api/calc/mass-balance`
  ports `frmMDUpdOpIP.CalcRest`: solves `PV = NS · T · DMOchem` (with
  `DMOchem = Yprod · DMOprod`) for the unknowns from any three knowns,
  with the original's rounding (`MyRoundIt` round(x+0.1)/floor-1,
  `MassBalanceRoundUp` ceiling), the ≥5 % discrepancy warnings, and the
  OD > 365 / Yprod ∉ (0,1] validity checks. New collapsible panel on the
  assessment page.
- **Release-media partitioning** — model runs carry a `{MediaID: pct}`
  split (`ActRelModMedia`); Generic-Scenario instantiation seeds it from
  the scenario's media rows or the model's `MediaDefaults`. `PATCH
  …/runs/{id}` accepts a `media` map (must total 100 %, release runs
  only); `GET /api/reference/media` lists the 18 categories. Per-run
  media editor in the UI.
- **IRER-shaped report** — the report payload (and HTML/PDF) gained a
  **Chemical properties** section and an **Environmental release
  summary** that partitions each run's daily/annual release across media
  (`DRR_media = DR × pct/100`) and sums across an operation's activities
  per (medium, characterization), like the v3.2 `IrerRels` build. Release
  rates render in v3.2's two-significant-figure scientific notation
  (`ShowInSciNot1digit`).
- **Alembic migration `9f4b6a02c7d1`** — `chemical_records` table +
  `model_runs.media_json` (run `alembic upgrade head`).
- 8 new Bruno requests (32 total), 3 new Playwright specs (12 E2E
  total), 28 new pytest cases (160 total).

## 1.1.0 — 2026-06-11

Fidelity fixes verified against the decompiled v3.2 binary, plus the
Generic-Scenario workflow that was deferred from 1.0.

### Fixed (numerical fidelity)
- **Mass Balance (#22): Q is ft³/min, not m³/hr.** The 1.7×10⁵ constant
  is derived for Q in ft³/min (`ExpModels.cs:388`; ParmID 53 std units);
  converting Q to m³/hr understated Cv by 1.699×. Bare-float Q now means
  ft³/min, matching v3.2 and the User Guide default (3000 ft³/min).
- **Penetration (#9) / Mass Transfer (#8): vz is ft/min, not cm/s.**
  Same class of bug (`RelModels.cs:572,662`; ParmID 69 std units); the
  8.24e-8 / 1.93e-7 constants expect ft/min.
- **`.cs2` import produced uncalculable runs.** Parameter rows are keyed
  by numeric ParmID in v3.2; the importer stored `{"111": 0.0}`-style
  inputs that could never validate against the calc input classes. A new
  ParmID → field translation layer (`calc/parm_map.py`, with per-model
  overrides for the cooling-tower models and unit conversions where v3.2
  std units differ) fixes import end-to-end.

### Added
- **Generic Scenario instantiation** — the original's core workflow.
  `POST /api/assessments/{id}/operations/from-scenario` materializes one
  of the 34 GS templates: operation + activities + model runs with
  parameters resolved exactly like v3.2's "calculate defaults" flow
  (ParmDefaults < GS op-level parms < per-model/output rows), including
  the DRRchem derivation for cooling towers, default-model fallback from
  the activity registry (negative IDs = suggested-but-off), and one run
  per enabled output characterization (label = "Central Tendency" /
  "High End"). `GET /api/scenarios/{id}` returns the template tree.
- **Parameter defaults endpoint** — `GET /api/models/{id}/defaults`
  (+ `act_id`/`gss_id` context) resolves v3.2's 249-row ParmDefaults
  with GSS > activity > model > global precedence; the frontend
  pre-fills the add-run form from it, like the original's dialogs.
- **Run editing** — `PATCH /api/assessments/{id}/runs/{run_id}` updates
  inputs/label (clears stale outputs); inline editor in the UI.
- **Reference lookups** — `GET /api/reference/naics` (1,814 codes) and
  `GET /api/reference/exposure-limits` (652 chemicals, OSHA PEL / NIOSH
  REL); new Reference page with both searches.
- **`.cs2` upload UI** on the assessments page.
- **`ModelRun.label`** column (Alembic migration `7c3a91d2b4e8` — run
  `alembic upgrade head`).
- **Bruno API collection** (`bruno/`, 27 requests) covering every
  endpoint; run with `npx @usebruno/cli run --env local -r`.
- 5 new Playwright E2E tests (24 total), 19 new pytest cases (132 total).

## 1.0.0 — 2026-05-08

Initial release. Full feature parity with the rebuild plan:

### Backend
- **Calc engine: 38/38 models** ported from ChemSTEER v3.2
  - 20 release: bulk transport / drum / multi-vessel / single-vessel /
    small container / solid-transport residuals; AP-42 loading; mass
    transfer coefficient; penetration; cooling tower
    blowdown/windage/evaporative; user-defined loss rate; auto refinish
    + OEM overspray; water saturation; user-defined vapor generation;
    electroplating spent-bath + rinse-water; solids-transfer dust.
  - 18 exposure: 1-hand/2-hand/immersion/solids/container-solids dermal +
    user-defined; UV roll coating; small-volume handling; mass balance;
    OSHA PEL substance-specific particulates / total PNOR / respirable
    PNOR / vapor; auto spray polyiso; user-defined inhalation; auto OEM
    + refinish spray; near-field/far-field two-zone box.
- Pint-aware unit-safe arithmetic.
- FastAPI REST surface for the registry, direct calc, full CRUD on
  assessments + nested operations / activities / model runs, per-
  assessment calc trigger, revision history, and four-format reports.
- `.cs2` v3.2 import via `mdb-tools` shell-out + ETL.
- Alembic migrations for the user DB.

### Frontend
- React + Vite + TypeScript SPA with TanStack Query.
- Browse pages for the registry (operations, activities, models,
  parameters, generic scenarios).
- Full assessment editor: list, create, detail with inline operation /
  activity / model-run editors, calc trigger, results table, revision
  sidebar, and HTML/PDF/CSV/JSON export buttons.

### Quality
- 113 tests (unit, property-based via Hypothesis, API integration,
  PDF magic-bytes verification, full coverage assertions).
- Ruff + Ruff format + mypy strict on every commit.
- GitHub Actions CI builds the wheel + frontend + Docker image.
- MkDocs Material site with auto-generated model and parameter
  indexes.

### Out of scope (deferred)
- Golden-master capture against ChemSTEER v3.2 (Wine/VM project; see
  `VALIDATION.md`).
- 34 Generic Scenarios as preconfigured assessment templates (data
  is in `scenarios.db`; UI wizard pending).
- Bidirectional `.cs2` round-trip (import only for v1.0).
