"""ChemSTEER: Python reimplementation of EPA's Chemical Screening Tool for
Exposures and Environmental Releases."""

from importlib.metadata import PackageNotFoundError, version

try:
    __version__ = version("chemsteer")
except PackageNotFoundError:
    __version__ = "0.0.0+dev"
