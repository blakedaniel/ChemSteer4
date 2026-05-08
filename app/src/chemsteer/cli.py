from __future__ import annotations

import typer
import uvicorn

from chemsteer.settings import get_settings

app = typer.Typer(
    name="chemsteer",
    help="ChemSTEER — Python web app for screening-level chemical "
    "exposure and environmental release assessments.",
    no_args_is_help=True,
)


@app.command()
def serve(
    host: str = typer.Option(None, help="Bind host (overrides settings)."),
    port: int = typer.Option(None, help="Bind port (overrides settings)."),
    reload: bool = typer.Option(False, help="Enable auto-reload (dev only)."),
) -> None:
    """Run the FastAPI server."""
    settings = get_settings()
    uvicorn.run(
        "chemsteer.api.app:app",
        host=host or settings.host,
        port=port or settings.port,
        reload=reload or settings.reload,
        factory=False,
    )


@app.command()
def version() -> None:
    """Print the installed package version."""
    from chemsteer import __version__

    typer.echo(__version__)


if __name__ == "__main__":
    app()
