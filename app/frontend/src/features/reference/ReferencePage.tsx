import { useQuery } from "@tanstack/react-query";
import { useEffect, useState } from "react";
import { api } from "../../lib/api";

function useDebounced(value: string, ms = 300): string {
  const [debounced, setDebounced] = useState(value);
  useEffect(() => {
    const t = setTimeout(() => setDebounced(value), ms);
    return () => clearTimeout(t);
  }, [value, ms]);
  return debounced;
}

const inputStyle = {
  width: "100%",
  padding: "6px 10px",
  border: "1px solid #d4d4d8",
  borderRadius: 4,
  marginBottom: 12,
} as const;

function NaicsSearch() {
  const [q, setQ] = useState("");
  const dq = useDebounced(q);
  const { data } = useQuery({
    queryKey: ["naics", dq],
    queryFn: () => api.naics(dq),
  });
  return (
    <section>
      <h3>NAICS codes</h3>
      <input
        type="search"
        placeholder="Code prefix or description (e.g. 325 or 'Chemical')"
        value={q}
        onChange={(e) => setQ(e.target.value)}
        style={inputStyle}
      />
      <table>
        <thead>
          <tr>
            <th>Code</th>
            <th>Description</th>
          </tr>
        </thead>
        <tbody>
          {data?.map((n, i) => (
            <tr key={i}>
              <td>
                <code>{n.code}</code>
              </td>
              <td>{n.description}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </section>
  );
}

function fmt(v: number | null): string {
  return v == null ? "—" : String(v);
}

function ExposureLimitSearch() {
  const [q, setQ] = useState("");
  const dq = useDebounced(q);
  const { data } = useQuery({
    queryKey: ["exposure-limits", dq],
    queryFn: () => api.exposureLimits(dq),
  });
  return (
    <section style={{ marginTop: 32 }}>
      <h3>OSHA PEL / NIOSH REL exposure limits</h3>
      <input
        type="search"
        placeholder="CAS number or chemical name (e.g. 58-89-9 or LINDANE)"
        value={q}
        onChange={(e) => setQ(e.target.value)}
        style={inputStyle}
      />
      <table>
        <thead>
          <tr>
            <th>CAS</th>
            <th>Chemical</th>
            <th>MW</th>
            <th>PEL-TWA (ppm)</th>
            <th>PEL-TWA (mg/m³)</th>
            <th>REL-TWA (ppm)</th>
            <th>REL-TWA (mg/m³)</th>
          </tr>
        </thead>
        <tbody>
          {data?.map((row, i) => (
            <tr key={i} title={row.pel_comments ?? undefined}>
              <td className="muted">{row.cas_number}</td>
              <td>{row.chemical_name}</td>
              <td className="muted">{fmt(row.mw)}</td>
              <td>{fmt(row.pel_twa_ppm)}</td>
              <td>{fmt(row.pel_twa_mgm3)}</td>
              <td>{fmt(row.rel_twa_ppm)}</td>
              <td>{fmt(row.rel_twa_mgm3)}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </section>
  );
}

export function ReferencePage() {
  return (
    <>
      <h2>Reference data</h2>
      <p className="muted">
        Lookups from ChemSTEER v3.2's master database: 1,814 NAICS industry
        codes and 652 chemicals with OSHA PEL / NIOSH REL limits.
      </p>
      <NaicsSearch />
      <ExposureLimitSearch />
    </>
  );
}
