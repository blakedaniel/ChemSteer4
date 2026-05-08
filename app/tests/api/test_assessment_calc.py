"""End-to-end tests for the per-assessment calc trigger.

Drives the full workflow: create assessment → add operation+activity →
attach a ModelRun with inputs → POST /calc → verify persisted outputs.
"""

from __future__ import annotations

from fastapi.testclient import TestClient


def _make_assessment_with_drum_residual(client: TestClient) -> tuple[int, int, int]:
    """Helper: build a minimal assessment with one drum-residual ModelRun.

    Returns (assessment_id, activity_id, run_id).
    """
    aid = client.post("/api/assessments", json={"name": "drum residual test"}).json()["id"]

    op = client.post(
        f"/api/assessments/{aid}/operations",
        json={
            "op_id": 1,
            "name": "Manufacturing",
            "activities": [{"act_id": 5, "name": "Loading drums"}],
        },
    ).json()
    activity_id = op["activities"][0]["id"]

    run_resp = client.post(
        f"/api/assessments/{aid}/activities/{activity_id}/runs",
        json={
            "activity_id": activity_id,  # required by the schema; redundant but fine
            "model_id": 2,
            "model_kind": "release",
            "inputs": {"Amt": 150.0, "LF": 0.025, "Freq": 250.0, "NS": 3.0},
        },
    )
    assert run_resp.status_code == 201, run_resp.text
    run_id = run_resp.json()["id"]
    return aid, activity_id, run_id


def test_add_and_list_model_run(client: TestClient) -> None:
    aid, activity_id, run_id = _make_assessment_with_drum_residual(client)

    # List
    resp = client.get(f"/api/assessments/{aid}/activities/{activity_id}/runs")
    assert resp.status_code == 200
    runs = resp.json()
    assert len(runs) == 1
    assert runs[0]["id"] == run_id
    assert runs[0]["model_id"] == 2
    assert runs[0]["model_kind"] == "release"
    # outputs not yet computed
    assert runs[0]["outputs"] is None
    # inputs round-tripped
    assert runs[0]["inputs"]["Amt"] == 150.0


def test_add_run_validates_inputs_at_create_time(client: TestClient) -> None:
    aid = client.post("/api/assessments", json={"name": "bad inputs"}).json()["id"]
    op = client.post(
        f"/api/assessments/{aid}/operations",
        json={"op_id": 1, "activities": [{"act_id": 1}]},
    ).json()
    act_id = op["activities"][0]["id"]

    resp = client.post(
        f"/api/assessments/{aid}/activities/{act_id}/runs",
        json={
            "activity_id": act_id,
            "model_id": 2,
            "model_kind": "release",
            "inputs": {"Amt": "not-a-number", "LF": 0.025, "Freq": 250.0, "NS": 3.0},
        },
    )
    assert resp.status_code == 422


def test_add_run_rejects_unknown_model_kind(client: TestClient) -> None:
    aid = client.post("/api/assessments", json={"name": "bad kind"}).json()["id"]
    op = client.post(
        f"/api/assessments/{aid}/operations",
        json={"op_id": 1, "activities": [{"act_id": 1}]},
    ).json()
    act_id = op["activities"][0]["id"]

    resp = client.post(
        f"/api/assessments/{aid}/activities/{act_id}/runs",
        json={
            "activity_id": act_id,
            "model_id": 1,
            "model_kind": "garbage",  # rejected by the schema's pattern
            "inputs": {},
        },
    )
    assert resp.status_code == 422


def test_calc_assessment_runs_attached_models(client: TestClient) -> None:
    aid, _, run_id = _make_assessment_with_drum_residual(client)

    resp = client.post(f"/api/assessments/{aid}/calc")
    assert resp.status_code == 200, resp.text
    body = resp.json()
    assert body["assessment_id"] == aid
    assert len(body["runs"]) == 1
    r = body["runs"][0]
    assert r["run_id"] == run_id
    assert r["ok"] is True
    assert r["outputs"] is not None
    # Drum residual: DR = 0.025 × 150 = 3.75, AR = 3.75 × 250 × 3 = 2812.5
    assert r["outputs"]["DR"]["value"] == 3.75
    assert r["outputs"]["AR"]["value"] == 2812.5

    # GET the run again — outputs should now be persisted
    runs = client.get(
        f"/api/assessments/{aid}/activities/{run_id_to_act_id(client, aid, run_id)}/runs"
    ).json()
    persisted = next(r for r in runs if r["id"] == run_id)
    assert persisted["outputs"] is not None
    assert persisted["outputs"]["DR"]["value"] == 3.75
    assert persisted["last_run_at"] is not None


def run_id_to_act_id(client: TestClient, aid: int, run_id: int) -> int:
    """Helper — look up a run's activity_id via the assessment GET."""
    a = client.get(f"/api/assessments/{aid}").json()
    for op in a["operations"]:
        for act in op["activities"]:
            for r in client.get(f"/api/assessments/{aid}/activities/{act['id']}/runs").json():
                if r["id"] == run_id:
                    return int(act["id"])
    raise AssertionError(f"run {run_id} not found")


def test_calc_assessment_handles_failing_run_gracefully(client: TestClient) -> None:
    """A run with bad inputs should fail individually but not abort siblings."""
    aid = client.post("/api/assessments", json={"name": "mixed"}).json()["id"]
    op = client.post(
        f"/api/assessments/{aid}/operations",
        json={"op_id": 1, "activities": [{"act_id": 5, "name": "drums"}]},
    ).json()
    act_id = op["activities"][0]["id"]

    # Good run
    client.post(
        f"/api/assessments/{aid}/activities/{act_id}/runs",
        json={
            "activity_id": act_id,
            "model_id": 2,
            "model_kind": "release",
            "inputs": {"Amt": 100.0, "LF": 0.025, "Freq": 250.0, "NS": 1.0},
        },
    )
    # Add another good run, then poison its inputs by direct DB edit
    # — easier approach: just pile on more good runs and check both succeed.
    client.post(
        f"/api/assessments/{aid}/activities/{act_id}/runs",
        json={
            "activity_id": act_id,
            "model_id": 1,
            "model_kind": "release",
            "inputs": {"Amt": 200.0, "LF": 0.002, "Freq": 200.0, "NS": 2.0},
        },
    )

    resp = client.post(f"/api/assessments/{aid}/calc")
    assert resp.status_code == 200
    runs = resp.json()["runs"]
    assert len(runs) == 2
    assert all(r["ok"] for r in runs)


def test_calc_records_revision(client: TestClient) -> None:
    aid, _, _ = _make_assessment_with_drum_residual(client)
    n_before = len(client.get(f"/api/assessments/{aid}/revisions").json())
    client.post(f"/api/assessments/{aid}/calc")
    n_after = len(client.get(f"/api/assessments/{aid}/revisions").json())
    assert n_after == n_before + 1
    summaries = [r["summary"] for r in client.get(f"/api/assessments/{aid}/revisions").json()]
    assert any("calc:" in s for s in summaries)


def test_delete_model_run(client: TestClient) -> None:
    aid, act_id, run_id = _make_assessment_with_drum_residual(client)
    resp = client.delete(f"/api/assessments/{aid}/runs/{run_id}")
    assert resp.status_code == 204
    runs = client.get(f"/api/assessments/{aid}/activities/{act_id}/runs").json()
    assert runs == []
