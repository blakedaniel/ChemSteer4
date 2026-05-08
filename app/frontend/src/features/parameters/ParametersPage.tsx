import { useQuery } from "@tanstack/react-query";
import { useState } from "react";
import { api } from "../../lib/api";

export function ParametersPage() {
  const [q, setQ] = useState("");
  const { data, isLoading, error } = useQuery({
    queryKey: ["parameters"],
    queryFn: api.parameters,
  });

  if (isLoading) return <p className="spinner">Loading…</p>;
  if (error) return <p className="error">{String(error)}</p>;

  const filtered = data!.filter((p) => {
    const haystack = `${p.parm_name} ${p.abbr} ${p.std_units}`.toLowerCase();
    return haystack.includes(q.toLowerCase());
  });

  return (
    <>
      <h2>Parameters</h2>
      <p className="muted">
        Every named parameter used in the equations: vapor pressure (VP),
        molecular weight (MW), loss fraction (LF), etc. Units below feed
        directly into the calc engine's Pint registry.
      </p>
      <input
        type="text"
        value={q}
        onChange={(e) => setQ(e.target.value)}
        placeholder="filter by name, abbr, or units"
        style={{
          width: "100%",
          padding: "8px 12px",
          marginBottom: 12,
          border: "1px solid #d4d4d8",
          borderRadius: 6,
          fontSize: 14,
        }}
      />
      <p className="muted" style={{ fontSize: 12 }}>
        {filtered.length} of {data!.length} parameters
      </p>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Abbr</th>
            <th>Name</th>
            <th>Units</th>
          </tr>
        </thead>
        <tbody>
          {filtered.map((p) => (
            <tr key={p.parm_id}>
              <td>{p.parm_id}</td>
              <td>
                <code>{p.abbr}</code>
              </td>
              <td>{p.parm_name}</td>
              <td className="muted">{p.std_units}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
