# Architecture

See the build plan for the canonical version. Brief recap:

```
React SPA  ─►  FastAPI  ─►  SQLAlchemy  ─►  SQLite
                  │
                  └──►  Calc engine (Pint-aware)
```

- **Seed data** (model registry, parameter defaults, NAICS, PEL/REL
  reference): bundled SQLite, read-only, derived from ChemSTEER v3.2's
  Access databases via `scripts/build-seed-db.py`.
- **User assessments**: separate SQLite at `~/.chemsteer-py/assessments.db`,
  schema-managed by Alembic.
- **Calc engine**: 31 release + 52 exposure functions, hand-ported
  from `decompilation/source/ChemSteer/{RelModels,ExpModels}.cs`.
