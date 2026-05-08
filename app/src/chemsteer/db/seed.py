"""Read-only access to the bundled seed databases.

Three SQLite files ship under `chemsteer.seed_data/`:

  - `chmsteer.db`   — master reference (models, activities, parameters, NAICS,
                       PEL/REL chemical limits)
  - `scenarios.db`  — the 34 Generic Scenarios with attached activities,
                       models, and per-scenario parameter overrides
  - `mdbshell.db`   — the assessment template (schema only, mostly empty)

These are immutable application data; opened in `mode=ro` to enforce that.
"""

from __future__ import annotations

from collections.abc import Iterator
from contextlib import contextmanager
from functools import cache
from pathlib import Path
from typing import Literal

from sqlalchemy import Engine, create_engine
from sqlalchemy.orm import Session, sessionmaker

from chemsteer.settings import get_settings

SeedName = Literal["chmsteer", "scenarios", "mdbshell"]


def _seed_path(name: SeedName) -> Path:
    p = get_settings().seed_data_dir / f"{name}.db"
    if not p.exists():
        raise FileNotFoundError(
            f"missing seed database {p}; run `python scripts/build-seed-db.py` to (re)build it"
        )
    return p


@cache
def get_engine(name: SeedName) -> Engine:
    """Return a singleton read-only engine for the named seed DB."""
    p = _seed_path(name)
    # SQLite URI form lets us pin mode=ro
    url = f"sqlite:///file:{p}?mode=ro&uri=true"
    return create_engine(url, future=True, connect_args={"uri": True})


@cache
def _session_factory(name: SeedName) -> sessionmaker[Session]:
    return sessionmaker(bind=get_engine(name), expire_on_commit=False, future=True)


@contextmanager
def session(name: SeedName) -> Iterator[Session]:
    """Yield a read-only Session for one of the seed databases."""
    Sess = _session_factory(name)
    s = Sess()
    try:
        yield s
    finally:
        s.close()
