# chemsteer (Python web app)

A Python/FastAPI/React web reimplementation of EPA's
[ChemSTEER](https://www.epa.gov/tsca-screening-tools/chemsteer-chemical-screening-tool-exposures-and-environmental-releases)
(Chemical Screening Tool for Exposures and Environmental Releases),
built on the seed data and specification artifacts extracted from
ChemSTEER v3.2.

**Status: 1.0 ready** — all 38 models implemented (20 release + 18
exposure), full assessment workflow, multi-format reports, `.cs2`
v3.2 import. See [`VALIDATION.md`](VALIDATION.md) for the validation
strategy.

## Quick start

### Local (uv)

```bash
uv sync --all-extras
uv run python scripts/build-seed-db.py     # seed SQLite from extracted CSVs
uv run python scripts/build-docs.py        # generate model + parameter docs
uv run alembic upgrade head                # initialise user DB
uv run chemsteer serve                     # http://127.0.0.1:8000
```

Visit http://127.0.0.1:8000 once you've built the frontend (`cd
frontend && npm install && npm run build`), or use the dev compose
stack for hot-reload.

### Docker

```bash
docker compose up                          # prod (single image)
docker compose -f compose.dev.yml up       # dev w/ FastAPI --reload + Vite HMR
```

## Layout

```
src/chemsteer/        Python package (FastAPI + calc engine + reports)
  api/                FastAPI app, routers, Pydantic schemas
  calc/
    base.py             Quantity type aliases (Pint-aware)
    units.py            Pint UnitRegistry + custom counting units
    dispatch.py         ModelID → (input class, calc fn) registry
    release/            20 release-model families (residual, vapor-gen, …)
    exposure/           18 exposure-model families (dermal, KCk, mass-bal, …)
  db/                 SQLAlchemy models (read-only seed + user assessments)
  reports/            HTML / PDF / CSV / JSON exporters (Jinja2 + WeasyPrint)
  importers/          .cs2 v3.2 file reader (mdb-tools shell-out + ETL)
  seed_data/          Bundled SQLite seed databases (read-only)
frontend/             React + Vite + TypeScript SPA
tests/                pytest (unit, golden, property, api)
docs/                 MkDocs Material site (auto-generated model + param indexes)
```

## API

```
GET    /api/operations
GET    /api/activities
GET    /api/models[?type=R|I|D]          model registry (38 models)
GET    /api/models/{id}/defaults         v3.2 ParmDefaults mapped to input fields
GET    /api/models/{id}/valid-activities
GET    /api/parameters
GET    /api/scenarios                    34 Generic Scenarios
GET    /api/scenarios/{id}               GS template tree (activities + models)
GET    /api/reference/naics?q=           NAICS industry-code search (1,814 codes)
GET    /api/reference/exposure-limits?q= OSHA PEL / NIOSH REL limits (652 chemicals)

POST   /api/calc/release/{model_id}      direct calc
POST   /api/calc/exposure/{model_id}     direct calc

POST   /api/assessments
GET    /api/assessments
GET    /api/assessments/{id}
PATCH  /api/assessments/{id}
DELETE /api/assessments/{id}
POST   /api/assessments/{id}/operations
POST   /api/assessments/{id}/operations/from-scenario   instantiate a Generic Scenario
POST   /api/assessments/{id}/operations/{oid}/activities
POST   /api/assessments/{id}/activities/{aid}/runs
PATCH  /api/assessments/{id}/runs/{rid}  edit inputs / label
POST   /api/assessments/{id}/calc        run all attached models, persist outputs
GET    /api/assessments/{id}/revisions   audit trail
GET    /api/assessments/{id}/report.{html,pdf,csv,json}

POST   /api/imports/cs2                  upload a v3.2 .cs2 file
```

OpenAPI schema is at `/openapi.json`; interactive docs at `/docs`.

## Development

```bash
uv run pytest -q              # 132 tests (unit + property + api)
uv run ruff check .           # lint
uv run ruff format            # format
uv run mypy src               # strict type-check
uv run mkdocs serve           # docs preview at http://127.0.0.1:8000
```

API smoke tests live in `bruno/` (a [Bruno](https://www.usebruno.com/)
collection, 27 requests): start the server, then
`cd bruno && npx @usebruno/cli run --env local -r`. Playwright E2E tests
live in `frontend/e2e/` (`npm run e2e` with the dev stack up).

## Provenance

The model registry, parameter defaults, and Generic Scenario data
shipped in `src/chemsteer/seed_data/` are derived from EPA ChemSTEER
v3.2, which is in the public domain (17 USC §105). The hand-ported
calculation functions in `src/chemsteer/calc/` are MIT-licensed.

Cross-checked equations against:

- `mdb/ChmSteer/tables/ListOfModels.csv` (extracted from the v3.2 install)
- The decompiled VB.NET source under `decompilation/source/`
- EPA's Common Engineering Defaults document (740/B-25-005, Nov 2025)
- Barrett et al. 2023 (J Occup Environ Hyg 20:545–562) — open-access
  reproduction of all major equations
