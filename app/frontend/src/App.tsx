import { useQuery } from "@tanstack/react-query";

type Health = { status: string; version: string };

async function fetchHealth(): Promise<Health> {
  const r = await fetch("/api/health");
  if (!r.ok) throw new Error(`HTTP ${r.status}`);
  return r.json();
}

export function App() {
  const { data, isLoading, error } = useQuery({
    queryKey: ["health"],
    queryFn: fetchHealth,
  });

  return (
    <main style={{ fontFamily: "system-ui", padding: 32, maxWidth: 720 }}>
      <h1>ChemSTEER</h1>
      <p>
        Python web app reimplementation of EPA's Chemical Screening Tool for
        Exposures and Environmental Releases. Phase 0 — bootstrap.
      </p>

      <section style={{ marginTop: 24 }}>
        <h2 style={{ fontSize: 18 }}>API status</h2>
        {isLoading && <p>checking…</p>}
        {error && <p style={{ color: "crimson" }}>error: {String(error)}</p>}
        {data && (
          <pre
            style={{
              background: "#f4f4f5",
              padding: 12,
              borderRadius: 6,
              fontSize: 13,
            }}
          >
            {JSON.stringify(data, null, 2)}
          </pre>
        )}
      </section>
    </main>
  );
}
