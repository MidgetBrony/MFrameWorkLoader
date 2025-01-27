# MFrameworkLoader

MFrameworkLoader is a mod for [MelonLoader](https://melonwiki.xyz/) designed to dynamically load .NET 6.0 framework assemblies required by the game or modded features. It is specifically tailored for the game "DesktopMate" developed by "infiniteloop." This mod helps ensure that the necessary .NET runtime libraries are accessible for use within the game environment.

## Features

- Dynamically locates and loads .NET 6.0 runtime assemblies.
- Logs loaded assemblies to help identify any missing or failed dependencies.
- Provides error handling and descriptive messages if the required framework is not installed.

## Prerequisites

Before using MFrameworkLoader, ensure that the following requirements are met:

1. [MelonLoader](https://melonwiki.xyz/) must be installed.
2. .NET 6.0 Runtime must be installed. You can download it from [Microsoft's .NET page](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

## Installation

1. Download the compiled `MFrameworkLoader.dll` file.
2. Place the `.dll` file into the `Mods` folder of your MelonLoader installation.
3. Ensure that the game "DesktopMate" is installed and configured with MelonLoader.

## Usage

1. Launch the game "DesktopMate" with MelonLoader.
2. The mod will automatically attempt to locate and load the .NET 6.0 framework assemblies.
3. Logs will indicate the status of the framework loading process:
   - Successfully loaded assemblies.
   - Errors if .NET 6.0 is not installed or specific DLLs fail to load.

## Logging Output

- **Success:** Logs the name of each successfully loaded assembly.
- **Error:** Logs detailed error messages for missing framework directories or failed assembly loads.

### Example Log Output

```plaintext
Getting Framework...
Loaded: System.Windows.Forms.dll
Loaded: System.Drawing.dll
...
Failure to Load Libraries, is .NET 6.0 Installed?
```

## Troubleshooting

- **Framework directory not found:**
  Ensure that .NET 6.0 is installed on your machine. The mod checks the default installation path under `Program Files/dotnet/shared`.

- **Specific DLLs fail to load:**
  Check if the correct version of .NET 6.0 is installed. This mod specifically looks for version `6.0.36`.

- **General errors:**
  Confirm that the target framework (`Microsoft.WindowsDesktop.App`) and version (`6.0.36`) match your system's installed version.

## Contributing

Contributions are welcome! If you encounter issues or have ideas for improvements, feel free to open an issue or submit a pull request on the project's GitHub repository.

## License

This project is licensed under the GNU General Public License v3.0 (GPL-3.0). See the `LICENSE` file for details.

## Credits

- Developed by: MidgetBrony
- Game: Desktop Mate by infiniteloop
