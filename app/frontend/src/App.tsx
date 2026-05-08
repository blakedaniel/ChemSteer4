import { NavLink, Route, Routes, Navigate } from "react-router-dom";
import { ModelsPage } from "./features/models/ModelsPage";
import { ModelDetailPage } from "./features/models/ModelDetailPage";
import { ActivitiesPage } from "./features/activities/ActivitiesPage";
import { ActivityDetailPage } from "./features/activities/ActivityDetailPage";
import { OperationsPage } from "./features/operations/OperationsPage";
import { ParametersPage } from "./features/parameters/ParametersPage";
import { ScenariosPage } from "./features/scenarios/ScenariosPage";

export function App() {
  return (
    <div className="layout">
      <aside className="sidebar">
        <h1>ChemSTEER</h1>
        <nav>
          <NavLink to="/operations">Operations</NavLink>
          <NavLink to="/activities">Activities</NavLink>
          <NavLink to="/models">Models</NavLink>
          <NavLink to="/parameters">Parameters</NavLink>
          <NavLink to="/scenarios">Generic Scenarios</NavLink>
        </nav>
        <p className="muted" style={{ marginTop: 24, fontSize: 11 }}>
          Phase 1 — read-only browse over seed data.
        </p>
      </aside>
      <main className="content">
        <Routes>
          <Route path="/" element={<Navigate to="/models" replace />} />
          <Route path="/operations" element={<OperationsPage />} />
          <Route path="/activities" element={<ActivitiesPage />} />
          <Route path="/activities/:id" element={<ActivityDetailPage />} />
          <Route path="/models" element={<ModelsPage />} />
          <Route path="/models/:id" element={<ModelDetailPage />} />
          <Route path="/parameters" element={<ParametersPage />} />
          <Route path="/scenarios" element={<ScenariosPage />} />
        </Routes>
      </main>
    </div>
  );
}
