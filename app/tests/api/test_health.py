from fastapi.testclient import TestClient


def test_health(client: TestClient) -> None:
    resp = client.get("/api/health")
    assert resp.status_code == 200
    body = resp.json()
    assert body["status"] == "ok"
    assert "version" in body


def test_root(client: TestClient) -> None:
    resp = client.get("/api/")
    assert resp.status_code == 200
    assert "hello from chemsteer" in resp.json()["message"]
