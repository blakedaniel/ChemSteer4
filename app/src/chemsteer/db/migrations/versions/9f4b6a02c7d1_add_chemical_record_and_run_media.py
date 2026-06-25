"""Add chemical_records table and model_runs.media_json.

Revision ID: 9f4b6a02c7d1
Revises: 7c3a91d2b4e8
Create Date: 2026-06-11
"""

from __future__ import annotations

import sqlalchemy as sa
from alembic import op

revision: str = "9f4b6a02c7d1"
down_revision: str | None = "7c3a91d2b4e8"
branch_labels: str | None = None
depends_on: str | None = None


def upgrade() -> None:
    op.create_table(
        "chemical_records",
        sa.Column("id", sa.Integer(), primary_key=True),
        sa.Column(
            "assessment_id",
            sa.Integer(),
            sa.ForeignKey("assessments.id", ondelete="CASCADE"),
            unique=True,
            nullable=False,
        ),
        sa.Column("mol_formula", sa.String(255), nullable=True),
        sa.Column("trade_names", sa.String(255), nullable=True),
        sa.Column("category", sa.String(255), nullable=True),
        sa.Column("mw", sa.Float(), nullable=True),
        sa.Column("vp_torr", sa.Float(), nullable=True),
        sa.Column("vp_temp_c", sa.Float(), nullable=True),
        sa.Column("density_kg_l", sa.Float(), nullable=True),
        sa.Column("density_temp_c", sa.Float(), nullable=True),
        sa.Column("solubility_g_l", sa.Float(), nullable=True),
        sa.Column("sol_temp_c", sa.Float(), nullable=True),
        sa.Column("melting_point_c", sa.Float(), nullable=True),
        sa.Column("boiling_point_c", sa.Float(), nullable=True),
        sa.Column("production_volume_kg_yr", sa.Float(), nullable=True),
        sa.Column("physical_state", sa.String(64), nullable=True),
    )
    op.add_column("model_runs", sa.Column("media_json", sa.Text(), nullable=True))


def downgrade() -> None:
    op.drop_column("model_runs", "media_json")
    op.drop_table("chemical_records")
