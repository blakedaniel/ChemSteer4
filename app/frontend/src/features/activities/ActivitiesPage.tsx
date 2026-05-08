import { useQuery } from "@tanstack/react-query";
import { Link } from "react-router-dom";
import { api } from "../../lib/api";

export function ActivitiesPage() {
  const { data, isLoading, error } = useQuery({
    queryKey: ["activities"],
    queryFn: api.activities,
  });

  if (isLoading) return <p className="spinner">Loading…</p>;
  if (error) return <p className="error">{String(error)}</p>;

  return (
    <>
      <h2>Activities</h2>
      <p className="muted">
        72 activities — what workers actually do at an assessment site.
        Each activity carries default models for release, inhalation, dermal.
      </p>
      <table>
        <thead>
          <tr>
            <th>ActID</th>
            <th>Name</th>
            <th>Default Rel</th>
            <th>Default Inh</th>
            <th>Default Dermal</th>
          </tr>
        </thead>
        <tbody>
          {data!.map((a) => (
            <tr key={a.act_id}>
              <td>
                <Link to={`/activities/${a.act_id}`}>{a.act_id}</Link>
              </td>
              <td>{a.act_name}</td>
              <td>{a.default_rel_model ?? "—"}</td>
              <td>{a.default_inh_model ?? "—"}</td>
              <td>{a.default_drm_model ?? "—"}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
