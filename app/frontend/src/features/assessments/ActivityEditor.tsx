import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { useState } from "react";
import { ActivityRow, api, ModelRun } from "../../lib/api";

export function ActivityEditor({
  aid,
  activity,
}: {
  aid: number;
  activity: ActivityRow;
}) {
  const qc = useQueryClient();
  const { data: runs } = useQuery({
    queryKey: ["runs", aid, activity.id],
    queryFn: () => api.listRuns(aid, activity.id),
  });
  const { data: allModels } = useQuery({
    queryKey: ["models"],
    queryFn: () => api.models(),
  });

  const [modelId, setModelId] = useState<number | "">("");
  const [inputsJson, setInputsJson] = useState(
    `{\n  "Amt": 100,\n  "LF": 0.025,\n  "Freq": 250,\n  "NS": 1\n}`,
  );

  const selectedModel = allModels?.find((m) => m.model_id === modelId);
  const modelKind: "release" | "exposure" | undefined =
    selectedModel?.type === "R"
      ? "release"
      : selectedModel?.type === "I" || selectedModel?.type === "D"
        ? "exposure"
        : undefined;

  const addRun = useMutation({
    mutationFn: () => {
      if (modelId === "" || !modelKind) throw new Error("pick a model first");
      const inputs = JSON.parse(inputsJson) as Record<string, unknown>;
      return api.addRun(aid, activity.id, {
        activity_id: activity.id,
        model_id: modelId,
        model_kind: modelKind,
        inputs,
      });
    },
    onSuccess: () =>
      qc.invalidateQueries({ queryKey: ["runs", aid, activity.id] }),
  });

  const removeRun = useMutation({
    mutationFn: (run_id: number) => api.deleteRun(aid, run_id),
    onSuccess: () =>
      qc.invalidateQueries({ queryKey: ["runs", aid, activity.id] }),
  });

  return (
    <div
      style={{
        background: "#fafafa",
        border: "1px solid #f4f4f5",
        borderRadius: 6,
        padding: 10,
        margin: "6px 0",
      }}
    >
      <div style={{ fontWeight: 600, fontSize: 13 }}>
        Activity #{activity.act_id} — {activity.name ?? "(unnamed)"}
      </div>

      {runs?.length ? (
        <ul style={{ margin: "8px 0", paddingLeft: 18, fontSize: 12 }}>
          {runs.map((r: ModelRun) => (
            <li key={r.id}>
              <span className={`tag tag-${r.model_kind === "release" ? "R" : "I"}`}>
                #{r.model_id} {r.model_kind}
              </span>{" "}
              <code style={{ fontSize: 11 }}>
                {JSON.stringify(r.inputs)}
              </code>{" "}
              {r.outputs && (
                <span className="muted">
                  → {Object.entries(r.outputs)
                    .map(([k, q]) => `${k}=${q.value.toExponential(3)} ${q.unit}`)
                    .join(", ")}
                </span>
              )}
              <button
                onClick={() => {
                  if (confirm(`Delete run #${r.id}?`)) removeRun.mutate(r.id);
                }}
                style={{
                  background: "transparent",
                  border: 0,
                  color: "#991b1b",
                  cursor: "pointer",
                  fontSize: 11,
                  marginLeft: 6,
                }}
              >
                ✕
              </button>
            </li>
          ))}
        </ul>
      ) : (
        <p className="muted" style={{ fontSize: 12, margin: "4px 0" }}>
          No model runs.
        </p>
      )}

      <details style={{ fontSize: 12 }}>
        <summary style={{ cursor: "pointer", color: "#1d4ed8" }}>
          + Add model run
        </summary>
        <div style={{ marginTop: 8, display: "grid", gap: 6 }}>
          <select
            value={modelId === "" ? "" : String(modelId)}
            onChange={(e) =>
              setModelId(e.target.value === "" ? "" : Number(e.target.value))
            }
            style={{ padding: 4, borderRadius: 4, border: "1px solid #d4d4d8" }}
          >
            <option value="">— pick a model —</option>
            {allModels?.map((m) => (
              <option key={m.model_id} value={m.model_id}>
                #{m.model_id} [{m.type}] {m.model_name}
              </option>
            ))}
          </select>
          <textarea
            rows={6}
            value={inputsJson}
            onChange={(e) => setInputsJson(e.target.value)}
            style={{
              fontFamily: "ui-monospace, monospace",
              fontSize: 11,
              padding: 6,
              border: "1px solid #d4d4d8",
              borderRadius: 4,
            }}
          />
          {selectedModel && (
            <pre className="equation" style={{ fontSize: 11 }}>
              {selectedModel.equation}
            </pre>
          )}
          <button
            onClick={() => addRun.mutate()}
            disabled={addRun.isPending || modelId === ""}
            style={{
              padding: "4px 10px",
              background: "#27272a",
              color: "#fff",
              border: 0,
              borderRadius: 4,
              cursor: modelId === "" ? "not-allowed" : "pointer",
              fontSize: 12,
              justifySelf: "start",
            }}
          >
            {addRun.isPending ? "Adding…" : "Add run"}
          </button>
          {addRun.error && (
            <p className="error" style={{ fontSize: 11 }}>
              {String(addRun.error)}
            </p>
          )}
        </div>
      </details>
    </div>
  );
}
