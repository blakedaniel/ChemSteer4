import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { Link, useParams } from "react-router-dom";
import { api } from "../../lib/api";
import { OperationEditor } from "./OperationEditor";
import { AddOperationForm } from "./AddOperationForm";
import { CalcResults } from "./CalcResults";
import { ChemicalForm } from "./ChemicalForm";
import { MassBalancePanel } from "./MassBalancePanel";
import { RevisionSidebar } from "./RevisionSidebar";

export function AssessmentDetailPage() {
  const { id } = useParams();
  const aid = Number(id);
  const qc = useQueryClient();

  const { data, isLoading, error } = useQuery({
    queryKey: ["assessment", aid],
    queryFn: () => api.assessment(aid),
    enabled: Number.isFinite(aid),
  });

  const calc = useMutation({
    mutationFn: () => api.calcAssessment(aid),
    onSuccess: () => {
      qc.invalidateQueries({ queryKey: ["assessment", aid] });
      qc.invalidateQueries({ queryKey: ["revisions", aid] });
    },
  });

  if (isLoading) return <p className="spinner">Loading…</p>;
  if (error) return <p className="error">{String(error)}</p>;
  if (!data) return null;

  return (
    <div style={{ display: "grid", gridTemplateColumns: "1fr 280px", gap: 24 }}>
      <div>
        <p className="muted">
          <Link to="/assessments">← Assessments</Link>
        </p>
        <h2>{data.name}</h2>
        <p className="muted">
          {data.chemical_name ?? "(no chemical)"}{" "}
          {data.cas_number ? `· CAS ${data.cas_number}` : ""}
        </p>

        <ChemicalForm aid={aid} />
        <MassBalancePanel />

        <div style={{ margin: "16px 0" }}>
          <button
            onClick={() => calc.mutate()}
            disabled={calc.isPending || data.operations.length === 0}
            style={{
              padding: "8px 20px",
              background: "#15803d",
              color: "#fff",
              border: 0,
              borderRadius: 4,
              cursor: "pointer",
              fontWeight: 600,
            }}
          >
            {calc.isPending ? "Running…" : "Run calc on all attached models"}
          </button>
          {calc.data && (
            <CalcResults
              result={calc.data}
              key={calc.data.assessment_id + ":" + Date.now()}
            />
          )}
        </div>

        <div style={{ marginBottom: 16, display: "flex", gap: 8, flexWrap: "wrap" }}>
          <span className="muted" style={{ alignSelf: "center" }}>
            Export:
          </span>
          {(["html", "pdf", "csv", "json"] as const).map((fmt) => (
            <a
              key={fmt}
              href={`/api/assessments/${aid}/report.${fmt}`}
              target={fmt === "html" ? "_blank" : undefined}
              rel="noreferrer"
              style={{
                padding: "4px 12px",
                background: "#27272a",
                color: "#fff",
                borderRadius: 4,
                fontSize: 12,
                fontWeight: 600,
                textTransform: "uppercase",
                textDecoration: "none",
              }}
            >
              {fmt}
            </a>
          ))}
        </div>

        <h3>Operations</h3>
        {data.operations.length === 0 && (
          <p className="muted">No operations attached. Add one below.</p>
        )}
        {data.operations.map((op) => (
          <OperationEditor key={op.id} aid={aid} operation={op} />
        ))}

        <AddOperationForm aid={aid} />
      </div>

      <RevisionSidebar aid={aid} />
    </div>
  );
}
