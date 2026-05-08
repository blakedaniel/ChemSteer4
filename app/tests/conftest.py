"""Pytest fixtures shared across unit / golden / property / api suites."""

from __future__ import annotations

from collections.abc import Iterator

import pytest
from fastapi.testclient import TestClient

from chemsteer.api.app import create_app


@pytest.fixture()
def client() -> Iterator[TestClient]:
    api = create_app()
    with TestClient(api) as c:
        yield c
