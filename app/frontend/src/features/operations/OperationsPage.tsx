import { useQuery } from "@tanstack/react-query";
import { api } from "../../lib/api";

export function OperationsPage() {
  const { data, isLoading, error } = useQuery({
    queryKey: ["operations"],
    queryFn: api.operations,
  });

  if (isLoading) return <p className="spinner">Loading…</p>;
  if (error) return <p className="error">{String(error)}</p>;

  return (
    <>
      <h2>Operations</h2>
      <p className="muted">
        Top-level operation types. v1.0 ships the user-defined ops (1–3); the
        five Generic-Scenario ops (100–104) are the v2 target.
      </p>
      <table>
        <thead>
          <tr>
            <th>OpID</th>
            <th>Name</th>
            <th>Type</th>
          </tr>
        </thead>
        <tbody>
          {data!.map((o) => (
            <tr key={o.op_id}>
              <td>{o.op_id}</td>
              <td>{o.op_name}</td>
              <td>{o.op_type}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
