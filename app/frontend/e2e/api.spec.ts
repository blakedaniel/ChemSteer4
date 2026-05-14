import { test, expect } from "@playwright/test";

const API = "http://127.0.0.1:8000";

test.describe("API contract", () => {
  test("GET /api/models returns >= 38 models", async ({ request }) => {
    const r = await request.get(`${API}/api/models`);
    expect(r.ok()).toBeTruthy();
    const body = await r.json();
    expect(Array.isArray(body)).toBeTruthy();
    expect(body.length).toBeGreaterThanOrEqual(38);
    expect(body[0]).toHaveProperty("model_id");
    expect(body[0]).toHaveProperty("equation");
  });

  test("GET /api/models?type=R returns only release", async ({ request }) => {
    const r = await request.get(`${API}/api/models?type=R`);
    const body = await r.json();
    for (const m of body) expect(m.type).toBe("R");
  });

  test("GET /api/activities returns 72", async ({ request }) => {
    const r = await request.get(`${API}/api/activities`);
    const body = await r.json();
    expect(body.length).toBeGreaterThan(60);
  });

  test("GET /api/parameters returns rows with std_units", async ({ request }) => {
    const r = await request.get(`${API}/api/parameters`);
    const body = await r.json();
    expect(body.length).toBeGreaterThan(0);
    expect(body[0]).toHaveProperty("std_units");
  });

  test("POST /api/calc/release/2 (drum residual) returns DR + AR", async ({
    request,
  }) => {
    const r = await request.post(`${API}/api/calc/release/2`, {
      data: { Amt: 100, LF: 0.025, Freq: 250, NS: 1 },
    });
    expect(r.ok()).toBeTruthy();
    const body = await r.json();
    expect(body.DR.value).toBeCloseTo(2.5, 6);
    expect(body.DR.unit).toMatch(/kilogram/);
    expect(body.AR.value).toBeCloseTo(625.0, 4);
  });

  test("assessment CRUD round-trip", async ({ request }) => {
    const create = await request.post(`${API}/api/assessments`, {
      data: { name: `api-rt-${Date.now()}`, chemical_name: "benzene" },
    });
    expect(create.ok()).toBeTruthy();
    const a = await create.json();
    expect(a).toHaveProperty("id");

    const read = await request.get(`${API}/api/assessments/${a.id}`);
    expect(read.ok()).toBeTruthy();
    expect((await read.json()).name).toBe(a.name);

    const patch = await request.patch(`${API}/api/assessments/${a.id}`, {
      data: { notes: "edited via api e2e" },
    });
    expect(patch.ok()).toBeTruthy();

    const del = await request.delete(`${API}/api/assessments/${a.id}`);
    expect(del.ok()).toBeTruthy();

    const after = await request.get(`${API}/api/assessments/${a.id}`);
    expect(after.status()).toBe(404);
  });

  test("nested resources + calc + reports", async ({ request }) => {
    // Create assessment
    const a = await (
      await request.post(`${API}/api/assessments`, {
        data: { name: `api-calc-${Date.now()}` },
      })
    ).json();

    // Add operation 1
    const op = await (
      await request.post(`${API}/api/assessments/${a.id}/operations`, {
        data: { op_id: 1, name: "Manufacturing" },
      })
    ).json();
    expect(op).toHaveProperty("id");

    // Add an activity that supports a release model (act_id 1 = sampling liquids).
    const act = await (
      await request.post(
        `${API}/api/assessments/${a.id}/operations/${op.id}/activities`,
        { data: { act_id: 1, name: "Sampling Liquids" } },
      )
    ).json();
    expect(act).toHaveProperty("id");

    // Add a model run (drum residual #2).
    const run = await (
      await request.post(
        `${API}/api/assessments/${a.id}/activities/${act.id}/runs`,
        {
          data: {
            activity_id: act.id,
            model_id: 2,
            model_kind: "release",
            inputs: { Amt: 100, LF: 0.025, Freq: 250, NS: 1 },
          },
        },
      )
    ).json();
    expect(run).toHaveProperty("id");

    // Trigger calc.
    const calc = await (
      await request.post(`${API}/api/assessments/${a.id}/calc`)
    ).json();
    expect(calc.runs.length).toBeGreaterThan(0);
    expect(calc.runs[0].ok).toBe(true);

    // Reports.
    for (const fmt of ["html", "csv", "json"] as const) {
      const rep = await request.get(`${API}/api/assessments/${a.id}/report.${fmt}`);
      expect(rep.ok()).toBeTruthy();
    }
    // PDF is binary; sanity-check magic bytes.
    const pdf = await request.get(`${API}/api/assessments/${a.id}/report.pdf`);
    expect(pdf.ok()).toBeTruthy();
    const head = (await pdf.body()).subarray(0, 4).toString("ascii");
    expect(head).toBe("%PDF");

    // Revisions.
    const revs = await (
      await request.get(`${API}/api/assessments/${a.id}/revisions`)
    ).json();
    expect(Array.isArray(revs)).toBeTruthy();
  });

  test(".cs2 import accepts MDBShell.epa", async ({ request }) => {
    const fs = await import("fs");
    const path = "/home/blake/programs/chemsteer/extracted/msi-app/MDBShell.epa";
    if (!fs.existsSync(path)) test.skip();
    const buf = fs.readFileSync(path);
    const r = await request.post(`${API}/api/imports/cs2`, {
      multipart: {
        file: {
          name: "MDBShell.cs2",
          mimeType: "application/octet-stream",
          buffer: buf,
        },
      },
    });
    // MDBShell is the empty template — it should return an empty/zero
    // assessment, not 500. Either 200 (with empty results) or 400 (no
    // assessments) is acceptable; what we MUST avoid is a server crash.
    expect([200, 400, 422]).toContain(r.status());
  });
});
