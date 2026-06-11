"""NAICS + PEL/REL reference lookup endpoints."""

from __future__ import annotations

from fastapi.testclient import TestClient


def test_naics_search_by_prefix(client: TestClient) -> None:
    r = client.get("/api/reference/naics", params={"q": "325"})
    assert r.status_code == 200
    rows = r.json()
    assert rows
    assert all(row["code"].startswith("325") or "325" in (row["description"] or "") for row in rows)
    # Chemical manufacturing should be in there.
    assert any("Chemical" in (row["description"] or "") for row in rows)


def test_naics_unfiltered_is_limited(client: TestClient) -> None:
    rows = client.get("/api/reference/naics").json()
    assert len(rows) == 50  # default limit, not all 1814


def test_exposure_limits_by_name(client: TestClient) -> None:
    r = client.get("/api/reference/exposure-limits", params={"q": "LINDANE"})
    assert r.status_code == 200
    rows = r.json()
    assert rows
    lindane = rows[0]
    assert lindane["cas_number"] == "58-89-9"
    assert lindane["pel_twa_mgm3"] == 0.5
    assert lindane["rel_twa_mgm3"] == 0.5


def test_exposure_limits_by_cas(client: TestClient) -> None:
    rows = client.get("/api/reference/exposure-limits", params={"q": "60-29-7"}).json()
    assert len(rows) == 1
    assert rows[0]["chemical_name"] == "ETHYL ETHER"
    assert rows[0]["pel_twa_ppm"] == 400.0
