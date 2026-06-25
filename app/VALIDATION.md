# Validation strategy

This rebuild targets **screening-level fidelity** to ChemSTEER v3.2 — agreement
to ~3 significant figures on User-Guide examples and known-good engineering
defaults. We use three layers of testing:

## 1. Hand-checked unit tests (live)

For every model in `chemsteer.calc.{release,exposure}`, the unit-test suite
under `tests/unit/` includes at least one test that:

- Computes the expected output in pure Python with the same constants and
  the same equation order as the equation string in
  `mdb/ChmSteer/tables/ListOfModels.csv`.
- Uses `math.isclose(..., rel_tol=1e-9)` to confirm the implementation
  matches that hand-computed value.

These are the strongest "is the math right" gate we have today. Examples:

- `test_drum_residual_user_guide_example` — drum-residual at 0.025 LF.
- `test_ap42_loading_against_hand_calculation` — full AP-42 nine-term
  numerator/denominator.
- `test_mass_balance_takes_lesser_of_two_Cv` — both Mass Balance branches.
- `test_water_saturation_hand_calculation`, `test_spent_bath_hand_calculation`,
  `test_rinse_water_hand_calculation` — the three special-shape release models.
- `test_dermal_2hand_liquid_user_guide_example` — full dermal rollup.

## 2. Property-based tests via Hypothesis (live)

Under `tests/property/`, Hypothesis stress-tests algebraic invariants that
must hold across the full input domain:

| Invariant | Where |
|---|---|
| `DR ≡ LF × Amt` for residual-shaped models | `test_release_invariants.py` |
| `AR ≡ DR × Freq × NS` (mass balance) | same |
| `DR ≥ 0` for non-negative inputs | same |
| `DR` scales linearly with `Amt` | same |
| Water-saturation `DR = WSchem × CF × Amt / 1000` | same |
| Spent-bath `DR = DVbath × 3.78 × Ybath × Dbath` | same |
| Rinse-water `RinseE = 1 ⇒ DR = 0` | same |
| `Dexp ≡ S × Qu × Wf × FT` for dermal models | `test_exposure_invariants.py` |
| `APDR ≡ Dexp / BW` (or `I / BW`) | same |
| `LADD ≤ ADD when ATc ≥ AT` | same |
| `NW ≡ NWexp × NS` | same |
| Inhalation `I = Cm × b × h` for KCk-based family | same |
| User-defined inhalation `Cm = Cv × MW / Vm × Ys` | same |

These do NOT validate against v3.2; they ensure the rebuild is internally
consistent with the equations as published.

### 2b. Unit conventions verified against the decompiled binary (1.1.0)

Two silent unit mismatches survived the published-equation checks above,
because the constants embed the unit conventions:

- Mass Balance (#22): the 1.7×10⁵ constant requires **Q in ft³/min**
  (`decompilation/source/ChemSteer/ExpModels.cs:388` indexes the global
  parm array at 53, whose std unit is ft³/min). Found and fixed in 1.1.0;
  the m³/hr coercion understated Cv by 1.699×.
- Penetration (#9) / Mass Transfer (#8): the 8.24e-8 / 1.93e-7 constants
  require **vz in ft/min** (`RelModels.cs:572` / `:662`, ParmID 69).

Lesson applied: every canonical input unit is now cross-checked against
`ListOfParms.StdUnits` (the binary reads raw stored values into its
formulas, so the stored unit IS the formula unit). The ParmID → field
translation layer (`calc/parm_map.py`) documents the remaining
deliberate conversions (NF/FF G in mg/hr, velocityNF in m/hr).

### 2c. Parameter-resolution + mass balance ported from source (1.2.0)

Two more v3.2 behaviours are now reproduced and pinned by hand-checked
tests:

- **Second-level `ParmDefaults` sentinels.** Negative `DefaultValue`
  entries dispatch to `GetParmDefaults.GetParmDefaultXXXX`
  (`ChemStrX.cs:2236-2420`). `calc/defaults.py` ports the
  per-output-characterization constants (e.g. -3111 drum-residue LF =
  0.025 CT / 0.03 HE, `GetParmDefault3111`) and the chemical-record
  pulls (-3108/-3109 → vapor pressure; MW/WSchem via the direct
  -1102/-1104 branch at `ChemStrX.cs:2127/2135`). Op-parameter
  references (-1101, -1107, …) that need a live operation context stay
  user-input. `tests/unit/test_defaults_sentinels.py` asserts each
  family against the decompiled constants.
- **Operation mass balance.** `calc/mass_balance.py` ports
  `frmMDUpdOpIP.CalcRest` (`:6471-6623`) and its rounding helpers —
  `MyRoundIt` (`:7074`, round(x+0.1) floor-1 + ≥5 % discrepancy
  warning) and `MassBalanceRoundUp` (`:7034`, ceiling). The OD > 365
  and Yprod ∉ (0,1] guards match lines 6533 / 6615.
  `tests/unit/test_mass_balance.py` checks each branch and the rounding
  edge cases.

## 3. Coverage assertions (live)

`tests/unit/test_remaining_release_models.py` and
`tests/unit/test_special_inhalation_models.py` each include a test that
queries the bundled seed DB for every R/I/D-typed `ModelID` and asserts
it has a registered Python function. **20/20 release + 18/18 exposure
models** pass this gate today.

## 4. Golden-master tests against v3.2 (deferred)

The plan called for capturing v3.2 outputs by automating the original
Windows GUI under Wine over a fixture matrix of inputs, then asserting
≤ 0.5 % relative error per model. That capture is its own multi-day
effort — running v3.2 needs:

- A Windows VM with .NET 4.0 + Crystal Reports runtime + the MS Access
  ODBC driver, OR
- A Wine prefix with all of the above (notoriously fragile).
- A scriptable way to drive ChemSTEER's WinForms UI (no public CLI;
  would need pyautogui / SendKeys-style automation, OR a small VB.NET
  driver compiled against the original assemblies).
- Access to v3.2's .cs2 save files so the input/output pairs are
  deterministic.

**Status: deferred to a follow-on task.** Until then, the
hand-checked + Hypothesis tests + the published "Common Engineering
Defaults" document together give us high confidence in the math itself
without v3.2 in the loop. Any user who needs strict v3.2 parity can
load a `.cs2` via `/api/imports/cs2`, run `/calc`, and compare the
resulting outputs with whatever v3.2 produced for that file (the
`ImportResult.skipped_runs` will flag any v3.2 model not yet
implemented here).

### Capture plan (when revisited)

1. Set up a Windows 10 VM (VirtualBox), install ChemSTEER v3.2.
2. Build a fixture matrix: ≥ 5 representative scenarios per model,
   covering known edge cases (saturation cap on Mass Balance, low/high
   air velocity branch on Mass Transfer vs Penetration, dust capture
   variants, etc.).
3. Hand-execute v3.2 on each fixture; export the IRER report (the
   built-in Crystal Reports output is the canonical v3.2 result).
4. Parse the IRER outputs into JSON; commit as
   `tests/golden/outputs/<scenario>.json`.
5. Add `tests/golden/test_against_v32.py`: load each fixture, run our
   calc, assert each output is within 0.5 % rel error of the captured
   value.

If any model exceeds the 0.5 % threshold, that's a real fidelity bug
that needs fixing in `chemsteer.calc.*` — *not* tolerance widening.
