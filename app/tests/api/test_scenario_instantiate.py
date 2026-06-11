"""Generic Scenario detail + instantiation endpoints."""

from __future__ import annotations

from fastapi.testclient import TestClient


def _make_assessment(client: TestClient) -> int:
    r = client.post("/api/assessments", json={"name": "GS test"})
    assert r.status_code == 201, r.text
    return int(r.json()["id"])


def test_scenario_detail_has_activity_tree(client: TestClient) -> None:
    listing = client.get("/api/scenarios").json()
    assert len(listing) == 34
    sid = listing[0]["scenario_id"]

    r = client.get(f"/api/scenarios/{sid}")
    assert r.status_code == 200, r.text
    detail = r.json()
    assert detail["scenario_id"] == sid
    assert detail["activities"], "scenario should have at least one activity"
    act = detail["activities"][0]
    assert {"scen_act_id", "act_id", "name", "models"} <= set(act)
    for m in act["models"]:
        assert m["model_kind"] in ("release", "exposure")
        assert isinstance(m["implemented"], bool)
        assert m["output_labels"]


def test_scenario_detail_404(client: TestClient) -> None:
    assert client.get("/api/scenarios/999999").status_code == 404


def test_instantiate_cooling_tower_scenario(client: TestClient) -> None:
    """The cooling-tower GS (op 103) attaches no explicit model rows; the
    activity's default models (12 blowdown, 13 windage; 14 is -14 =
    suggested-but-off) come from the registry, with Amt derived as
    DRRchem = RRctw × Yctw × HD × Dctw × 60 and Freq from the GS's
    operating-days default (360). NS is user-input, exactly like v3.2 —
    fill it via PATCH and the calc must then succeed."""
    aid = _make_assessment(client)
    scenarios = client.get("/api/scenarios").json()
    ctw = next(s for s in scenarios if "Cooling Tower" in (s["op_name"] or ""))

    r = client.post(
        f"/api/assessments/{aid}/operations/from-scenario",
        json={"scenario_id": ctw["scenario_id"]},
    )
    assert r.status_code == 201, r.text
    body = r.json()
    assert body["n_activities"] == 1
    assert body["n_runs"] == 2  # blowdown + windage; evaporative is off by default

    op = body["operation"]
    act = op["activities"][0]
    runs = client.get(f"/api/assessments/{aid}/activities/{act['id']}/runs").json()
    assert {run["model_id"] for run in runs} == {12, 13}
    blowdown = next(run for run in runs if run["model_id"] == 12)
    # DRRchem = 2000 × 0.001 × 24 × 3.785 × 60 = 10,900.8 kg/site-day
    assert abs(blowdown["inputs"]["Amt"] - 10900.8) < 0.2
    assert abs(blowdown["inputs"]["LF"] - 0.006) < 1e-6
    assert blowdown["inputs"]["Freq"] == 360.0  # GS operating-days default
    assert "NS" not in blowdown["inputs"]  # user-to-fill, like v3.2

    # Complete the run (NS) and calculate.
    patched = client.patch(
        f"/api/assessments/{aid}/runs/{blowdown['id']}",
        json={"inputs": {**blowdown["inputs"], "NS": 1.0}},
    )
    assert patched.status_code == 200, patched.text

    calc = client.post(f"/api/assessments/{aid}/calc")
    assert calc.status_code == 200, calc.text
    results = {x["run_id"]: x for x in calc.json()["runs"]}
    done = results[blowdown["id"]]
    assert done["ok"], done
    dr = done["outputs"]["DR"]["value"]
    assert abs(dr - 10900.8 * 0.006) < 0.01
    # The windage run is still missing NS → surfaces as a per-run error.
    windage = next(run for run in runs if run["model_id"] == 13)
    assert not results[windage["id"]]["ok"]


def test_instantiate_unknown_scenario_404(client: TestClient) -> None:
    aid = _make_assessment(client)
    r = client.post(
        f"/api/assessments/{aid}/operations/from-scenario",
        json={"scenario_id": 999999},
    )
    assert r.status_code == 404


def test_instantiated_runs_have_labels_and_valid_inputs(client: TestClient) -> None:
    """Every instantiated run's inputs must be valid for its model class
    (field names, not raw ParmIDs)."""
    aid = _make_assessment(client)
    scenarios = client.get("/api/scenarios").json()
    sid = scenarios[0]["scenario_id"]
    r = client.post(
        f"/api/assessments/{aid}/operations/from-scenario",
        json={"scenario_id": sid},
    )
    assert r.status_code == 201, r.text

    a = client.get(f"/api/assessments/{aid}").json()
    op = a["operations"][0]
    runs_seen = 0
    for act in op["activities"]:
        runs = client.get(f"/api/assessments/{aid}/activities/{act['id']}/runs").json()
        for run in runs:
            runs_seen += 1
            assert "label" in run
            for key in run["inputs"]:
                assert not key.isdigit(), f"raw ParmID {key} leaked into inputs"
    assert runs_seen == r.json()["n_runs"]
