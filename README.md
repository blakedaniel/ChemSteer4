# ChemSTEER Extraction

Linux-based reverse-engineering of EPA's **ChemSTEER** (Chemical Screening
Tool for Exposures and Environmental Releases) v3.2, a Windows VB6 + MS
Access desktop tool used to support the TSCA New Chemicals Program.

ChemSTEER is a US federal-government work and is in the public domain
(17 USC §105). The installer is distributed openly by EPA at:

  https://www.epa.gov/sites/static/files/2019-09/install_chemsteerv3.2.exe

## Goal

Extract the data and decision logic compiled into the shipped Access
database and VB6 binary into a queryable, human-readable artifact tree —
the prerequisite work for a faithful web-app reimplementation.

The two specific gaps targeted are:

1. Per-Generic-Scenario parameter values pre-loaded in the Access DB
2. The model-selection decision tree compiled into the VB6 binary

Both are absent from the public ChemSTEER User Guide.

## Layout

```
installer/        raw downloaded installer + checksum
extracted/        1:1 unpacked installer contents (gitignored)
mdb/              dumped Access database
  tables/*.csv      one CSV per Access table
  schema.sql        SQLite-flavored schema
  chemsteer.sqlite  loaded SQLite DB (gitignored, regenerable)
  tables.md         per-table semantic notes
  scenarios.md      per-Generic-Scenario parameter sets
  queries.md        annotated MSysQueries dump
help/             decompiled .chm help file
  html/             raw HTML topics (gitignored, regenerable)
  topics.md         topic index
strings/          PE strings + import metadata
  categorized.md    categorized findings
decompilation/    Ghidra outputs
  forms/            extracted VB6 form layouts
  forms.md          form catalog
  model-selection.md  reconstructed decision tree
  cross-ref.md      DB-table ↔ decompiled-function map
scripts/          extraction helpers (CSV→SQLite loader, form parser, etc.)
MANIFEST.md       index of every artifact
```

## Reproduction

See [MANIFEST.md](MANIFEST.md) for the full step-by-step command log and
the source-installer SHA-256.

## Plan

The execution plan (with verification checks and out-of-scope items) is at
`~/.claude/plans/ok-lets-put-a-wobbly-codd.md`.

## Legal

ChemSTEER itself is public-domain US-government work. No EULA applies. No
DMCA §1201 anti-circumvention concern (no copyrighted material under
TPM). Third-party `.dll`/`.ocx` dependencies bundled by the installer
(if any) may carry separate licenses — those will be flagged in
`MANIFEST.md` as they're identified.
