import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { useState } from "react";
import { api, FromScenarioResponse } from "../../lib/api";

export function AddOperationForm({ aid }: { aid: number }) {
  const qc = useQueryClient();
  const { data: ops } = useQuery({
    queryKey: ["operations"],
    queryFn: api.operations,
  });
  const { data: scenarios } = useQuery({
    queryKey: ["scenarios"],
    queryFn: api.scenarios,
  });
  const [opId, setOpId] = useState<number | "">("");
  const [scenarioId, setScenarioId] = useState<number | "">("");
  const [scenarioResult, setScenarioResult] = useState<FromScenarioResponse | null>(null);

  const add = useMutation({
    mutationFn: (op_id: number) =>
      api.addOperation(aid, {
        op_id,
        name: ops?.find((o) => o.op_id === op_id)?.op_name ?? null,
      }),
    onSuccess: () => {
      setOpId("");
      qc.invalidateQueries({ queryKey: ["assessment", aid] });
    },
  });

  const addFromScenario = useMutation({
    mutationFn: (sid: number) => api.addOperationFromScenario(aid, sid),
    onSuccess: (result) => {
      setScenarioId("");
      setScenarioResult(result);
      qc.invalidateQueries({ queryKey: ["assessment", aid] });
      qc.invalidateQueries({ queryKey: ["runs", aid] });
    },
  });

  const boxStyle = {
    background: "#fafafa",
    border: "1px dashed #d4d4d8",
    borderRadius: 8,
    padding: 12,
    marginTop: 12,
    display: "flex",
    gap: 8,
    alignItems: "center",
  } as const;

  return (
    <>
      <div style={boxStyle}>
        <span className="muted" style={{ fontSize: 13 }}>
          Add operation:
        </span>
        <select
          value={opId === "" ? "" : String(opId)}
          onChange={(e) => setOpId(e.target.value === "" ? "" : Number(e.target.value))}
          style={{ flex: 1, padding: 6, borderRadius: 4, border: "1px solid #d4d4d8" }}
        >
          <option value="">— choose an operation type —</option>
          {ops?.map((o) => (
            <option key={o.op_id} value={o.op_id}>
              #{o.op_id} {o.op_name} ({o.op_type})
            </option>
          ))}
        </select>
        <button
          onClick={() => opId !== "" && add.mutate(opId)}
          disabled={opId === "" || add.isPending}
          style={{
            padding: "6px 12px",
            background: "#18181b",
            color: "#fff",
            border: 0,
            borderRadius: 4,
            cursor: opId === "" ? "not-allowed" : "pointer",
          }}
        >
          Add
        </button>
      </div>

      <div style={boxStyle} data-testid="add-from-scenario">
        <span className="muted" style={{ fontSize: 13 }}>
          Add from Generic Scenario:
        </span>
        <select
          value={scenarioId === "" ? "" : String(scenarioId)}
          onChange={(e) =>
            setScenarioId(e.target.value === "" ? "" : Number(e.target.value))
          }
          style={{ flex: 1, padding: 6, borderRadius: 4, border: "1px solid #d4d4d8" }}
        >
          <option value="">— choose one of the 34 scenarios —</option>
          {scenarios?.map((s) => (
            <option key={s.scenario_id} value={s.scenario_id ?? ""}>
              {s.op_name}
            </option>
          ))}
        </select>
        <button
          onClick={() => scenarioId !== "" && addFromScenario.mutate(scenarioId)}
          disabled={scenarioId === "" || addFromScenario.isPending}
          style={{
            padding: "6px 12px",
            background: "#1d4ed8",
            color: "#fff",
            border: 0,
            borderRadius: 4,
            cursor: scenarioId === "" ? "not-allowed" : "pointer",
          }}
        >
          {addFromScenario.isPending ? "Adding…" : "Use scenario"}
        </button>
      </div>

      {addFromScenario.error && (
        <p className="error" style={{ fontSize: 12 }}>
          {String(addFromScenario.error)}
        </p>
      )}
      {scenarioResult && (
        <div
          style={{
            background: "#eff6ff",
            border: "1px solid #bfdbfe",
            borderRadius: 8,
            padding: 10,
            marginTop: 8,
            fontSize: 12,
          }}
        >
          Added <strong>{scenarioResult.operation.name}</strong> with{" "}
          {scenarioResult.n_activities} activities and {scenarioResult.n_runs}{" "}
          pre-parameterized model runs. Fill any missing parameters (e.g. number
          of sites) before running the calc.
          {scenarioResult.skipped_runs.length > 0 && (
            <ul style={{ margin: "6px 0 0", paddingLeft: 18 }}>
              {scenarioResult.skipped_runs.map((s, i) => (
                <li key={i} className="muted">
                  skipped: {s}
                </li>
              ))}
            </ul>
          )}
        </div>
      )}
    </>
  );
}
