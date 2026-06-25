"""Chemical record, media partitioning, and mass-balance endpoints."""

from __future__ import annotations

from fastapi.testclient import TestClient


def _make_assessment(client: TestClient) -> int:
    r = client.post("/api/assessments", json={"name": "chem test"})
    assert r.status_code == 201, r.text
    return int(r.json()["id"])


# --- Chemical record -------------------------------------------------------


def test_chemical_record_roundtrip(client: TestClient) -> None:
    aid = _make_assessment(client)
    assert client.get(f"/api/assessments/{aid}/chemical").json() is None

    r = client.put(
        f"/api/assessments/{aid}/chemical",
        json={"mw": 72.1, "vp_torr": 10.0, "solubility_g_l": 2.5, "mol_formula": "C4H8O"},
    )
    assert r.status_code == 200, r.text
    rec = client.get(f"/api/assessments/{aid}/chemical").json()
    assert rec["mw"] == 72.1
    assert rec["vp_torr"] == 10.0
    assert rec["mol_formula"] == "C4H8O"

    # Upsert keeps the same row.
    r2 = client.put(f"/api/assessments/{aid}/chemical", json={"mw": 100.0})
    assert r2.json()["id"] == rec["id"]
    assert r2.json()["mw"] == 100.0
    assert r2.json()["vp_torr"] == 10.0  # unset fields untouched


def test_defaults_pull_from_chemical_record(client: TestClient) -> None:
    aid = _make_assessment(client)
    client.put(f"/api/assessments/{aid}/chemical", json={"mw": 72.1, "vp_torr": 10.0})

    # Mass Balance (#22): VP via the -3109 sentinel, MW via DefaultSource.
    d = client.get(f"/api/models/22/defaults?assessment_id={aid}").json()
    assert d["defaults"]["VP"] == 10.0
    assert d["defaults"]["MW"] == 72.1

    no_chem = client.get("/api/models/22/defaults").json()
    assert "VP" not in no_chem["defaults"]


def test_defaults_output_characterization(client: TestClient) -> None:
    ct = client.get("/api/models/2/defaults?output=0").json()
    he = client.get("/api/models/2/defaults?output=1").json()
    assert ct["defaults"]["LF"] == 0.025
    assert he["defaults"]["LF"] == 0.03


def test_defaults_include_media_for_release_models(client: TestClient) -> None:
    d = client.get("/api/models/41/defaults").json()
    assert d["media"] == {"0": 4.0, "8": 96.0}
    exp = client.get("/api/models/22/defaults").json()
    assert exp["media"] == {}


# --- Media reference + per-run splits --------------------------------------


def test_media_reference_list(client: TestClient) -> None:
    media = client.get("/api/reference/media").json()
    assert len(media) == 18
    assert media[0]["name"] == "Water"  # SortID 0
    by_id = {m["media_id"]: m["name"] for m in media}
    assert by_id[0] == "Air"
    assert by_id[11] == "Landfill"


