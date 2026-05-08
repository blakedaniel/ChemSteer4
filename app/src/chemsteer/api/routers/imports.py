"""POST /api/imports/cs2 — upload a v3.2 .cs2 file."""

from __future__ import annotations

import shutil
import tempfile
from pathlib import Path

from fastapi import APIRouter, File, HTTPException, UploadFile
from pydantic import BaseModel

from chemsteer.importers.cs2 import Cs2ImportError, import_cs2

router = APIRouter(prefix="/api/imports", tags=["imports"])


class ImportResponse(BaseModel):
    assessment_id: int
    name: str
    n_operations: int
    n_activities: int
    n_runs: int
    skipped_runs: list[str]


@router.post("/cs2", response_model=ImportResponse, status_code=201)
async def upload_cs2(
    file: UploadFile = File(..., description="ChemSTEER v3.2 .cs2 file"),
) -> ImportResponse:
    """Import a ChemSTEER v3.2 user-assessment file.

    The .cs2 is an MDBShell-shaped Access database. The importer extracts
    Assessments / Operations / Activities / ActRelModels / ActExpModels
    + their parameter rows, mapping each to our user-DB schema.
    """
    with tempfile.NamedTemporaryFile(suffix=".cs2", delete=False) as tmp:
        try:
            shutil.copyfileobj(file.file, tmp)
            tmp.flush()
            tmp_path = Path(tmp.name)
        finally:
            file.file.close()

    try:
        result = import_cs2(tmp_path)
    except Cs2ImportError as exc:
        raise HTTPException(400, str(exc)) from exc
    finally:
        tmp_path.unlink(missing_ok=True)

    return ImportResponse(
        assessment_id=result.assessment_id,
        name=result.name,
        n_operations=result.n_operations,
        n_activities=result.n_activities,
        n_runs=result.n_runs,
        skipped_runs=result.skipped_runs,
    )
