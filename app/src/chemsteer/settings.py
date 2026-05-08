from __future__ import annotations

from pathlib import Path

from pydantic import Field
from pydantic_settings import BaseSettings, SettingsConfigDict


def _default_user_data_dir() -> Path:
    return Path.home() / ".chemsteer-py"


class Settings(BaseSettings):
    """Runtime configuration. Override via env vars (`CHEMSTEER_*`) or a
    `.env` file in the working directory."""

    model_config = SettingsConfigDict(
        env_prefix="CHEMSTEER_",
        env_file=".env",
        extra="ignore",
    )

    host: str = "127.0.0.1"
    port: int = 8000
    reload: bool = False

    user_data_dir: Path = Field(default_factory=_default_user_data_dir)
    log_format: str = "console"  # "console" | "json"
    log_level: str = "INFO"

    @property
    def assessments_db_path(self) -> Path:
        return self.user_data_dir / "assessments.db"

    @property
    def seed_data_dir(self) -> Path:
        # Resolved at runtime to the package's bundled seed_data/ dir.
        return Path(__file__).parent / "seed_data"


def get_settings() -> Settings:
    return Settings()
