# syntax=docker/dockerfile:1.7

# ---------- Frontend build stage ----------
FROM node:20-bookworm-slim AS frontend
WORKDIR /frontend
COPY frontend/package.json frontend/package-lock.jso[n] ./
RUN if [ -f package-lock.json ]; then npm ci; else npm install; fi
COPY frontend/ ./
RUN npm run build

# ---------- Python runtime stage ----------
FROM python:3.12-slim-bookworm AS runtime
ENV PYTHONDONTWRITEBYTECODE=1 \
    PYTHONUNBUFFERED=1 \
    PIP_DISABLE_PIP_VERSION_CHECK=1 \
    UV_LINK_MODE=copy \
    UV_PROJECT_ENVIRONMENT=/app/.venv \
    PATH="/app/.venv/bin:$PATH"

# WeasyPrint native deps (Pango, GObject Introspection, Cairo)
RUN apt-get update && apt-get install -y --no-install-recommends \
        libpango-1.0-0 libpangoft2-1.0-0 libharfbuzz0b libcairo2 \
        libgdk-pixbuf-2.0-0 fontconfig fonts-dejavu \
        ca-certificates curl mdbtools \
    && rm -rf /var/lib/apt/lists/*

# uv as the package manager (fast, deterministic)
COPY --from=ghcr.io/astral-sh/uv:0.10 /uv /uvx /usr/local/bin/

WORKDIR /app
COPY pyproject.toml ./
COPY src ./src
COPY scripts ./scripts
RUN uv sync --no-dev --frozen 2>/dev/null || uv sync --no-dev

# Built SPA -> served by FastAPI's StaticFiles
COPY --from=frontend /frontend/dist ./src/chemsteer/static

EXPOSE 8000
ENV CHEMSTEER_HOST=0.0.0.0 CHEMSTEER_PORT=8000
CMD ["chemsteer", "serve"]
