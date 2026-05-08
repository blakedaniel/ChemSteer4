# Changelog

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
