// Hand-rolled REST client. Phase 7 will replace this with a generated
// openapi-typescript client.

export type Operation = {
  op_id: number;
  op_name: string | null;
  op_type: string | null;
};

export type Activity = {
  act_id: number;
  act_name: string | null;
  rel_activity: boolean | null;
  exp_activity: boolean | null;
  default_rel_model: number | null;
  default_rel_model_2: number | null;
  default_rel_model_3: number | null;
  default_inh_model: number | null;
  default_drm_model: number | null;
};

export type Model = {
  model_id: number;
  model_name: string | null;
  type: "R" | "I" | "D" | null;
  equation: string | null;
  basis: string | null;
  mechanism: string | null;
};

export type Parameter = {
  parm_id: number;
  parm_name: string | null;
  abbr: string | null;
  std_units: string | null;
  notes: string | null;
  type: string | null;
};

export type Scenario = {
  op_id: number;
  op_name: string | null;
  scenario_id: number | null;
  op_type: string | null;
  pdf: string | null;
};

async function get<T>(path: string): Promise<T> {
  const r = await fetch(path);
  if (!r.ok) throw new Error(`${path}: HTTP ${r.status}`);
  return r.json();
}

// --- Assessment workflow types ------------------------------------------

export type AssessmentSummary = {
  id: number;
  name: string;
  chemical_name: string | null;
  cas_number: string | null;
  created_at: string;
  updated_at: string;
};

export type Quantity = { value: number; unit: string };

export type ActivityRow = {
  id: number;
  act_id: number;
  name: string | null;
  sort_order: number;
};

export type OperationRow = {
  id: number;
  op_id: number;
  name: string | null;
  sort_order: number;
  activities: ActivityRow[];
};

export type AssessmentRead = AssessmentSummary & {
  notes: string | null;
  operations: OperationRow[];
};

export type ModelRun = {
  id: number;
  activity_id: number;
  model_id: number;
  model_kind: "release" | "exposure";
  inputs: Record<string, unknown>;
  outputs: Record<string, Quantity> | null;
  last_run_at: string | null;
};

export type CalcRunResult = {
  run_id: number;
  model_id: number;
  model_kind: string;
  ok: boolean;
  error: string | null;
  outputs: Record<string, Quantity> | null;
};

export type CalcAssessmentResponse = {
  assessment_id: number;
  runs: CalcRunResult[];
};

export type Revision = {
  id: number;
  assessment_id: number;
  summary: string;
  created_at: string;
};

async function jsonFetch<T>(path: string, init?: RequestInit): Promise<T> {
  const r = await fetch(path, {
    headers: { "content-type": "application/json", ...(init?.headers ?? {}) },
    ...init,
  });
  if (!r.ok) {
    const text = await r.text();
    throw new Error(`${path}: HTTP ${r.status} — ${text}`);
  }
  if (r.status === 204) return undefined as T;
  return r.json();
}

export const api = {
  // --- registry (Phase 1) ---
  operations: () => get<Operation[]>("/api/operations"),
  operation: (id: number) => get<Operation>(`/api/operations/${id}`),
  activities: () => get<Activity[]>("/api/activities"),
  activity: (id: number) => get<Activity>(`/api/activities/${id}`),
  models: (type?: "R" | "I" | "D") =>
    get<Model[]>(type ? `/api/models?type=${type}` : "/api/models"),
  model: (id: number) => get<Model>(`/api/models/${id}`),
  modelValidActivities: (id: number) =>
    get<number[]>(`/api/models/${id}/valid-activities`),
  parameters: () => get<Parameter[]>("/api/parameters"),
  parameter: (id: number) => get<Parameter>(`/api/parameters/${id}`),
  scenarios: () => get<Scenario[]>("/api/scenarios"),

  // --- assessments (Phase 4) ---
  assessments: () => get<AssessmentSummary[]>("/api/assessments"),
  assessment: (id: number) => get<AssessmentRead>(`/api/assessments/${id}`),
  createAssessment: (body: { name: string; chemical_name?: string; cas_number?: string; notes?: string }) =>
    jsonFetch<AssessmentRead>("/api/assessments", {
      method: "POST",
      body: JSON.stringify(body),
    }),
  updateAssessment: (
    id: number,
    body: Partial<{ name: string; chemical_name: string; cas_number: string; notes: string }>,
  ) =>
    jsonFetch<AssessmentRead>(`/api/assessments/${id}`, {
      method: "PATCH",
      body: JSON.stringify(body),
    }),
  deleteAssessment: (id: number) =>
    jsonFetch<void>(`/api/assessments/${id}`, { method: "DELETE" }),

  addOperation: (
    aid: number,
    body: {
      op_id: number;
      name?: string | null;
      sort_order?: number;
      activities?: { act_id: number; name?: string | null; sort_order?: number }[];
    },
  ) =>
    jsonFetch<OperationRow>(`/api/assessments/${aid}/operations`, {
      method: "POST",
      body: JSON.stringify(body),
    }),
  deleteOperation: (aid: number, oid: number) =>
    jsonFetch<void>(`/api/assessments/${aid}/operations/${oid}`, {
      method: "DELETE",
    }),
  addActivity: (
    aid: number,
    oid: number,
    body: { act_id: number; name?: string | null; sort_order?: number },
  ) =>
    jsonFetch<ActivityRow>(
      `/api/assessments/${aid}/operations/${oid}/activities`,
      { method: "POST", body: JSON.stringify(body) },
    ),

  listRuns: (aid: number, actId: number) =>
    get<ModelRun[]>(`/api/assessments/${aid}/activities/${actId}/runs`),
  addRun: (
    aid: number,
    actId: number,
    body: {
      activity_id: number;
      model_id: number;
      model_kind: "release" | "exposure";
      inputs: Record<string, unknown>;
    },
  ) =>
    jsonFetch<ModelRun>(`/api/assessments/${aid}/activities/${actId}/runs`, {
      method: "POST",
      body: JSON.stringify(body),
    }),
  deleteRun: (aid: number, runId: number) =>
    jsonFetch<void>(`/api/assessments/${aid}/runs/${runId}`, {
      method: "DELETE",
    }),

  calcAssessment: (aid: number) =>
    jsonFetch<CalcAssessmentResponse>(`/api/assessments/${aid}/calc`, {
      method: "POST",
    }),

  revisions: (aid: number) =>
    get<Revision[]>(`/api/assessments/${aid}/revisions`),
};
