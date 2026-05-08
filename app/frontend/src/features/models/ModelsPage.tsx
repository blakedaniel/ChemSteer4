import { useQuery } from "@tanstack/react-query";
import { Link } from "react-router-dom";
import { useState } from "react";
import { api, Model } from "../../lib/api";

type Filter = "ALL" | "R" | "I" | "D";

export function ModelsPage() {
  const [filter, setFilter] = useState<Filter>("ALL");
  const { data, isLoading, error } = useQuery({
    queryKey: ["models", filter],
    queryFn: () => api.models(filter === "ALL" ? undefined : filter),
  });

  if (isLoading) return <p className="spinner">Loading…</p>;
  if (error) return <p className="error">{String(error)}</p>;

  return (
    <>
      <h2>Models</h2>
      <p className="muted">
        Master model registry. R = release, I = inhalation, D = dermal. Click
        a row to read the equation as ChemSTEER stores it.
      </p>
      <div style={{ marginBottom: 12 }}>
        {(["ALL", "R", "I", "D"] as Filter[]).map((f) => (
          <button
            key={f}
            onClick={() => setFilter(f)}
            style={{
              marginRight: 8,
              padding: "4px 12px",
              border: "1px solid #d4d4d8",
              borderRadius: 4,
              background: filter === f ? "#18181b" : "#fff",
              color: filter === f ? "#fff" : "#18181b",
              cursor: "pointer",
            }}
          >
            {f}
          </button>
        ))}
        <span className="muted" style={{ marginLeft: 12 }}>
          {data!.length} models
        </span>
      </div>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Type</th>
            <th>Name</th>
          </tr>
        </thead>
        <tbody>
          {data!.map((m: Model) => (
            <tr key={m.model_id}>
              <td>
                <Link to={`/models/${m.model_id}`}>{m.model_id}</Link>
              </td>
              <td>
                {m.type && <span className={`tag tag-${m.type}`}>{m.type}</span>}
              </td>
              <td>{m.model_name}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
