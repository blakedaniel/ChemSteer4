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

export const api = {
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
};
