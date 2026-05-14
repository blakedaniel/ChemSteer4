#!/usr/bin/env bash
# install-toolchain.sh — Tier-1 extraction toolchain for ChemSTEER RE work.
#
# Run this once (with sudo) before extraction begins. Idempotent — safe to
# re-run. If a package fails to install, the script reports it and continues
# with the rest, then exits non-zero so failures aren't silently lost.
#
# Usage:
#   ./scripts/install-toolchain.sh
#
# Requires: a Debian/Ubuntu system with apt, and sudo privileges.

set -uo pipefail

cd "$(dirname "$0")/.."

if [[ $EUID -eq 0 ]]; then
    SUDO=""
else
    SUDO="sudo"
fi

# --- apt packages ---------------------------------------------------------
APT_PKGS=(
    mdbtools          # mdb-tables, mdb-schema, mdb-export — read Access .mdb
    p7zip-full        # 7z — unpack NSIS/InstallShield/MSI/CAB
    innoextract       # Inno Setup installers (fallback)
    cabextract        # CAB / InstallShield (fallback)
    unshield          # InstallShield archives (fallback)
    msitools          # msiextract for MSI (fallback)
    binwalk           # signature-based archive probe (last resort)
    icoutils          # wrestool — extract PE resources for VB6 form parsing
    archmage          # .chm help-file decompiler
    sqlite3           # build chemsteer.sqlite from CSVs
)

echo ">>> Updating apt package lists..."
$SUDO apt-get update -qq

echo ">>> Installing Tier-1 packages..."
FAILED_PKGS=()
for pkg in "${APT_PKGS[@]}"; do
    if dpkg -s "$pkg" >/dev/null 2>&1; then
        echo "    [skip] $pkg already installed"
        continue
    fi
    if $SUDO apt-get install -y --no-install-recommends "$pkg" >/dev/null 2>&1; then
        echo "    [ok]   $pkg"
    else
        echo "    [FAIL] $pkg"
        FAILED_PKGS+=("$pkg")
    fi
done

# --- pip packages ---------------------------------------------------------
# Installed --user so this doesn't need root.
PIP_PKGS=(pandas_access pefile)

echo ">>> Installing pip packages (--user)..."
FAILED_PIP=()
for pkg in "${PIP_PKGS[@]}"; do
    if python3 -c "import ${pkg//-/_}" >/dev/null 2>&1; then
        echo "    [skip] $pkg already importable"
        continue
    fi
    if pip3 install --user --quiet "$pkg" >/dev/null 2>&1; then
        echo "    [ok]   $pkg"
    else
        echo "    [FAIL] $pkg"
        FAILED_PIP+=("$pkg")
    fi
done

# --- summary --------------------------------------------------------------
echo
echo ">>> Verifying tool availability..."
TOOLS=(mdb-tables mdb-schema mdb-export 7z innoextract msiextract cabextract \
       unshield binwalk wrestool archmage sqlite3)
MISSING=()
for tool in "${TOOLS[@]}"; do
    if command -v "$tool" >/dev/null 2>&1; then
        printf "    %-15s OK  (%s)\n" "$tool" "$(command -v "$tool")"
    else
        printf "    %-15s MISSING\n" "$tool"
        MISSING+=("$tool")
    fi
done

echo
if [[ ${#FAILED_PKGS[@]} -eq 0 && ${#FAILED_PIP[@]} -eq 0 && ${#MISSING[@]} -eq 0 ]]; then
    echo ">>> All Tier-1 tools installed. Ready to extract."
    exit 0
else
    [[ ${#FAILED_PKGS[@]} -gt 0 ]] && echo "!!! apt failures: ${FAILED_PKGS[*]}"
    [[ ${#FAILED_PIP[@]}  -gt 0 ]] && echo "!!! pip failures: ${FAILED_PIP[*]}"
    [[ ${#MISSING[@]}     -gt 0 ]] && echo "!!! still missing: ${MISSING[*]}"
    exit 1
fi
