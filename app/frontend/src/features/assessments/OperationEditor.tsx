import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { useState } from "react";
import { api, OperationRow } from "../../lib/api";
import { ActivityEditor } from "./ActivityEditor";

export function OperationEditor({
  aid,
  operation,
}: {
  aid: number;
  operation: OperationRow;
}) {
  const qc = useQueryClient();
  const { data: allActivities } = useQuery({
    queryKey: ["activities"],
    queryFn: api.activities,
  });
  const [actId, setActId] = useState<number | "">("");

  const remove = useMutation({
    mutationFn: () => api.deleteOperation(aid, operation.id),
    onSuccess: () => qc.invalidateQueries({ queryKey: ["assessment", aid] }),
  });

  const addActivity = useMutation({
    mutationFn: (id: number) =>
      api.addActivity(aid, operation.id, {
        act_id: id,
        name: allActivities?.find((a) => a.act_id === id)?.act_name ?? null,
      }),
    onSuccess: () => {
      setActId("");
      qc.invalidateQueries({ queryKey: ["assessment", aid] });
    },
  });

  return (
    <div
      style={{
        background: "#fff",
        border: "1px solid #e4e4e7",
        borderRadius: 8,
        padding: 16,
        marginBottom: 16,
      }}
    >
      <div
        style={{
          display: "flex",
          justifyContent: "space-between",
          alignItems: "baseline",
        }}
      >
        <h4 style={{ margin: 0, fontSize: 15 }}>
          Op #{operation.op_id} — {operation.name ?? "(unnamed)"}
        </h4>
        <button
          onClick={() => {
            if (confirm(`Delete operation #${operation.op_id}?`)) remove.mutate();
          }}
          style={{
            background: "transparent",
            border: 0,
            color: "#991b1b",
            cursor: "pointer",
            fontSize: 12,
          }}
        >
          delete
        </button>
      </div>

      <div style={{ marginTop: 12, paddingLeft: 12, borderLeft: "2px solid #e4e4e7" }}>
        {operation.activities.length === 0 && (
          <p className="muted" style={{ fontSize: 13, margin: "4px 0" }}>
            No activities yet.
          </p>
        )}
        {operation.activities.map((act) => (
          <ActivityEditor key={act.id} aid={aid} activity={act} />
        ))}

        <div
          style={{
            display: "flex",
            gap: 8,
            marginTop: 8,
            alignItems: "center",
            fontSize: 13,
          }}
        >
          <span className="muted">Add activity:</span>
          <select
            value={actId === "" ? "" : String(actId)}
            onChange={(e) =>
              setActId(e.target.value === "" ? "" : Number(e.target.value))
            }
            style={{ flex: 1, padding: 4, borderRadius: 4, border: "1px solid #d4d4d8" }}
          >
            <option value="">— choose —</option>
            {allActivities?.map((a) => (
              <option key={a.act_id} value={a.act_id}>
                #{a.act_id} {a.act_name}
              </option>
            ))}
          </select>
          <button
            onClick={() => actId !== "" && addActivity.mutate(actId)}
            disabled={actId === "" || addActivity.isPending}
            style={{
              padding: "4px 10px",
              background: "#27272a",
              color: "#fff",
              border: 0,
              borderRadius: 4,
              cursor: actId === "" ? "not-allowed" : "pointer",
              fontSize: 12,
            }}
          >
            Add
          </button>
        </div>
      </div>
    </div>
  );
}