def test_run_media_patch_and_validation(client: TestClient) -> None:
    aid = _make_assessment(client)
    scenarios = client.get("/api/scenarios").json()
    ctw = next(s for s in scenarios if "Cooling Tower" in (s["op_name"] or ""))
    r = client.post(
        f"/api/assessments/{aid}/operations/from-scenario",
        json={"scenario_id": ctw["scenario_id"]},
    )
    act = r.json()["operation"]["activities"][0]
    runs = client.get(f"/api/assessments/{aid}/activities/{act['id']}/runs").json()
    blowdown = next(run for run in runs if run["model_id"] == 12)

    # Instantiation seeded the MediaDefaults split (blowdown → Water).
    assert blowdown["media"] == {"13": 100.0}
    windage = next(run for run in runs if run["model_id"] == 13)
    assert windage["media"] == {"0": 100.0}  # windage → Air

    # Repartition: must total 100.
    bad = client.patch(
        f"/api/assessments/{aid}/runs/{blowdown['id']}",
        json={"media": {"13": 50.0, "0": 30.0}},
    )
    assert bad.status_code == 422
    ok = client.patch(
        f"/api/assessments/{aid}/runs/{blowdown['id']}",
        json={"media": {"13": 60.0, "11": 40.0}},
    )
    assert ok.status_code == 200, ok.text
    assert ok.json()["media"] == {"13": 60.0, "11": 40.0}

    # Media on an exposure run is rejected.
    a = client.get(f"/api/assessments/{aid}").json()
    op_id = a["operations"][0]["id"]
    act2 = client.post(
        f"/api/assessments/{aid}/operations/{op_id}/activities",
        json={"act_id": 1},
    ).json()
    exp_run = client.post(
        f"/api/assessments/{aid}/activities/{act2['id']}/runs",
        json={
            "activity_id": act2["id"],
            "model_id": 26,
            "model_kind": "exposure",
            "inputs": {
                "S": 1070,
                "Qu": 2.1,
                "Wf": 1,
                "FT": 1,
                "ED": 250,
                "Y": 40,
                "BW": 70,
                "AT": 40,
                "ATc": 70,
                "NWexp": 1,
                "NS": 1,
            },
        },
    ).json()
    rej = client.patch(
        f"/api/assessments/{aid}/runs/{exp_run['id']}",
        json={"media": {"0": 100.0}},
    )
    assert rej.status_code == 422


def test_report_release_summary_partitions_by_media(client: TestClient) -> None:
    aid = _make_assessment(client)
    scenarios = client.get("/api/scenarios").json()
    ctw = next(s for s in scenarios if "Cooling Tower" in (s["op_name"] or ""))
    r = client.post(
        f"/api/assessments/{aid}/operations/from-scenario",
        json={"scenario_id": ctw["scenario_id"]},
    )
    act = r.json()["operation"]["activities"][0]
    runs = client.get(f"/api/assessments/{aid}/activities/{act['id']}/runs").json()
    blowdown = next(run for run in runs if run["model_id"] == 12)
    client.patch(
        f"/api/assessments/{aid}/runs/{blowdown['id']}",
        json={
            "inputs": {**blowdown["inputs"], "NS": 1.0},
            "media": {"13": 60.0, "11": 40.0},
        },
    )
    client.post(f"/api/assessments/{aid}/calc")

    report = client.get(f"/api/assessments/{aid}/report.json").json()
    summary = report["release_summary"]
    water = next(row for row in summary if row["media"] == "Water")
    landfill = next(row for row in summary if row["media"] == "Landfill")
    # Scenario parm values carry v3.2 float32 precision; compare loosely.
    dr_total = 10900.8 * 0.006  # DRRchem × LFb
    assert abs(water["drr_kg_day"] - dr_total * 0.6) < 1e-3
    assert abs(landfill["drr_kg_day"] - dr_total * 0.4) < 1e-3

    # HTML report renders both new sections.
    client.put(f"/api/assessments/{aid}/chemical", json={"mw": 72.1, "vp_torr": 10.0})
    html = client.get(f"/api/assessments/{aid}/report.html").text
    assert "Environmental release summary" in html
    assert "Chemical properties" in html
    assert "3.9E+1" in html  # v3.2 2-sig-fig formatting of the 60 % water share


# --- Mass balance ----------------------------------------------------------


def test_mass_balance_endpoint(client: TestClient) -> None:
    r = client.post(
        "/api/calc/mass-balance",
        json={"pv_kg_yr": 500000, "NS": 2, "T": 250, "Yprod": 0.5},
    )
    assert r.status_code == 200, r.text
    body = r.json()
    assert body["DMOchem"] == 1000.0
    assert body["DMOprod"] == 2000.0
    assert "DMOchem" in body["derived"]


def test_mass_balance_endpoint_validation(client: TestClient) -> None:
    r = client.post("/api/calc/mass-balance", json={"pv_kg_yr": 1000, "NS": 1})
    assert r.status_code == 422
    od_too_big = client.post(
        "/api/calc/mass-balance",
        json={"pv_kg_yr": 1_000_000, "NS": 1, "DMOchem": 1000},
    )
    assert od_too_big.status_code == 422
    assert "365" in od_too_big.text
