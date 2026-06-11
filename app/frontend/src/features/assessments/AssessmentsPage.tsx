import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { Link, useNavigate } from "react-router-dom";
import { useRef, useState } from "react";
import { api } from "../../lib/api";

export function AssessmentsPage() {
  const [name, setName] = useState("");
  const [chemical, setChemical] = useState("");
  const fileRef = useRef<HTMLInputElement>(null);
  const qc = useQueryClient();
  const nav = useNavigate();

  const { data, isLoading, error } = useQuery({
    queryKey: ["assessments"],
    queryFn: api.assessments,
  });

  const create = useMutation({
    mutationFn: () =>
      api.createAssessment({
        name: name.trim() || "Untitled assessment",
        chemical_name: chemical.trim() || undefined,
      }),
    onSuccess: (a) => {
      setName("");
      setChemical("");
      qc.invalidateQueries({ queryKey: ["assessments"] });
      nav(`/assessments/${a.id}`);
    },
  });

  const importCs2 = useMutation({
    mutationFn: (file: File) => api.importCs2(file),
    onSuccess: (res) => {
      qc.invalidateQueries({ queryKey: ["assessments"] });
      nav(`/assessments/${res.assessment_id}`);
    },
  });

  if (isLoading) return <p className="spinner">Loading…</p>;
  if (error) return <p className="error">{String(error)}</p>;

  return (
    <>
      <h2>Assessments</h2>
      <p className="muted">
        Each assessment is a TSCA-screening calculation: pick operations, attach
        activities, choose models, edit parameters, hit Run.
      </p>

      <div
        style={{
          background: "#fff",
          border: "1px solid #e4e4e7",
          borderRadius: 8,
          padding: 16,
          marginBottom: 24,
        }}
      >
        <h3 style={{ marginTop: 0, fontSize: 14 }}>New assessment</h3>
        <div style={{ display: "flex", gap: 8 }}>
          <input
            type="text"
            placeholder="Name (e.g. PMN-12345)"
            value={name}
            onChange={(e) => setName(e.target.value)}
            style={{
              flex: 1,
              padding: "6px 10px",
              border: "1px solid #d4d4d8",
              borderRadius: 4,
            }}
          />
          <input
            type="text"
            placeholder="Chemical (optional)"
            value={chemical}
            onChange={(e) => setChemical(e.target.value)}
            style={{
              flex: 1,
              padding: "6px 10px",
              border: "1px solid #d4d4d8",
              borderRadius: 4,
            }}
          />
          <button
            onClick={() => create.mutate()}
            disabled={create.isPending}
            style={{
              padding: "6px 16px",
              background: "#18181b",
              color: "#fff",
              border: 0,
              borderRadius: 4,
              cursor: "pointer",
            }}
          >
            {create.isPending ? "Creating…" : "Create"}
          </button>
        </div>
        <div
          style={{
            marginTop: 12,
            paddingTop: 12,
            borderTop: "1px solid #f4f4f5",
            display: "flex",
            gap: 8,
            alignItems: "center",
          }}
        >
          <span className="muted" style={{ fontSize: 13 }}>
            Or import a ChemSTEER v3.2 file:
          </span>
          <input ref={fileRef} type="file" accept=".cs2" style={{ fontSize: 12 }} />
          <button
            onClick={() => {
              const f = fileRef.current?.files?.[0];
              if (f) importCs2.mutate(f);
            }}
            disabled={importCs2.isPending}
            style={{
              padding: "6px 12px",
              background: "#1d4ed8",
              color: "#fff",
              border: 0,
              borderRadius: 4,
              cursor: "pointer",
            }}
          >
            {importCs2.isPending ? "Importing…" : "Import .cs2"}
          </button>
          {importCs2.error && (
            <span className="error" style={{ fontSize: 12 }}>
              {String(importCs2.error)}
            </span>
          )}
        </div>
      </div>

      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Chemical</th>
            <th>CAS</th>
            <th>Updated</th>
          </tr>
        </thead>
        <tbody>
          {data!.length === 0 && (
            <tr>
              <td colSpan={5} className="muted" style={{ textAlign: "center" }}>
                No assessments yet. Create one above.
              </td>
            </tr>
          )}
          {data!.map((a) => (
            <tr key={a.id}>
              <td>
                <Link to={`/assessments/${a.id}`}>{a.id}</Link>
              </td>
              <td>{a.name}</td>
              <td>{a.chemical_name ?? "—"}</td>
              <td className="muted">{a.cas_number ?? "—"}</td>
              <td className="muted" style={{ fontSize: 12 }}>
                {new Date(a.updated_at).toLocaleString()}
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}
