"""Tests for the three special-shape inhalation models: #21, #45, #54."""

from __future__ import annotations

import math

from chemsteer.calc.dispatch import EXPOSURE_MODELS, get_exposure_model
from chemsteer.calc.exposure.inhalation import OshaVaporPelInput, osha_pel_vapor
from chemsteer.calc.exposure.near_far_field import NearFarFieldInput, near_far_field
from chemsteer.calc.exposure.small_volume import SmallVolumeInput, small_volume_handling


def _mg_per_day(q: object) -> float:
    return float(q.to("milligram / day").magnitude)  # type: ignore[union-attr]


# --- #21 Small Volume Handling -------------------------------------------


def test_small_volume_handling_arithmetic() -> None:
    """I = EF × AH × Ys × Sd.

    With EF=0.1 mg/kg, AH=10 kg/day, Ys=0.5, Sd=1:
      I = 0.1 × 10 × 0.5 × 1 = 0.5 mg/day
    """
    out = small_volume_handling(
        SmallVolumeInput(
            EF=0.1,
            AH=10.0,
            Ys=0.5,
            Sd=1.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    assert out.I is not None
    assert math.isclose(_mg_per_day(out.I), 0.5, rel_tol=1e-12)


# --- #45 OSHA Vapor PEL --------------------------------------------------


def test_osha_pel_vapor_picks_lesser_branch() -> None:
    """Cv = min(Cvk × (VP × Ys / MW) / (Vppel × Ypel / Mwpel), 1e6 × X × VP / 760)."""
    out = osha_pel_vapor(
        OshaVaporPelInput(
            Cvk=100.0,
            VP=10.0,
            Ys=0.5,
            MW=100.0,
            Vppel=20.0,
            Ypel=0.5,
            Mwpel=80.0,
            X=0.5,
            Vm=24.45,
            b=1.25,
            h=8.0,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    Cv1 = 100.0 * (10.0 * 0.5 / 100.0) / (20.0 * 0.5 / 80.0)
    Cv2 = 1_000_000.0 * 0.5 * 10.0 / 760.0
    Cv = min(Cv1, Cv2)
    Cm = Cv * 100.0 / 24.45
    expected_I = Cm * 1.25 * 8.0
    assert out.I is not None
    assert math.isclose(_mg_per_day(out.I), expected_I, rel_tol=1e-9)


# --- #54 Near-Field/Far-Field --------------------------------------------


def test_near_far_field_runs_and_yields_positive_intake() -> None:
    """Sanity-check the two-zone exponential model with realistic inputs.

    A 4×4×3 m near-field zone, 100 m³ far-field, 0.5 m/s NF velocity,
    AER 5/hr, G=0.001 g/s, h=8 hrs/day. Confirm finite & positive
    outputs (numerical hand-check is impractical for this many terms).
    """
    out = near_far_field(
        NearFarFieldInput(
            G=0.001,
            LNF=4.0,
            WNF=4.0,
            HNF=3.0,
            velocityNF=0.5,
            VFF=100.0,
            AER=5.0,
            h=8.0,
            b=1.25,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    assert out.I is not None
    val = _mg_per_day(out.I)
    assert math.isfinite(val) and val > 0.0


def test_near_far_field_zero_G_yields_zero_intake() -> None:
    """G=0 should make Cnf=0, hence I=0."""
    out = near_far_field(
        NearFarFieldInput(
            G=0.0,
            LNF=4.0,
            WNF=4.0,
            HNF=3.0,
            velocityNF=0.5,
            VFF=100.0,
            AER=5.0,
            h=8.0,
            b=1.25,
            ED=250.0,
            Y=40.0,
            BW=80.0,
            AT=40.0,
            ATc=78.0,
            NWexp=1.0,
            NS=1.0,
        )
    )
    assert out.I is not None
    assert _mg_per_day(out.I) == 0.0


# --- Coverage assertion ---------------------------------------------------


def test_dispatch_covers_every_exposure_model_in_seed_data() -> None:
    """All I/D-type ModelIDs in the seed DB must have a registered fn."""
    import sqlite3

    from chemsteer.settings import get_settings

    db = get_settings().seed_data_dir / "chmsteer.db"
    con = sqlite3.connect(db)
    seed_ids = {
        int(r[0])
        for r in con.execute(
            "SELECT ModelID FROM ListOfModels WHERE Type IN ('I','D') AND ModelID GLOB '[0-9]*';"
        )
    }
    con.close()
    missing = seed_ids - EXPOSURE_MODELS.keys()
    assert not missing, f"unimplemented exposure models: {sorted(missing)}"


def test_dispatch_registers_special_models() -> None:
    assert get_exposure_model(21) is small_volume_handling
    assert get_exposure_model(45) is osha_pel_vapor
    assert get_exposure_model(54) is near_far_field
