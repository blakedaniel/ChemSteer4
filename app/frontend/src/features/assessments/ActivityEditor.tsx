import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { useState } from "react";
import { ActivityRow, api, ModelRun } from "../../lib/api";

function MediaEditor({
  aid,
  run,
  onDone,
}: {
  aid: number;
  run: ModelRun;
  onDone: () => void;
}) {
  const { data: allMedia } = useQuery({ queryKey: ["media"], queryFn: api.media });
  const [split, setSplit] = useState<Record<string, string>>(() =>
    Object.fromEntries(
      Object.entries(run.media ?? {}).map(([m, p]) => [m, String(p)]),
    ),
  );
  const [addId, setAddId] = useState("");

  const total = Object.values(split).reduce((s, v) => s + (Number(v) || 0), 0);
  const nameOf = (mid: string) =>
    allMedia?.find((m) => m.media_id === Number(mid))?.name ?? `Media ${mid}`;

  const save = useMutation({
    mutationFn: () =>
      api.updateRun(aid, run.id, {
        media: Object.fromEntries(
          Object.entries(split)
            .map(([m, v]) => [m, Number(v) || 0])
            .filter(([, v]) => (v as number) > 0),
        ) as Record<string, number>,
      }),
    onSuccess: onDone,
  });

  return (
    <div
      data-testid="media-editor"
      style={{ margin: "6px 0", display: "grid", gap: 4, fontSize: 11 }}
    >
      {Object.keys(split).map((mid) => (
        <label key={mid} style={{ display: "flex", gap: 6, alignItems: "center" }}>
          <span style={{ minWidth: 180 }}>{nameOf(mid)}</span>
          <input
            type="number"
            step="any"
            min={0}
            max={100}
            value={split[mid]}
            onChange={(e) => setSplit((s) => ({ ...s, [mid]: e.target.value }))}
            style={{ width: 70, padding: 2, border: "1px solid #d4d4d8", borderRadius: 4 }}
          />
          %
          <button
            onClick={() =>
              setSplit((s) => {
                const next = { ...s };
                delete next[mid];
                return next;
              })
            }
            style={{ background: "transparent", border: 0, color: "#991b1b", cursor: "pointer" }}
          >
            ✕
          </button>
        </label>
      ))}
      <div style={{ display: "flex", gap: 6, alignItems: "center" }}>
        <select
          value={addId}
          onChange={(e) => setAddId(e.target.value)}
          style={{ padding: 2, border: "1px solid #d4d4d8", borderRadius: 4 }}
        >
          <option value="">— add medium —</option>
          {allMedia
            ?.filter((m) => !(String(m.media_id) in split))
            .map((m) => (
              <option key={m.media_id} value={m.media_id}>
                {m.name}
              </option>
            ))}
        </select>
        <button
          onClick={() => {
            if (addId !== "") {
              setSplit((s) => ({ ...s, [addId]: "0" }));
              setAddId("");
            }
          }}
          disabled={addId === ""}
          style={{ padding: "2px 8px", border: "1px solid #d4d4d8", borderRadius: 4, cursor: "pointer" }}
        >
          add
        </button>
        <span style={{ color: Math.abs(total - 100) < 0.01 ? "#15803d" : "#b45309" }}>
          total {total.toFixed(1)} %
        </span>
        <button
          onClick={() => save.mutate()}
          disabled={save.isPending || Math.abs(total - 100) > 0.01}
          style={{
            padding: "2px 10px",
            background: "#1d4ed8",
            color: "#fff",
            border: 0,
            borderRadius: 4,
            cursor: "pointer",
          }}
        >
          {save.isPending ? "Saving…" : "Save media"}
        </button>
      </div>
      {save.error && (
        <p className="error" style={{ fontSize: 11, margin: 0 }}>
          {String(save.error)}
        </p>
      )}
    </div>
  );
}

