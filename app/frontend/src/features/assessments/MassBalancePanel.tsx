import { useMutation } from "@tanstack/react-query";
import { useState } from "react";
import { api, MassBalanceResponse } from "../../lib/api";

const KNOWNS: { key: "NS" | "T" | "DMOchem" | "Yprod" | "DMOprod"; label: string }[] = [
  { key: "NS", label: "Number of sites (NS)" },
  { key: "T", label: "Operating days / batches (OD · Nby)" },
  { key: "DMOchem", label: "Daily mass of chemical (kg/site-day)" },
  { key: "Yprod", label: "Weight fraction in product (Yprod)" },
  { key: "DMOprod", label: "Daily mass of product (kg/site-day)" },
];

export function MassBalancePanel() {
  const [pv, setPv] = useState("");
  const [mode, setMode] = useState<"continuous" | "batch">("continuous");
  const [values, setValues] = useState<Record<string, string>>({});
  const [result, setResult] = useState<MassBalanceResponse | null>(null);

  const solve = useMutation({
    mutationFn: () => {
      const body: Record<string, unknown> = { pv_kg_yr: Number(pv), mode };
      for (const { key } of KNOWNS) {
        const raw = (values[key] ?? "").trim();
        if (raw !== "") body[key] = Number(raw);
      }
      return api.massBalance(body as Parameters<typeof api.massBalance>[0]);
    },
    onSuccess: setResult,
  });

  return (
    <details data-testid="mass-balance" style={{ margin: "12px 0", fontSize: 13 }}>
      <summary style={{ cursor: "pointer", fontWeight: 600 }}>
        Operation mass balance
        <span className="muted" style={{ fontWeight: 400, marginLeft: 8, fontSize: 12 }}>
          PV = NS × OD × DMOchem
        </span>
      </summary>
      <div
        style={{
          marginTop: 8,
          background: "#fafafa",
          border: "1px solid #f4f4f5",
          borderRadius: 6,
          padding: 12,
          display: "grid",
          gap: 8,
        }}
      >
        <div style={{ display: "flex", gap: 12, flexWrap: "wrap" }}>
          <label style={{ display: "grid", gap: 2, fontSize: 12 }}>
            <span className="muted">Production volume (kg/yr)</span>
            <input
              type="number"
              step="any"
              value={pv}
              onChange={(e) => setPv(e.target.value)}
              style={{ padding: 4, border: "1px solid #d4d4d8", borderRadius: 4, width: 160 }}
            />
          </label>
          <label style={{ display: "grid", gap: 2, fontSize: 12 }}>
            <span className="muted">Mode</span>
            <select
              value={mode}
              onChange={(e) => setMode(e.target.value as "continuous" | "batch")}
              style={{ padding: 4, border: "1px solid #d4d4d8", borderRadius: 4 }}
            >
              <option value="continuous">Continuous (OD)</option>
              <option value="batch">Batch (Nby)</option>
            </select>
          </label>
        </div>
        <p className="muted" style={{ fontSize: 11, margin: 0 }}>
          Fill three knowns (v3.2's checkboxes); the rest are derived with the
          original's rounding and ≥5 % discrepancy warnings.
        </p>
        <div style={{ display: "flex", gap: 12, flexWrap: "wrap" }}>
          {KNOWNS.map(({ key, label }) => (
            <label key={key} style={{ display: "grid", gap: 2, fontSize: 12 }}>
              <span className="muted">{label}</span>
              <input
                type="number"
                step="any"
                value={values[key] ?? ""}
                onChange={(e) => setValues((v) => ({ ...v, [key]: e.target.value }))}
                style={{ padding: 4, border: "1px solid #d4d4d8", borderRadius: 4, width: 140 }}
              />
            </label>
          ))}
        </div>
        <button
          onClick={() => solve.mutate()}
          disabled={solve.isPending || pv.trim() === ""}
          style={{
            padding: "5px 14px",
            background: "#27272a",
            color: "#fff",
            border: 0,
            borderRadius: 4,
            cursor: "pointer",
            fontSize: 12,
            justifySelf: "start",
          }}
        >
          {solve.isPending ? "Solving…" : "Solve"}
        </button>
        {solve.error && (
          <p className="error" style={{ fontSize: 11, margin: 0 }}>
            {String(solve.error)}
          </p>
        )}
        {result && (
          <div data-testid="mass-balance-result" style={{ fontSize: 12 }}>
            <strong>
              NS = {result.NS} · {mode === "continuous" ? "OD" : "Nby"} = {result.T} · DMOchem ={" "}
              {result.DMOchem.toExponential(3)} kg/site-day
            </strong>
            {result.Yprod != null && <> · Yprod = {result.Yprod.toExponential(3)}</>}
            {result.DMOprod != null && (
              <> · DMOprod = {result.DMOprod.toExponential(3)} kg/site-day</>
            )}
            {result.derived.length > 0 && (
              <span className="muted"> (derived: {result.derived.join(", ")})</span>
            )}
            {result.warnings.map((w, i) => (
              <p key={i} style={{ color: "#b45309", fontSize: 11, margin: "4px 0 0" }}>
                ⚠ {w}
              </p>
            ))}
          </div>
        )}
      </div>
    </details>
  );
}
