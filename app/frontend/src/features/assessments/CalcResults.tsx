import { CalcAssessmentResponse } from "../../lib/api";

export function CalcResults({ result }: { result: CalcAssessmentResponse }) {
  const okCount = result.runs.filter((r) => r.ok).length;
  const failCount = result.runs.length - okCount;

  return (
    <div
      style={{
        marginTop: 12,
        background: "#fff",
        border: "1px solid #e4e4e7",
        borderRadius: 8,
        padding: 16,
      }}
    >
      <h3 style={{ marginTop: 0, fontSize: 14 }}>
        Calc results: {okCount} ok, {failCount} failed
      </h3>
      <table style={{ fontSize: 12 }}>
        <thead>
          <tr>
            <th>Run</th>
            <th>Model</th>
            <th>Status</th>
            <th>Outputs</th>
          </tr>
        </thead>
        <tbody>
          {result.runs.map((r) => (
            <tr key={r.run_id}>
              <td>#{r.run_id}</td>
              <td>
                <span className={`tag tag-${r.model_kind === "release" ? "R" : "I"}`}>
                  #{r.model_id}
                </span>
              </td>
              <td style={{ color: r.ok ? "#15803d" : "#991b1b" }}>
                {r.ok ? "✓ ok" : "✗ failed"}
              </td>
              <td style={{ fontFamily: "ui-monospace, monospace", fontSize: 11 }}>
                {r.error ? (
                  <span className="error" style={{ padding: "2px 6px", fontSize: 11 }}>
                    {r.error}
                  </span>
                ) : r.outputs ? (
                  Object.entries(r.outputs).map(([k, q]) => (
                    <div key={k}>
                      <strong>{k}</strong> = {q.value.toExponential(3)} {q.unit}
                    </div>
                  ))
                ) : (
                  "—"
                )}
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
