"""API integration tests for POST /api/calc/release/{model_id}."""

from __future__ import annotations

from fastapi.testclient import TestClient


def test_post_drum_residual_with_raw_floats(client: TestClient) -> None:
    resp = client.post(
        "/api/calc/release/2",
        json={"Amt": 150.0, "LF": 0.025, "Freq": 250.0, "NS": 3.0},
    )
    assert resp.status_code == 200, resp.text
    body = resp.json()
    # Outputs serialize as {"value": float, "unit": str}
    assert body["DR"]["value"] == 3.75
    assert body["AR"]["value"] == 2812.5
    assert body["NS"]["value"] == 3.0


def test_post_drum_residual_with_unit_strings(client: TestClient) -> None:
    resp = client.post(
        "/api/calc/release/2",
        json={
            "Amt": "150 kilogram / (site * day)",
            "LF": "0.025 dimensionless",
            "Freq": "250 day / year",
            "NS": "3 site",
        },
    )
    assert resp.status_code == 200
    assert resp.json()["AR"]["value"] == 2812.5


def test_post_unknown_model_id_returns_404(client: TestClient) -> None:
    resp = client.post(
        "/api/calc/release/9999",
        json={"Amt": 1.0, "LF": 0.01, "Freq": 1.0, "NS": 1.0},
    )
    assert resp.status_code == 404


def test_post_invalid_input_returns_422(client: TestClient) -> None:
    resp = client.post(
        "/api/calc/release/2",
        json={"Amt": "not a number", "LF": 0.025, "Freq": 250.0, "NS": 3.0},
    )
    assert resp.status_code == 422
