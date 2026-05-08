"""Read-only endpoint smoke tests against the bundled seed data."""

from __future__ import annotations

from fastapi.testclient import TestClient


def test_list_operations_has_8_rows(client: TestClient) -> None:
    resp = client.get("/api/operations")
    assert resp.status_code == 200
    rows = resp.json()
    assert len(rows) == 8
    assert any(r["op_name"] == "User-defined Manufacturing" for r in rows)


def test_get_one_operation(client: TestClient) -> None:
    resp = client.get("/api/operations/1")
    assert resp.status_code == 200
    body = resp.json()
    assert body["op_id"] == 1
    assert body["op_type"] == "M"


def test_get_missing_operation_404(client: TestClient) -> None:
    resp = client.get("/api/operations/999")
    assert resp.status_code == 404


def test_list_activities_has_72_rows(client: TestClient) -> None:
    resp = client.get("/api/activities")
    assert resp.status_code == 200
    rows = resp.json()
    assert len(rows) == 72


def test_activity_with_default_models(client: TestClient) -> None:
    # Activity 93 (Recirculating Water-Cooling Tower Additive Releases) has
    # default release models 12, 13, -14 per the model-selection extract.
    resp = client.get("/api/activities/93")
    assert resp.status_code == 200
    body = resp.json()
    assert body["act_id"] == 93
    assert body["default_rel_model"] == 12
    assert body["default_rel_model_2"] == 13
    assert body["default_rel_model_3"] == -14


def test_list_models_full(client: TestClient) -> None:
    resp = client.get("/api/models")
    assert resp.status_code == 200
    rows = resp.json()
    assert len(rows) == 38


def test_filter_models_by_type_dermal(client: TestClient) -> None:
    resp = client.get("/api/models?type=D")
    assert resp.status_code == 200
    rows = resp.json()
    assert len(rows) >= 3
    assert all(r["type"] == "D" for r in rows)


def test_get_model_includes_equation(client: TestClient) -> None:
    # Mass Balance Inhalation Model = #22; equation should mention "Cm"
    resp = client.get("/api/models/22")
    assert resp.status_code == 200
    body = resp.json()
    assert body["model_id"] == 22
    assert "Cm" in (body["equation"] or "")


def test_model_valid_activities(client: TestClient) -> None:
    # AP-42 Loading Model (#7) is enumerated as a user-pickable option
    # for activities 3 and 4 (loading liquid product into bottles / small
    # containers) in ListOfValidModels.
    resp = client.get("/api/models/7/valid-activities")
    assert resp.status_code == 200
    activities = resp.json()
    assert 3 in activities
    assert 4 in activities


def test_model_with_no_valid_activities_returns_empty_list(client: TestClient) -> None:
    # Model #12 (Cooling Tower Blowdown) is only reachable as a default
    # attachment to a GS-bound activity; it isn't in ListOfValidModels.
    resp = client.get("/api/models/12/valid-activities")
    assert resp.status_code == 200
    assert resp.json() == []


def test_list_parameters(client: TestClient) -> None:
    resp = client.get("/api/parameters")
    assert resp.status_code == 200
    rows = resp.json()
    assert len(rows) >= 150
    # Vapor Pressure should be present and have "torr" as StdUnits
    vp = next((r for r in rows if r["abbr"] == "VP"), None)
    assert vp is not None
    assert vp["std_units"] == "torr"


def test_list_scenarios_has_34_rows(client: TestClient) -> None:
    resp = client.get("/api/scenarios")
    assert resp.status_code == 200
    rows = resp.json()
    assert len(rows) == 34
