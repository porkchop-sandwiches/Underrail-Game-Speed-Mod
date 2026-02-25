# Underrail Game Speed Mod

Increases the amount by which the game speeds up when you press the speed up key (plus).

## Versions

These Underrail versions are currently supported:
- 1.3.1.0
- 1.3.0.17, 1.3.0.16, 1.3.0.15

Support for v1.2.0.23 could be looked at if someone requested it.

## Installation

1. Install BepInEx mod framework from Nexus (https://www.nexusmods.com/underrailexpedition/mods/10)
2. Download mod dll from release
3. Move mod in BepInEx\plugins folder

## Usage

In order for this mod to work you need to run the game by executing BepInEx.NET.Framework.Launcher.exe so mod can be loaded.

### Configuration

You can configure the mod (speed multiplier) in BepInEx/config/SpeedUp.cfg file.

## Building from source

1. Use Visual Studio or Visual Studio Code with C# plugin.
1. Get a copy of the BepInEx project from Nexusmods.
1. Unzip the BepInEx project to your Underrail install directory.
1. Place a copy of your underrail.exe file in BepInEx/lib/ directory.  Rename file to include version number at the end such as: underrail_1.3.0.17.exe.
1. Open Solution.
1. Choose a Build configuration related to your Underrail version.  Release = latest, or v1.3.1.0, and the rest include version number.
1. Set platform to AnyCPU for ease, only use x86 if you have trouble.
1. Build solution.
1. Copy SpeedUp_YOURUNDERRAILVERSION.dll from bin/Release/ or bin/Release_YOURUNDERRAILVERSION/ to your BepInEx/plugin/ directory.
1. Run Underrail by executing BepInEx.NET.Framework.Launcher.exe so that mod is loaded and config (.cfg) file is created.

## Troubleshooting

In case you get error when executing BepInEx launcher, move BepInEx/core/SemanticVersioning.dll to the Underrail root folder where launcher is located.

Clean up extra copies of SpeedUp DLL in the lib folder.  You should only have one of each with a version suffix same as your Underrail version.  Haven't come up with a way yet to have a single DLL that could load and support multiple versions of Underrail.

## Credits

- onlynumbersandletters: Creator of the BepInEx project for Underrail that powers this mod patch, and the example GameplayChangesMod project that was a great example to follow.
- Flutterschei: Creator of the `A collection of small modifications in the form of BepInEx patches` mod that had the ForceRestockPatch this mod is based on.
- Rorkh: Creator of the `Game Speed Mod` on Github and Nexusmods.  Another good example project to follow and very useful mod that can replace Cheat Engine speed modifications.