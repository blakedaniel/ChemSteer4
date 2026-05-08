import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { useState } from "react";
import { api } from "../../lib/api";

export function AddOperationForm({ aid }: { aid: number }) {
  const qc = useQueryClient();
  const { data: ops } = useQuery({
    queryKey: ["operations"],
    queryFn: api.operations,
  });
  const [opId, setOpId] = useState<number | "">("");

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

  return (
    <div
      style={{
        background: "#fafafa",
        border: "1px dashed #d4d4d8",
        borderRadius: 8,
        padding: 12,
        marginTop: 12,
        display: "flex",
        gap: 8,
        alignItems: "center",
      }}
    >
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
  );
}
