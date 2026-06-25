import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { useEffect, useState } from "react";
import { api, ChemicalRecordUpdate } from "../../lib/api";

type NumericField = {
  key: keyof ChemicalRecordUpdate;
  label: string;
  unit: string;
};

const NUMERIC_FIELDS: NumericField[] = [
  { key: "mw", label: "Molecular weight", unit: "g/mol" },
  { key: "vp_torr", label: "Vapor pressure", unit: "torr" },
  { key: "vp_temp_c", label: "VP temperature", unit: "°C" },
  { key: "density_kg_l", label: "Density", unit: "kg/L" },
  { key: "density_temp_c", label: "Density temperature", unit: "°C" },
  { key: "solubility_g_l", label: "Water solubility", unit: "g/L" },
  { key: "sol_temp_c", label: "Solubility temperature", unit: "°C" },
  { key: "melting_point_c", label: "Melting point", unit: "°C" },
  { key: "boiling_point_c", label: "Boiling point", unit: "°C" },
  { key: "production_volume_kg_yr", label: "Production volume", unit: "kg/yr" },
];

const TEXT_FIELDS: { key: keyof ChemicalRecordUpdate; label: string }[] = [
  { key: "mol_formula", label: "Molecular formula" },
  { key: "physical_state", label: "Physical state" },
  { key: "category", label: "Category" },
  { key: "trade_names", label: "Trade names" },
];

export function ChemicalForm({ aid }: { aid: number }) {
  const qc = useQueryClient();
  const { data: record } = useQuery({
    queryKey: ["chemical", aid],
    queryFn: () => api.chemical(aid),
  });

  const [draft, setDraft] = useState<Record<string, string>>({});
  useEffect(() => {
    if (!record) return;
    const next: Record<string, string> = {};
    for (const { key } of [...NUMERIC_FIELDS, ...TEXT_FIELDS]) {
      const v = record[key as keyof typeof record];
      next[key as string] = v === null || v === undefined ? "" : String(v);
    }
    setDraft(next);
  }, [record]);

  const save = useMutation({
    mutationFn: () => {
      const body: ChemicalRecordUpdate = {};
      for (const { key } of NUMERIC_FIELDS) {
        const raw = (draft[key as string] ?? "").trim();
        (body as Record<string, unknown>)[key as string] =
          raw === "" ? null : Number(raw);
      }
      for (const { key } of TEXT_FIELDS) {
        const raw = (draft[key as string] ?? "").trim();
        (body as Record<string, unknown>)[key as string] = raw === "" ? null : raw;
      }
      return api.putChemical(aid, body);
    },
    onSuccess: () => {
      qc.invalidateQueries({ queryKey: ["chemical", aid] });
      qc.invalidateQueries({ queryKey: ["revisions", aid] });
    },
  });

  const filled = record
    ? NUMERIC_FIELDS.filter(({ key }) => record[key as keyof typeof record] != null)
    : [];

  return (
    <details data-testid="chemical-form" style={{ margin: "12px 0", fontSize: 13 }}>
      <summary style={{ cursor: "pointer", fontWeight: 600 }}>
        Chemical properties
        {filled.length > 0 && (
          <span className="muted" style={{ fontWeight: 400, marginLeft: 8, fontSize: 12 }}>
            {filled
              .map(
                ({ key, unit }) =>
                  `${String(key).split("_")[0].toUpperCase()} ${record?.[key as keyof typeof record]} ${unit}`,
              )
              .slice(0, 4)
              .join(" · ")}
          </span>
        )}
      </summary>
      <div
        style={{
          marginTop: 8,
          display: "grid",
          gridTemplateColumns: "repeat(auto-fill, minmax(220px, 1fr))",
          gap: 8,
          background: "#fafafa",
          border: "1px solid #f4f4f5",
          borderRadius: 6,
          padding: 12,
        }}
      >
        {NUMERIC_FIELDS.map(({ key, label, unit }) => (
          <label key={key as string} style={{ display: "grid", gap: 2, fontSize: 12 }}>
            <span className="muted">
              {label} ({unit})
            </span>
            <input
              type="number"
              step="any"
              value={draft[key as string] ?? ""}
              onChange={(e) =>
                setDraft((d) => ({ ...d, [key as string]: e.target.value }))
              }
              style={{ padding: 4, border: "1px solid #d4d4d8", borderRadius: 4 }}
            />
          </label>
        ))}
        {TEXT_FIELDS.map(({ key, label }) => (
          <label key={key as string} style={{ display: "grid", gap: 2, fontSize: 12 }}>
            <span className="muted">{label}</span>
            <input
              value={draft[key as string] ?? ""}
              onChange={(e) =>
                setDraft((d) => ({ ...d, [key as string]: e.target.value }))
              }
              style={{ padding: 4, border: "1px solid #d4d4d8", borderRadius: 4 }}
            />
          </label>
        ))}
        <div style={{ alignSelf: "end" }}>
          <button
            onClick={() => save.mutate()}
            disabled={save.isPending}
            style={{
              padding: "5px 14px",
              background: "#1d4ed8",
              color: "#fff",
              border: 0,
              borderRadius: 4,
              cursor: "pointer",
              fontSize: 12,
            }}
          >
            {save.isPending ? "Saving…" : "Save chemical"}
          </button>
          {save.isSuccess && (
            <span style={{ color: "#15803d", marginLeft: 8, fontSize: 12 }}>saved ✓</span>
          )}
          {save.error && (
            <span className="error" style={{ marginLeft: 8, fontSize: 11 }}>
              {String(save.error)}
            </span>
          )}
        </div>
      </div>
      <p className="muted" style={{ fontSize: 11, marginTop: 4 }}>
        Model defaults pull vapor pressure, molecular weight, and water solubility
        from this record, like v3.2's chemical-record sentinels.
      </p>
    </details>
  );
}
