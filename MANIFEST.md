# MANIFEST

Running index of every artifact in this workspace, plus the commands used
to produce them. Updated as work progresses.

## Source

| Artifact | URL | SHA-256 | Size |
|---|---|---|---|
| `installer/install_chemsteerv3.2.exe` | https://www.epa.gov/sites/default/files/2019-09/install_chemsteerv3.2.exe | `e158757a97804ac6e9ab48175ecdc35993d52776fa387c5ebea0c7cf307204c5` | 168 276 308 B |

(Note: the older `sites/static/...` URL is dead; `sites/default/...` is the
current live path. Both are documented in the original research report.)

## Toolchain

| Tool | Source | Notes |
|---|---|---|
| `mdbtools` | `apt install mdbtools` | `mdb-tables`, `mdb-export`, `mdb-schema` |
| `p7zip-full` | `apt install p7zip-full` | unpacked the NSIS installer |
| `innoextract`, `cabextract`, `unshield`, `msitools`, `binwalk` | apt | extraction fallbacks (not needed for this installer) |
| `icoutils` | `apt install icoutils` | `wrestool` for PE resource dumps |
| `archmage` | `apt install archmage` | `.chm` decompilation |
| `sqlite3` | `apt install sqlite3` | DB loading + querying |
| `pandas_access` | `pip install --user` | Python MS Access reader |
| `pefile` | `pip install --user` | PE header inspection |

Driven by `scripts/install-toolchain.sh`.

## Installer composition

The downloaded `install_chemsteerv3.2.exe` is a **Nullsoft (NSIS)
installer** that bundles a layered set of MSIs:

| File (under `extracted/$TEMP/`) | Size | Purpose |
|---|---:|---|
| `ChemSteer.msi` | 43 MB | The actual ChemSTEER application (a .NET 4.0 / VB.NET app, **not** native VB6 as initially assumed) |
| `CRRuntime_32bit_13_0_3.msi` | 75 MB | Crystal Reports runtime |
| `dotNetFx40_Full_x86_x64.exe` | 50 MB | .NET 4.0 framework redistributable |
| `vcredist_x86.exe` | 2.7 MB | VC++ redistributable |
| `Windows6.1-KB917607-x86.msu` | 0.7 MB | Win update (HTML help compiler) |
| `setup.exe` | 0.4 MB | Bootstrapper |

`ChemSteer.msi` was extracted to `extracted/msi-app/` with `msiextract`.

### Application binary

`extracted/msi-app/ChemSteer.exe` is identified as
`PE32 executable (GUI) Intel 80386 Mono/.Net assembly` — i.e. a managed
.NET assembly. This dramatically simplifies Tier 2 decompilation: instead
of Ghidra + VB6 P-code reversing, `ilspycmd` will recover near-source
C#/VB.NET output. Plan amended accordingly.

### `.epa` files

Three `.epa` files in the install dir are **renamed Microsoft Access
databases**:

| File | Role | Tables | Notable rows |
|---|---|---:|---|
| `ChmSteer.epa` | Master reference DB (model registry, parameter defaults, NAICS, PEL/REL limits) | 25 | 38 models, 72 activities, 298 valid-model edges, 249 parameter defaults, 1814 NAICS codes, 652 PEL/REL/TWA chemical limits |
| `MDBShell.epa` | Empty assessment-template DB (becomes a user's `.cs2` file when populated) | 29 | 36 base models, 90 codes, 57 states, plus 26 empty user-data tables |
| `scenarios.epa` | Generic Scenarios DB (the 34 GSs that ship with v3.2) | 11 | 34 scenarios, 159 activities, 74 exposure models, 137 release models, 4 992 op-parm rows, 9 346 act-rel-parm rows |

**The model equations are stored as plain text in `ListOfModels.Equation`** —
the goal of "recover the model equations from the binary" is satisfied by
the database alone, before any decompilation.

## Generated artifacts

| Path | Description |
|---|---|
| `mdb/<db>/<db>.sqlite` | Per-DB SQLite copy, all tables loaded |
| `mdb/<db>/tables/<T>.csv` | Per-table CSV dump (proper quoting via Python csv) |
| `mdb/<db>/manifest.json` | Per-table row count + columns list |
| `mdb/<db>/schema.sql` | SQLite-flavored schema (mdb-schema output) |
| `mdb/tables.md` | Per-table semantic catalog across all three DBs |
| `mdb/scenarios.md` | The 34 Generic Scenarios with their activity/model attachment counts |

## Scripts

| Script | Purpose |
|---|---|
| `scripts/install-toolchain.sh` | Idempotent apt + pip install of Tier-1 tools |
| `scripts/dump-mdb.py` | Python-based dump of all `.epa` → CSV + SQLite (with mdb-export tab-delim fallback for tables that break pandas_access dtype inference) |
| `scripts/build-docs.py` | Renders `mdb/tables.md` + `mdb/scenarios.md` from the SQLite dumps |

(Note: an earlier `scripts/dump-mdb.sh` was deleted in favor of the Python
version because SQLite's `.import` lost rows on tables containing
multi-line text fields.)

## Command log

```
# 1. Workspace + git init
git init
git symbolic-ref HEAD refs/heads/main
mkdir -p installer extracted mdb/tables help/html strings decompilation/forms scripts

# 2. Install toolchain
./scripts/install-toolchain.sh   # ran with sudo

# 3. Download installer
wget -O installer/install_chemsteerv3.2.exe \
  https://www.epa.gov/sites/default/files/2019-09/install_chemsteerv3.2.exe

# 4. Unpack the NSIS layer
7z x -o./extracted -y ./installer/install_chemsteerv3.2.exe

# 5. Unpack the .NET application MSI
msiextract -C extracted/msi-app extracted/\$TEMP/ChemSteer.msi

# 6. Dump every .epa to CSV + SQLite
python3 scripts/dump-mdb.py

# 7. Render per-DB / per-scenario documentation
python3 scripts/build-docs.py
```
