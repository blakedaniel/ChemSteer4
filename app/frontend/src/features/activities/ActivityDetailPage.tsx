import { useQuery } from "@tanstack/react-query";
import { Link, useParams } from "react-router-dom";
import { api } from "../../lib/api";

export function ActivityDetailPage() {
  const { id } = useParams();
  const actId = Number(id);
  const { data, isLoading, error } = useQuery({
    queryKey: ["activity", actId],
    queryFn: () => api.activity(actId),
    enabled: Number.isFinite(actId),
  });

  if (isLoading) return <p className="spinner">Loading…</p>;
  if (error) return <p className="error">{String(error)}</p>;
  if (!data) return null;

  const defaults: [string, number | null][] = [
    ["Default release model", data.default_rel_model],
    ["Default release model 2", data.default_rel_model_2],
    ["Default release model 3", data.default_rel_model_3],
    ["Default inhalation model", data.default_inh_model],
    ["Default dermal model", data.default_drm_model],
  ];

  return (
    <>
      <p className="muted">
        <Link to="/activities">← Activities</Link>
      </p>
      <h2>
        Activity {data.act_id}: {data.act_name}
      </h2>
      <table>
        <tbody>
          {defaults.map(([label, mid]) => (
            <tr key={label}>
              <th style={{ width: 220 }}>{label}</th>
              <td>
                {mid == null ? (
                  "—"
                ) : (
                  <Link to={`/models/${Math.abs(mid)}`}>
                    #{mid}
                    {mid < 0 ? " (global default)" : ""}
                  </Link>
                )}
              </td>
            </tr>
          ))}
          <tr>
            <th>Release activity?</th>
            <td>{data.rel_activity ? "yes" : "no"}</td>
          </tr>
          <tr>
            <th>Exposure activity?</th>
            <td>{data.exp_activity ? "yes" : "no"}</td>
          </tr>
        </tbody>
      </table>
    </>
  );
}
