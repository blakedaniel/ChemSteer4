"""Second-level ParmDefaults sentinel resolution (GetParmDefaults.cs)."""

from __future__ import annotations

from chemsteer.calc.defaults import ChemicalProps, defaults_for, media_defaults_for

LF = 73
VP = 4
MW = 5
WSCHEM = 80
K_MIXING = 51


def test_drum_residue_lf_per_output_characterization() -> None:
    # ParmID 73 model 2 → -3111 → 0.025 CT / 0.03 HE (GetParmDefault3111).
    assert defaults_for(2, output=0)[LF] == 0.025
    assert defaults_for(2, output=1)[LF] == 0.03


def test_container_residue_lf_per_output() -> None:
    # ParmID 73 model 1 → -3110 → 0.0007 CT / 0.002 HE.
    assert defaults_for(1, output=0)[LF] == 0.0007
    assert defaults_for(1, output=1)[LF] == 0.002


def test_single_value_sentinels_shared_across_outputs() -> None:
    # Bulk transport (#3) "Conservative" 0.02; small containers (#6) 0.01.
    for output in (0, 1):
        assert defaults_for(3, output=output)[LF] == 0.02
        assert defaults_for(6, output=output)[LF] == 0.01


def test_mass_balance_mixing_factor_per_output() -> None:
    # ParmID 51 model 22 → -3106 → k = 0.5 CT / 0.1 HE (GetParmDefault3106).
    assert defaults_for(22, output=0)[K_MIXING] == 0.5
    assert defaults_for(22, output=1)[K_MIXING] == 0.1


def test_chemical_record_supplies_vp_mw_solubility() -> None:
    chem = ChemicalProps(mw=72.1, vp_torr=10.0, solubility_g_l=2.5)
    d = defaults_for(22, chemical=chem)  # Mass Balance: VP via -3109
    assert d[VP] == 10.0
    assert d[MW] == 72.1
    assert d[WSCHEM] == 2.5


def test_no_chemical_record_leaves_chemical_parms_unset() -> None:
    d = defaults_for(22)
    assert VP not in d
    assert MW not in d
    assert WSCHEM not in d


def test_op_parm_reference_sentinels_stay_unset() -> None:
    # ParmID 92 (Amt) model 1 → -1101 (op-parm reference): without an
    # operation context it must NOT leak a bogus value.
    assert 92 not in defaults_for(1)


def test_media_defaults() -> None:
    # MediaDefaults: model 41 → 4 % Air + 96 % Incineration-or-Landfill;
    # model 2 → 100 % Water; model 22 (exposure) ships none.
    assert media_defaults_for(41) == {0: 4.0, 8: 96.0}
    assert media_defaults_for(2) == {13: 100.0}
    assert media_defaults_for(22) == {}
