"""End-to-end tests for the assessment workflow.

Each test gets a fresh per-test SQLite user DB via the `user_data_dir`
fixture in conftest, so tests don't leak state.
"""

from __future__ import annotations

from fastapi.testclient import TestClient


def test_create_list_get_assessment(client: TestClient) -> None:
    # Create
    resp = client.post(
        "/api/assessments",
        json={
            "name": "PMN-12345 cooling tower additive",
            "chemical_name": "ExampleChem",
            "cas_number": "999-99-9",
            "notes": "Test PMN",
        },
    )
    assert resp.status_code == 201, resp.text
    body = resp.json()
    aid = body["id"]
    assert body["name"] == "PMN-12345 cooling tower additive"
    assert body["operations"] == []

    # List
    resp = client.get("/api/assessments")
    assert resp.status_code == 200
    assert any(a["id"] == aid for a in resp.json())

    # Get one
    resp = client.get(f"/api/assessments/{aid}")
    assert resp.status_code == 200
    assert resp.json()["chemical_name"] == "ExampleChem"


def test_update_assessment(client: TestClient) -> None:
    aid = client.post("/api/assessments", json={"name": "before"}).json()["id"]
    resp = client.patch(f"/api/assessments/{aid}", json={"name": "after"})
    assert resp.status_code == 200
    assert resp.json()["name"] == "after"


def test_delete_assessment(client: TestClient) -> None:
    aid = client.post("/api/assessments", json={"name": "doomed"}).json()["id"]
    resp = client.delete(f"/api/assessments/{aid}")
    assert resp.status_code == 204
    assert client.get(f"/api/assessments/{aid}").status_code == 404


def test_get_missing_returns_404(client: TestClient) -> None:
    assert client.get("/api/assessments/9999").status_code == 404


def test_add_operation_with_activities(client: TestClient) -> None:
    aid = client.post("/api/assessments", json={"name": "cooling tower"}).json()["id"]
    resp = client.post(
        f"/api/assessments/{aid}/operations",
        json={
            "op_id": 103,
            "name": "Cooling Tower Use",
            "sort_order": 0,
            "activities": [{"act_id": 93, "name": "Cooling Tower Releases", "sort_order": 0}],
        },
    )
    assert resp.status_code == 201, resp.text
    op = resp.json()
    assert op["op_id"] == 103
    assert len(op["activities"]) == 1
    assert op["activities"][0]["act_id"] == 93

    # Confirm assessment GET shows it
    a = client.get(f"/api/assessments/{aid}").json()
    assert len(a["operations"]) == 1
    assert a["operations"][0]["activities"][0]["act_id"] == 93


def test_add_activity_to_existing_operation(client: TestClient) -> None:
    aid = client.post("/api/assessments", json={"name": "manuf"}).json()["id"]
    op_resp = client.post(
        f"/api/assessments/{aid}/operations",
        json={"op_id": 1, "name": "Manufacturing"},
    )
    op_id = op_resp.json()["id"]

    resp = client.post(
        f"/api/assessments/{aid}/operations/{op_id}/activities",
        json={"act_id": 1, "name": "Sampling Liquids"},
    )
    assert resp.status_code == 201, resp.text
    assert resp.json()["act_id"] == 1


def test_revisions_record_each_mutation(client: TestClient) -> None:
    aid = client.post("/api/assessments", json={"name": "with history"}).json()["id"]
    client.patch(f"/api/assessments/{aid}", json={"name": "renamed"})
    client.post(
        f"/api/assessments/{aid}/operations",
        json={"op_id": 2, "name": "Processing"},
    )

    revisions = client.get(f"/api/assessments/{aid}/revisions").json()
    assert len(revisions) == 3  # created, updated, added op
    summaries = [r["summary"] for r in revisions]
    assert "created" in summaries
    assert any("updated" in s for s in summaries)
    assert any("added operation" in s for s in summaries)


def test_delete_operation_cascades_activities(client: TestClient) -> None:
    aid = client.post("/api/assessments", json={"name": "with activities"}).json()["id"]
    op = client.post(
        f"/api/assessments/{aid}/operations",
        json={
            "op_id": 1,
            "activities": [
                {"act_id": 1, "name": "A1"},
                {"act_id": 2, "name": "A2"},
            ],
        },
    ).json()
    op_id = op["id"]

    resp = client.delete(f"/api/assessments/{aid}/operations/{op_id}")
    assert resp.status_code == 204
    a = client.get(f"/api/assessments/{aid}").json()
    assert a["operations"] == []