function RunRow({
  aid,
  activityId,
  run,
}: {
  aid: number;
  activityId: number;
  run: ModelRun;
}) {
  const qc = useQueryClient();
  const [editing, setEditing] = useState(false);
  const [editingMedia, setEditingMedia] = useState(false);
  const [inputsJson, setInputsJson] = useState("");

  const invalidate = () =>
    qc.invalidateQueries({ queryKey: ["runs", aid, activityId] });

  const update = useMutation({
    mutationFn: () =>
      api.updateRun(aid, run.id, {
        inputs: JSON.parse(inputsJson) as Record<string, unknown>,
      }),
    onSuccess: () => {
      setEditing(false);
      invalidate();
    },
  });

  const removeRun = useMutation({
    mutationFn: () => api.deleteRun(aid, run.id),
    onSuccess: invalidate,
  });

  const { data: allMedia } = useQuery({
    queryKey: ["media"],
    queryFn: api.media,
    enabled: run.model_kind === "release" && run.media != null,
  });
  const mediaSummary =
    run.media &&
    Object.entries(run.media)
      .map(([m, p]) => {
        const name = allMedia?.find((e) => e.media_id === Number(m))?.name ?? `#${m}`;
        return `${name} ${p}%`;
      })
      .join(", ");

  return (
    <li>
      <span className={`tag tag-${run.model_kind === "release" ? "R" : "I"}`}>
        #{run.model_id} {run.model_kind}
      </span>{" "}
      {run.label && (
        <em className="muted" style={{ fontSize: 11 }}>
          {run.label}
        </em>
      )}{" "}
      <code style={{ fontSize: 11 }}>{JSON.stringify(run.inputs)}</code>{" "}
      {run.outputs && (
        <span className="muted">
          → {Object.entries(run.outputs)
            .map(([k, q]) => `${k}=${q.value.toExponential(3)} ${q.unit}`)
            .join(", ")}
        </span>
      )}
      {mediaSummary && (
        <span className="muted" style={{ fontSize: 11 }}>
          {" "}
          ⤷ {mediaSummary}
        </span>
      )}
      <button
        onClick={() => {
          setInputsJson(JSON.stringify(run.inputs, null, 2));
          setEditing((v) => !v);
        }}
        style={{
          background: "transparent",
          border: 0,
          color: "#1d4ed8",
          cursor: "pointer",
          fontSize: 11,
          marginLeft: 6,
        }}
      >
        {editing ? "cancel" : "edit"}
      </button>
      {run.model_kind === "release" && (
        <button
          onClick={() => setEditingMedia((v) => !v)}
          style={{
            background: "transparent",
            border: 0,
            color: "#1d4ed8",
            cursor: "pointer",
            fontSize: 11,
            marginLeft: 4,
          }}
        >
          {editingMedia ? "cancel media" : "media"}
        </button>
      )}
      <button
        onClick={() => {
          if (confirm(`Delete run #${run.id}?`)) removeRun.mutate();
        }}
        style={{
          background: "transparent",
          border: 0,
          color: "#991b1b",
          cursor: "pointer",
          fontSize: 11,
          marginLeft: 4,
        }}
      >
        ✕
      </button>
      {editing && (
        <div style={{ margin: "6px 0", display: "grid", gap: 4 }}>
          <textarea
            rows={5}
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
          <button
            onClick={() => update.mutate()}
            disabled={update.isPending}
            style={{
              padding: "3px 10px",
              background: "#1d4ed8",
              color: "#fff",
              border: 0,
              borderRadius: 4,
              cursor: "pointer",
              fontSize: 11,
              justifySelf: "start",
            }}
          >
            {update.isPending ? "Saving…" : "Save inputs"}
          </button>
          {update.error && (
            <p className="error" style={{ fontSize: 11 }}>
              {String(update.error)}
            </p>
          )}
        </div>
      )}
      {editingMedia && (
        <MediaEditor
          aid={aid}
          run={run}
          onDone={() => {
            setEditingMedia(false);
            invalidate();
          }}
        />
      )}
    </li>
  );
}

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
  const [inputsJson, setInputsJson] = useState("{}");

  const selectedModel = allModels?.find((m) => m.model_id === modelId);
  const modelKind: "release" | "exposure" | undefined =
    selectedModel?.type === "R"
      ? "release"
      : selectedModel?.type === "I" || selectedModel?.type === "D"
        ? "exposure"
        : undefined;

  // v3.2 pre-fills the model dialog from ParmDefaults; do the same when a
  // model is picked, resolving defaults in this activity's context.
  const pickModel = async (id: number | "") => {
    setModelId(id);
    if (id === "") {
      setInputsJson("{}");
      return;
    }
    try {
      const d = await api.modelDefaults(id, {
        act_id: activity.act_id,
        assessment_id: aid,
      });
      const prefill: Record<string, unknown> = {};
      for (const f of d.fields) {
        prefill[f] = f in d.defaults ? d.defaults[f] : null;
      }
      setInputsJson(JSON.stringify(prefill, null, 2));
    } catch {
      setInputsJson("{}");
    }
  };

  const addRun = useMutation({
    mutationFn: () => {
      if (modelId === "" || !modelKind) throw new Error("pick a model first");
      const parsed = JSON.parse(inputsJson) as Record<string, unknown>;
      // Nulls are "still to fill in" placeholders from the prefill.
      const inputs = Object.fromEntries(
        Object.entries(parsed).filter(([, v]) => v !== null),
      );
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
            <RunRow key={r.id} aid={aid} activityId={activity.id} run={r} />
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
              void pickModel(e.target.value === "" ? "" : Number(e.target.value))
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
            rows={8}
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
          <p className="muted" style={{ fontSize: 11, margin: 0 }}>
            Pre-filled from v3.2 parameter defaults; <code>null</code> fields
            still need a value (they are dropped if left null).
          </p>
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
