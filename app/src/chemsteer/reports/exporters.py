"""Format the canonical report dict (from `builder.build_report`) into
HTML / PDF / CSV / JSON payloads.
"""

from __future__ import annotations

import csv
import io
import json
from typing import Any

from jinja2 import Environment, select_autoescape

from chemsteer.reports.builder import sci1

_jinja_env = Environment(
    autoescape=select_autoescape(["html", "xml"]),
    trim_blocks=True,
    lstrip_blocks=True,
)
_jinja_env.filters["sci1"] = sci1


_HTML_TEMPLATE = """\
<!doctype html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <title>ChemSTEER assessment — {{ a.name }}</title>
  <style>
    body { font-family: system-ui, sans-serif; max-width: 900px; margin: 24px auto; color: #18181b; }
    h1 { font-size: 22px; margin-bottom: 4px; }
    h2 { font-size: 16px; margin-top: 32px; border-bottom: 1px solid #e4e4e7; padding-bottom: 4px; }
    h3 { font-size: 14px; color: #52525b; margin-top: 16px; }
    table { width: 100%; border-collapse: collapse; font-size: 12px; margin: 8px 0; }
    th, td { padding: 6px 8px; text-align: left; border-bottom: 1px solid #f4f4f5; }
    th { background: #f4f4f5; }
    .muted { color: #71717a; }
    .tag-R { background: #dbeafe; color: #1d4ed8; padding: 2px 6px; border-radius: 4px; font-size: 11px; }
    .tag-I, .tag-D { background: #dcfce7; color: #15803d; padding: 2px 6px; border-radius: 4px; font-size: 11px; }
    code { font-family: ui-monospace, monospace; font-size: 11px; }
    .meta { color: #71717a; font-size: 12px; margin-top: 16px; padding-top: 12px; border-top: 1px solid #e4e4e7; }
  </style>
</head>
<body>
  <h1>{{ a.name }}</h1>
  <p class="muted">
    {% if a.chemical_name %}{{ a.chemical_name }}{% endif %}
    {% if a.cas_number %} &middot; CAS {{ a.cas_number }}{% endif %}
  </p>
  {% if a.notes %}<p>{{ a.notes }}</p>{% endif %}

  {% if chemical %}
  <h2>Chemical properties</h2>
  <table>
    <tbody>
      {% if chemical.mol_formula %}<tr><th>Molecular formula</th><td>{{ chemical.mol_formula }}</td></tr>{% endif %}
      {% if chemical.mw %}<tr><th>Molecular weight</th><td>{{ chemical.mw }} g/mol</td></tr>{% endif %}
      {% if chemical.vp_torr is not none %}<tr><th>Vapor pressure</th><td>{{ chemical.vp_torr | sci1 }} torr{% if chemical.vp_temp_c is not none %} at {{ chemical.vp_temp_c }} °C{% endif %}</td></tr>{% endif %}
      {% if chemical.density_kg_l %}<tr><th>Density</th><td>{{ chemical.density_kg_l }} kg/L{% if chemical.density_temp_c is not none %} at {{ chemical.density_temp_c }} °C{% endif %}</td></tr>{% endif %}
      {% if chemical.solubility_g_l is not none %}<tr><th>Water solubility</th><td>{{ chemical.solubility_g_l | sci1 }} g/L{% if chemical.sol_temp_c is not none %} at {{ chemical.sol_temp_c }} °C{% endif %}</td></tr>{% endif %}
      {% if chemical.melting_point_c is not none %}<tr><th>Melting point</th><td>{{ chemical.melting_point_c }} °C</td></tr>{% endif %}
      {% if chemical.boiling_point_c is not none %}<tr><th>Boiling point</th><td>{{ chemical.boiling_point_c }} °C</td></tr>{% endif %}
      {% if chemical.production_volume_kg_yr %}<tr><th>Production volume</th><td>{{ chemical.production_volume_kg_yr | sci1 }} kg/yr</td></tr>{% endif %}
      {% if chemical.physical_state %}<tr><th>Physical state</th><td>{{ chemical.physical_state }}</td></tr>{% endif %}
      {% if chemical.category %}<tr><th>Category</th><td>{{ chemical.category }}</td></tr>{% endif %}
      {% if chemical.trade_names %}<tr><th>Trade names</th><td>{{ chemical.trade_names }}</td></tr>{% endif %}
    </tbody>
  </table>
  {% endif %}

  {% if release_summary %}
  <h2>Environmental release summary (by medium)</h2>
  <table>
    <thead>
      <tr><th>Operation</th><th>Medium</th><th>Characterization</th>
          <th>Daily release (kg/site-day)</th><th>Annual release (kg/yr)</th><th>Activities</th></tr>
    </thead>
    <tbody>
    {% for row in release_summary %}
      <tr>
        <td>{{ row.op_name or ("#" ~ row.op_id) }}</td>
        <td>{{ row.media }}</td>
        <td>{{ row.label or "—" }}</td>
        <td>{{ row.drr_kg_day | sci1 }}</td>
        <td>{{ row.arr_kg_yr | sci1 }}</td>
        <td class="muted">{{ row.activities | join("; ") }}</td>
      </tr>
    {% endfor %}
    </tbody>
  </table>
  {% endif %}

  {% if not operations %}
    <p class="muted">No operations attached.</p>
  {% endif %}

  {% for op in operations %}
    <h2>Operation #{{ op.op_id }} &mdash; {{ op.name or "(unnamed)" }}</h2>
    {% if not op.activities %}
      <p class="muted">No activities under this operation.</p>
    {% endif %}
    {% for act in op.activities %}
      <h3>Activity #{{ act.act_id }} &mdash; {{ act.name or "(unnamed)" }}</h3>
      {% if act.runs %}
      <table>
        <thead>
          <tr><th>Model</th><th>Kind</th><th>Inputs</th><th>Outputs</th></tr>
        </thead>
        <tbody>
        {% for r in act.runs %}
          <tr>
            <td><span class="tag-{{ 'R' if r.model_kind == 'release' else 'I' }}">#{{ r.model_id }}</span></td>
            <td>{{ r.model_kind }}</td>
            <td><code>{{ r.inputs | tojson }}</code></td>
            <td>
              {% if r.outputs %}
                {% for k, q in r.outputs.items() %}
                  <div><strong>{{ k }}</strong> = {{ "%.4g" | format(q.value) }} {{ q.unit }}</div>
                {% endfor %}
              {% else %}
                <span class="muted">not computed</span>
              {% endif %}
            </td>
          </tr>
        {% endfor %}
        </tbody>
      </table>
      {% else %}
        <p class="muted">No model runs.</p>
      {% endif %}
    {% endfor %}
  {% endfor %}

  <p class="meta">
    Generated {{ generated_at }} &middot; ChemSTEER (Python rebuild) &middot;
    Assessment ID {{ a.id }}
  </p>
</body>
</html>
"""


