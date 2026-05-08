"""Pytest fixtures shared across unit / golden / property / api suites."""

from __future__ import annotations

from collections.abc import Iterator
from pathlib import Path

import pytest
from alembic import command
from alembic.config import Config
from fastapi.testclient import TestClient

from chemsteer.api.app import create_app


@pytest.fixture()
def user_data_dir(tmp_path: Path, monkeypatch: pytest.MonkeyPatch) -> Path:
    """Per-test isolated user-DB dir; runs Alembic migrations once."""
    monkeypatch.setenv("CHEMSTEER_USER_DATA_DIR", str(tmp_path))
    # Reset settings + DB caches that may have closed-over the old path.
    from chemsteer import settings
    from chemsteer.db import user

    user.get_user_engine.cache_clear()
    user._session_factory.cache_clear()
    settings.get_settings.cache_clear() if hasattr(settings.get_settings, "cache_clear") else None  # type: ignore[func-returns-value]

    cfg = Config(str(Path(__file__).resolve().parent.parent / "alembic.ini"))
    cfg.set_main_option("sqlalchemy.url", f"sqlite:///{tmp_path}/assessments.db")
    cfg.set_main_option(
        "script_location",
        str(Path(__file__).resolve().parent.parent / "src/chemsteer/db/migrations"),
    )
    command.upgrade(cfg, "head")
    return tmp_path


@pytest.fixture()
def client(user_data_dir: Path) -> Iterator[TestClient]:
    api = create_app()
    with TestClient(api) as c:
        yield c
