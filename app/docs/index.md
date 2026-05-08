# ChemSTEER (Python web app)

Python web reimplementation of EPA's
[ChemSTEER](https://www.epa.gov/tsca-screening-tools/chemsteer-chemical-screening-tool-exposures-and-environmental-releases),
the Chemical Screening Tool for Exposures and Environmental Releases.

## What this is

A modern web app that produces the same screening-level estimates
ChemSTEER v3.2 does — release rates to air/water/land, occupational
inhalation and dermal exposures — using the same model registry and
parameter defaults that ship with v3.2.

## What it isn't

- Not a regulatory replacement. v3.2 remains the EPA reference until
  EPA blesses an alternative.
- Not a clone of the desktop UI. The model selection is data-driven
  in v3.2 too, but the UI is rebuilt for the web.

## Getting started

See `../README.md` in the repo root.

## See also

- The build plan: `~/.claude/plans/ok-lets-put-a-wobbly-codd.md`
- Extraction artifacts (model registry, equations, parameter defaults):
  `../mdb/`, `../decompilation/`, `../help/`
