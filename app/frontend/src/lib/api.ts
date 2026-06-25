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

export type ScenarioModel = {
  model_id: number;
  model_kind: "release" | "exposure";
  implemented: boolean;
  output_labels: (string | null)[];
};

export type ScenarioActivity = {
  scen_act_id: number;
  act_id: number;
  name: string | null;
  models: ScenarioModel[];
};

export type ScenarioDetail = Scenario & {
  process_desc: string | null;
  activities: ScenarioActivity[];
};

export type ModelDefaults = {
  model_id: number;
  model_kind: "release" | "exposure";
  fields: string[];
  defaults: Record<string, unknown>;
  media: Record<string, number>;
};

export type MediaEntry = {
  media_id: number;
  name: string;
  sort_id: number;
};

export type ChemicalRecord = {
  id: number;
  assessment_id: number;
  mol_formula: string | null;
  trade_names: string | null;
  category: string | null;
  mw: number | null;
  vp_torr: number | null;
  vp_temp_c: number | null;
  density_kg_l: number | null;
  density_temp_c: number | null;
  solubility_g_l: number | null;
  sol_temp_c: number | null;
  melting_point_c: number | null;
  boiling_point_c: number | null;
  production_volume_kg_yr: number | null;
  physical_state: string | null;
};

export type ChemicalRecordUpdate = Partial<Omit<ChemicalRecord, "id" | "assessment_id">>;

export type MassBalanceRequest = {
  pv_kg_yr: number;
  mode: "continuous" | "batch";
  NS?: number | null;
  T?: number | null;
  DMOchem?: number | null;
  Yprod?: number | null;
  DMOprod?: number | null;
  round_up_ns?: boolean;
};

export type MassBalanceResponse = {
  NS: number;
  T: number;
  DMOchem: number;
  Yprod: number | null;
  DMOprod: number | null;
  derived: string[];
  warnings: string[];
};

export type NaicsEntry = {
  code: string | null;
  description: string | null;
};

export type ExposureLimit = {
  cas_number: string | null;
  chemical_name: string | null;
  mw: number | null;
  pel_twa_ppm: number | null;
  pel_twa_mgm3: number | null;
  pel_stel_ppm: number | null;
  pel_stel_mgm3: number | null;
  pel_ceiling_ppm: number | null;
  pel_ceiling_mgm3: number | null;
  pel_comments: string | null;
  rel_twa_ppm: number | null;
  rel_twa_mgm3: number | null;
  rel_stel_ppm: number | null;
  rel_stel_mgm3: number | null;
  rel_ceiling_ppm: number | null;
  rel_ceiling_mgm3: number | null;
  rel_comments: string | null;
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
  label: string | null;
  inputs: Record<string, unknown>;
  outputs: Record<string, Quantity> | null;
  media: Record<string, number> | null;
  last_run_at: string | null;
};

export type FromScenarioResponse = {
  operation: OperationRow;
  n_activities: number;
  n_runs: number;
  skipped_runs: string[];
};

export type ImportResponse = {
  assessment_id: number;
  name: string;
  n_operations: number;
  n_activities: number;
  n_runs: number;
  skipped_runs: string[];
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
  scenario: (scenarioId: number) => get<ScenarioDetail>(`/api/scenarios/${scenarioId}`),
  modelDefaults: (
    id: number,
    opts?: { act_id?: number; gss_id?: number; output?: number; assessment_id?: number },
  ) => {
    const qs = new URLSearchParams();
    if (opts?.act_id) qs.set("act_id", String(opts.act_id));
    if (opts?.gss_id) qs.set("gss_id", String(opts.gss_id));
    if (opts?.output) qs.set("output", String(opts.output));
    if (opts?.assessment_id) qs.set("assessment_id", String(opts.assessment_id));
    const suffix = qs.toString() ? `?${qs}` : "";
    return get<ModelDefaults>(`/api/models/${id}/defaults${suffix}`);
  },

  // --- reference lookups ---
  naics: (q: string) =>
    get<NaicsEntry[]>(`/api/reference/naics?q=${encodeURIComponent(q)}`),
  exposureLimits: (q: string) =>
    get<ExposureLimit[]>(`/api/reference/exposure-limits?q=${encodeURIComponent(q)}`),
  media: () => get<MediaEntry[]>("/api/reference/media"),

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
  updateRun: (
    aid: number,
    runId: number,
    body: {
      inputs?: Record<string, unknown>;
      label?: string;
      media?: Record<string, number>;
    },
  ) =>
    jsonFetch<ModelRun>(`/api/assessments/${aid}/runs/${runId}`, {
      method: "PATCH",
      body: JSON.stringify(body),
    }),

  chemical: (aid: number) =>
    get<ChemicalRecord | null>(`/api/assessments/${aid}/chemical`),
  putChemical: (aid: number, body: ChemicalRecordUpdate) =>
    jsonFetch<ChemicalRecord>(`/api/assessments/${aid}/chemical`, {
      method: "PUT",
      body: JSON.stringify(body),
    }),

  massBalance: (body: MassBalanceRequest) =>
    jsonFetch<MassBalanceResponse>("/api/calc/mass-balance", {
      method: "POST",
      body: JSON.stringify(body),
    }),
  deleteRun: (aid: number, runId: number) =>
    jsonFetch<void>(`/api/assessments/${aid}/runs/${runId}`, {
      method: "DELETE",
    }),

  addOperationFromScenario: (aid: number, scenarioId: number) =>
    jsonFetch<FromScenarioResponse>(
      `/api/assessments/${aid}/operations/from-scenario`,
      { method: "POST", body: JSON.stringify({ scenario_id: scenarioId }) },
    ),

  importCs2: async (file: File): Promise<ImportResponse> => {
    const form = new FormData();
    form.append("file", file);
    const r = await fetch("/api/imports/cs2", { method: "POST", body: form });
    if (!r.ok) throw new Error(`import failed: HTTP ${r.status} — ${await r.text()}`);
    return r.json();
  },

  calcAssessment: (aid: number) =>
    jsonFetch<CalcAssessmentResponse>(`/api/assessments/${aid}/calc`, {
      method: "POST",
    }),

  revisions: (aid: number) =>
    get<Revision[]>(`/api/assessments/${aid}/revisions`),
};
