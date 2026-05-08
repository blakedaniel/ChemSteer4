# chemsteer (Python web app)

A Python web reimplementation of EPA's **ChemSTEER** (Chemical Screening Tool
for Exposures and Environmental Releases), built on the seed data and
specification artifacts extracted from ChemSTEER v3.2 (see `../MANIFEST.md`).

**Status:** Phase 0 — bootstrap.

## Quick start

```bash
# install python deps (uv-managed)
uv sync --all-extras

# build seed SQLite databases from extracted CSVs
uv run python scripts/build-seed-db.py

# run the API
uv run chemsteer serve
# → http://127.0.0.1:8000
```

Or with Docker:

```bash
docker compose -f compose.dev.yml up   # dev: --reload + Vite HMR
docker compose up                       # prod: single image
```

## Layout

See the build plan at `~/.claude/plans/ok-lets-put-a-wobbly-codd.md`.

```
src/chemsteer/        Python package (FastAPI + calc engine)
  api/                FastAPI app + routers + schemas
  calc/               Calc engine: 31 release + 52 exposure models
  db/                 SQLAlchemy models + Alembic migrations
  reports/            HTML / PDF / CSV / JSON exporters
  importers/          .cs2 file reader
  seed_data/          Bundled read-only SQLite databases
frontend/             React + Vite + TypeScript SPA
tests/                pytest (unit, golden-master, property-based, api)
docs/                 MkDocs Material site
```

## Provenance

The model registry, parameter defaults, and Generic Scenario data shipped
in `src/chemsteer/seed_data/` are derived from EPA ChemSTEER v3.2
(public domain, 17 USC §105). The hand-ported calculation functions in
`src/chemsteer/calc/` are MIT-licensed by the contributors here.

## Development

```bash
uv run pytest -q              # all tests
uv run ruff check .           # lint
uv run ruff format            # format
uv run mypy src               # type-check
uv run mkdocs serve           # docs preview
```
