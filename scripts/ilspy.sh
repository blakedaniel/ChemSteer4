#!/usr/bin/env bash
# ilspy.sh — wrapper that sets up DOTNET env and forwards to ilspycmd.
# Saves having to remember DOTNET_ROOT / PATH / DOTNET_ROLL_FORWARD across
# fresh shells.
export DOTNET_ROOT="$HOME/.dotnet"
export PATH="$HOME/.dotnet:$HOME/.dotnet/tools:$PATH"
export DOTNET_ROLL_FORWARD=Major
exec ilspycmd "$@"
