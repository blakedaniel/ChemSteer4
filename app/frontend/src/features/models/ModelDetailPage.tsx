import { useQuery } from "@tanstack/react-query";
import { Link, useParams } from "react-router-dom";
import { api } from "../../lib/api";

export function ModelDetailPage() {
  const { id } = useParams();
  const modelId = Number(id);
  const { data, isLoading, error } = useQuery({
    queryKey: ["model", modelId],
    queryFn: () => api.model(modelId),
    enabled: Number.isFinite(modelId),
  });
  const { data: validActs } = useQuery({
    queryKey: ["model", modelId, "valid-acts"],
    queryFn: () => api.modelValidActivities(modelId),
    enabled: Number.isFinite(modelId),
  });

  if (isLoading) return <p className="spinner">Loading…</p>;
  if (error) return <p className="error">{String(error)}</p>;
  if (!data) return null;

  return (
    <>
      <p className="muted">
        <Link to="/models">← Models</Link>
      </p>
      <h2>
        Model #{data.model_id}: {data.model_name}{" "}
        {data.type && <span className={`tag tag-${data.type}`}>{data.type}</span>}
      </h2>

      {data.basis && (
        <>
          <h3>Basis</h3>
          <p>{data.basis}</p>
        </>
      )}

      {data.mechanism && (
        <>
          <h3>Mechanism</h3>
          <p>{data.mechanism}</p>
        </>
      )}

      <h3>Equation</h3>
      <pre className="equation">{data.equation || "(none)"}</pre>

      <h3>Valid for activities</h3>
      {validActs && validActs.length > 0 ? (
        <ul>
          {validActs.map((a) => (
            <li key={a}>
              <Link to={`/activities/${a}`}>Activity {a}</Link>
            </li>
          ))}
        </ul>
      ) : (
        <p className="muted">
          Not in <code>ListOfValidModels</code> — only reachable as a default
          model attached to a Generic-Scenario activity.
        </p>
      )}
    </>
  );
}
