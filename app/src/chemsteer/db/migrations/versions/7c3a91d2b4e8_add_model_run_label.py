"""add model_runs.label

Revision ID: 7c3a91d2b4e8
Revises: 1e168e56150b
Create Date: 2026-06-11

"""

from collections.abc import Sequence

import sqlalchemy as sa
from alembic import op

revision: str = "7c3a91d2b4e8"
down_revision: str | None = "1e168e56150b"
branch_labels: str | Sequence[str] | None = None
depends_on: str | Sequence[str] | None = None


def upgrade() -> None:
    op.add_column("model_runs", sa.Column("label", sa.String(length=64), nullable=True))


def downgrade() -> None:
    op.drop_column("model_runs", "label")
