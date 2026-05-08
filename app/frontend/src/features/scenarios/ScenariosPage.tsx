import { useQuery } from "@tanstack/react-query";
import { api } from "../../lib/api";

export function ScenariosPage() {
  const { data, isLoading, error } = useQuery({
    queryKey: ["scenarios"],
    queryFn: api.scenarios,
  });

  if (isLoading) return <p className="spinner">Loading…</p>;
  if (error) return <p className="error">{String(error)}</p>;

  return (
    <>
      <h2>Generic Scenarios</h2>
      <p className="muted">
        34 EPA Generic Scenarios pre-configured in v3.2. v1.0 of this rebuild
        focuses on user-defined operations; the scenarios browse view here is
        for reference. v2 will let users instantiate a GS into an assessment.
      </p>
      <table>
        <thead>
          <tr>
            <th>OpID</th>
            <th>Scenario</th>
            <th>Type</th>
            <th>Reference PDF</th>
          </tr>
        </thead>
        <tbody>
          {data!.map((s) => (
            <tr key={`${s.op_id}-${s.scenario_id}`}>
              <td>{s.op_id}</td>
              <td>{s.op_name}</td>
              <td>{s.op_type}</td>
              <td className="muted" style={{ fontSize: 12 }}>
                {s.pdf || "—"}
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
