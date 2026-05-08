"""GET /api/assessments/{id}/report.{html|pdf|csv|json}."""

from __future__ import annotations

from fastapi import APIRouter, HTTPException, Path
from fastapi.responses import HTMLResponse, JSONResponse, PlainTextResponse, Response

from chemsteer.reports import builder, exporters

router = APIRouter(prefix="/api/assessments", tags=["reports"])


def _build(assessment_id: int) -> dict[str, object]:
    try:
        return builder.build_report(assessment_id)
    except KeyError as exc:
        raise HTTPException(404, str(exc)) from exc


@router.get("/{assessment_id}/report.html", response_class=HTMLResponse)
def report_html(assessment_id: int = Path(...)) -> HTMLResponse:
    return HTMLResponse(exporters.to_html(_build(assessment_id)))


@router.get(
    "/{assessment_id}/report.pdf",
    response_class=Response,
    responses={200: {"content": {"application/pdf": {}}}},
)
def report_pdf(assessment_id: int = Path(...)) -> Response:
    pdf_bytes = exporters.to_pdf(_build(assessment_id))
    return Response(
        content=pdf_bytes,
        media_type="application/pdf",
        headers={
            "Content-Disposition": f'attachment; filename="assessment-{assessment_id}.pdf"',
        },
    )


@router.get("/{assessment_id}/report.json", response_class=JSONResponse)
def report_json(assessment_id: int = Path(...)) -> JSONResponse:
    return JSONResponse(_build(assessment_id))


@router.get("/{assessment_id}/report.csv", response_class=PlainTextResponse)
def report_csv(assessment_id: int = Path(...)) -> PlainTextResponse:
    return PlainTextResponse(
        exporters.to_csv(_build(assessment_id)),
        media_type="text/csv",
        headers={
            "Content-Disposition": f'attachment; filename="assessment-{assessment_id}.csv"',
        },
    )
