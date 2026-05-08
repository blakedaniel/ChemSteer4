import { useQuery } from "@tanstack/react-query";
import { api } from "../../lib/api";

export function RevisionSidebar({ aid }: { aid: number }) {
  const { data, isLoading } = useQuery({
    queryKey: ["revisions", aid],
    queryFn: () => api.revisions(aid),
  });

  return (
    <aside
      style={{
        background: "#fff",
        border: "1px solid #e4e4e7",
        borderRadius: 8,
        padding: 16,
        height: "fit-content",
        position: "sticky",
        top: 24,
      }}
    >
      <h3 style={{ marginTop: 0, fontSize: 14, color: "#52525b" }}>
        Revision history
      </h3>
      {isLoading ? (
        <p className="spinner" style={{ fontSize: 12 }}>
          Loading…
        </p>
      ) : data && data.length > 0 ? (
        <ul style={{ paddingLeft: 16, margin: 0, fontSize: 12 }}>
          {data.map((r) => (
            <li key={r.id} style={{ marginBottom: 6 }}>
              <div style={{ fontFamily: "ui-monospace, monospace", fontSize: 11 }}>
                {new Date(r.created_at).toLocaleString()}
              </div>
              <div className="muted">{r.summary}</div>
            </li>
          ))}
        </ul>
      ) : (
        <p className="muted" style={{ fontSize: 12 }}>
          No revisions yet.
        </p>
      )}
    </aside>
  );
}