def to_html(report: dict[str, Any]) -> str:
    template = _jinja_env.from_string(_HTML_TEMPLATE)
    return template.render(
        a=report["assessment"],
        chemical=report.get("chemical"),
        release_summary=report.get("release_summary") or [],
        operations=report["operations"],
        generated_at=report["generated_at"],
    )


def to_pdf(report: dict[str, Any]) -> bytes:
    """Render the report to PDF via WeasyPrint."""
    from weasyprint import HTML

    html = to_html(report)
    pdf_bytes: bytes = HTML(string=html).write_pdf()
    return pdf_bytes


def to_json(report: dict[str, Any]) -> str:
    return json.dumps(report, indent=2)


def to_csv(report: dict[str, Any]) -> str:
    """Flatten model runs into a single CSV table.

    Columns: assessment, op_id, op_name, act_id, act_name, run_id,
             model_kind, model_id, inputs (JSON), outputs (JSON).
    """
    out = io.StringIO()
    w = csv.writer(out)
    w.writerow(
        [
            "assessment_id",
            "assessment_name",
            "op_id",
            "op_name",
            "act_id",
            "act_name",
            "run_id",
            "model_kind",
            "model_id",
            "inputs_json",
            "outputs_json",
        ]
    )
    a = report["assessment"]
    for op in report["operations"]:
        for act in op["activities"]:
            for r in act["runs"]:
                w.writerow(
                    [
                        a["id"],
                        a["name"],
                        op["op_id"],
                        op["name"] or "",
                        act["act_id"],
                        act["name"] or "",
                        r["id"],
                        r["model_kind"],
                        r["model_id"],
                        json.dumps(r["inputs"]),
                        json.dumps(r["outputs"]) if r["outputs"] else "",
                    ]
                )
    return out.getvalue()
