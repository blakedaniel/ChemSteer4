from __future__ import annotations

from collections.abc import AsyncIterator
from contextlib import asynccontextmanager

from fastapi import FastAPI
from fastapi.middleware.cors import CORSMiddleware

from chemsteer import __version__
from chemsteer.api.routers import (
    activities,
    calc,
    models,
    operations,
    parameters,
    scenarios,
)


@asynccontextmanager
async def lifespan(_: FastAPI) -> AsyncIterator[None]:
    # Reserved for future startup wiring (open seed DBs, prepare calc registry).
    yield


def create_app() -> FastAPI:
    api = FastAPI(
        title="ChemSTEER",
        version=__version__,
        description=(
            "Python reimplementation of EPA's ChemSTEER (Chemical Screening "
            "Tool for Exposures and Environmental Releases). Phase 0 — "
            "bootstrap."
        ),
        lifespan=lifespan,
    )

    # In dev the SPA runs on a different port (Vite); in prod the SPA is
    # served from the same origin so CORS is mainly a dev convenience.
    api.add_middleware(
        CORSMiddleware,
        allow_origins=["http://127.0.0.1:5173", "http://localhost:5173"],
        allow_methods=["*"],
        allow_headers=["*"],
    )

    @api.get("/api/health", tags=["meta"])
    async def health() -> dict[str, str]:
        return {"status": "ok", "version": __version__}

    @api.get("/api/", tags=["meta"])
    async def root() -> dict[str, str]:
        return {"message": "hello from chemsteer", "version": __version__}

    # Read-only seed-data browse endpoints
    api.include_router(operations.router)
    api.include_router(activities.router)
    api.include_router(models.router)
    api.include_router(parameters.router)
    api.include_router(scenarios.router)
    api.include_router(calc.router)

    return api


app = create_app()
__all__ = ["app", "create_app"]
