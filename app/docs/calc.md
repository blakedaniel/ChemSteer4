# Calc engine

Per-model Python functions live under `src/chemsteer/calc/release/` and
`src/chemsteer/calc/exposure/`. Phase 0 ships scaffolding only; Phases
2 and 3 populate them.

Each model function:

- Accepts a Pydantic input with `pint.Quantity`-typed parameters.
- Returns a Pydantic output with the canonical ChemSTEER outputs
  (`DR`, `AR`, `NS`, `I`, `Dexp`, `LADD`, `ADD`, `APDR`).
- Has its raw equation text from `ListOfModels.Equation` as the
  function docstring.
- Is referenced by `ModelID` in the data-driven dispatcher
  (`calc/dispatch.py`).
