"""GET /api/models/{id}/defaults — v3.2 ParmDefaults mapped to input fields."""

from __future__ import annotations

from fastapi.testclient import TestClient


def test_dermal_defaults_prefill(client: TestClient) -> None:
    r = client.get("/api/models/26/defaults")
    assert r.status_code == 200, r.text
    body = r.json()
    assert body["model_kind"] == "exposure"
    assert set(body["fields"]) == {
        "S",
        "Qu",
        "Wf",
        "FT",
        "ED",
        "Y",
        "BW",
        "AT",
        "ATc",
        "NWexp",
        "NS",
    }
    d = body["defaults"]
    assert d["S"] == 1070.0  # model-specific (ParmDefaults ModelID=26)
    assert d["FT"] == 1.0  # global
    assert d["BW"] == 70.0  # v3.2 global body weight
    # Negative sentinel defaults (Qu, ED for this model) must not leak.
    assert "Qu" not in d
    assert "ED" not in d


def test_defaults_gss_context_beats_global(client: TestClient) -> None:
    """Operating days → Freq: global default 170, cooling-tower op (103) 360."""
    base = client.get("/api/models/12/defaults").json()["defaults"]
    ctw = client.get("/api/models/12/defaults?gss_id=103").json()["defaults"]
    assert base["Freq"] == 170.0
    assert ctw["Freq"] == 360.0


def test_defaults_404_and_400(client: TestClient) -> None:
    assert client.get("/api/models/99999/defaults").status_code == 404
