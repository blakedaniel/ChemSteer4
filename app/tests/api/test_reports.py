"""Tests for the reports endpoints (HTML/PDF/CSV/JSON)."""

from __future__ import annotations

from fastapi.testclient import TestClient


def _seed_assessment(client: TestClient) -> int:
    aid = client.post("/api/assessments", json={"name": "Reports test"}).json()["id"]
    op = client.post(
        f"/api/assessments/{aid}/operations",
        json={
            "op_id": 1,
            "name": "Manuf",
            "activities": [{"act_id": 5, "name": "Loading drums"}],
        },
    ).json()
    act_id = op["activities"][0]["id"]
    client.post(
        f"/api/assessments/{aid}/activities/{act_id}/runs",
        json={
            "activity_id": act_id,
            "model_id": 2,
            "model_kind": "release",
            "inputs": {"Amt": 150.0, "LF": 0.025, "Freq": 250.0, "NS": 3.0},
        },
    )
    client.post(f"/api/assessments/{aid}/calc")
    return aid


def test_report_json_round_trips_assessment(client: TestClient) -> None:
    aid = _seed_assessment(client)
    resp = client.get(f"/api/assessments/{aid}/report.json")
    assert resp.status_code == 200
    body = resp.json()
    assert body["assessment"]["id"] == aid
    assert body["assessment"]["name"] == "Reports test"
    assert len(body["operations"]) == 1
    assert body["operations"][0]["op_id"] == 1
    runs = body["operations"][0]["activities"][0]["runs"]
    assert len(runs) == 1
    assert runs[0]["outputs"]["DR"]["value"] == 3.75


def test_report_html_renders_with_outputs(client: TestClient) -> None:
    aid = _seed_assessment(client)
    resp = client.get(f"/api/assessments/{aid}/report.html")
    assert resp.status_code == 200
    text = resp.text
    assert "Reports test" in text
    assert "Operation #1" in text
    assert "Loading drums" in text
    # 3.75 rounded with %.4g
    assert "3.75" in text
    # Output section contains DR and AR fields
    assert "DR" in text
    assert "AR" in text


def test_report_csv_lists_runs(client: TestClient) -> None:
    aid = _seed_assessment(client)
    resp = client.get(f"/api/assessments/{aid}/report.csv")
    assert resp.status_code == 200
    rows = resp.text.strip().splitlines()
    assert "model_kind" in rows[0]
    assert "release" in rows[1]
    assert "DR" in rows[1]


def test_report_404_for_missing_assessment(client: TestClient) -> None:
    assert client.get("/api/assessments/9999/report.json").status_code == 404


def test_report_pdf_returns_pdf_bytes(client: TestClient) -> None:
    aid = _seed_assessment(client)
    resp = client.get(f"/api/assessments/{aid}/report.pdf")
    assert resp.status_code == 200
    assert resp.headers["content-type"] == "application/pdf"
    # PDF magic bytes
    assert resp.content[:5] == b"%PDF-"
    assert len(resp.content) > 1000  # at least a real PDF, not a stub
