# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html) along with the 4th numeric from [NuGetVersion Semantic Versioning](https://learn.microsoft.com/en-us/nuget/concepts/package-versioning?tabs=semver20sort#where-nugetversion-diverges-from-semantic-versioning).

Major.Minor.Build are set manually per SemVer, and the 4th Revision is automatically generated via Visual Studio to try for getting unique build numbers.

## [Unreleased]

### Added

WIP on a system to support multiple Underrail versions in a single DLL release.
WIP adding this project to Github.
WIP getting Github build actions to run and create even a single DLL of the latest Underrail, or (ideally) create a copy of all supported DLLs.

## [1.0.0] - 2026-02-17

### Added

Initial implementation using code from `Game Speed Mod` by Rorkh on Github and Nexusmods.  First target was Underrail v1.3.0.15, and found that up to v1.3.0.17 worked fine.

### Changed

Created separate SpeedPatch.cs to contain SpeedPatch class that uses #if preprocessor directives to point to correct chunk of code based on UNDERRAIL defined constant.
Updated to net481 for latest support.