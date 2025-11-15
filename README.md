# Happy-Android-ToolBox

Simple ToolBox For Android Phones

## Overview

A lightweight Windows Forms front-end that wraps adb to perform common Android device tasks. Provides device discovery, targeted operations (reboot, bootloader, recovery, factory reset), APK install/push/pull, batch install/uninstall, and quick diagnostics (dumpsys summaries). Commands run on background threads with centralized logging and busy-state handling for a responsive UI.

## Key Features

- Device discovery and selectable target using `adb devices -l`  
- Reboot: normal reboot, reboot to bootloader/download mode, reboot to recovery  
- Factory reset with two-step confirmation (type `FORMAT`) and fallback to recovery  
- APK install (single and batch) via `adb install -r` with per-APK results  
- File transfer: `adb push` and `adb pull` wrappers (files and folders)  
- Batch uninstall by comma-separated package names  
- Diagnostics: dumpsys battery, meminfo, and sensorservice with consolidated view  
- Robust adb detection: verifies `adb` on PATH or falls back to common Windows SDK locations  
- Thread-safe UI updates and detailed process reporting (exit code, stdout, stderr)

## Requirements

- Windows desktop with .NET runtime that supports WinForms  
- Android Platform Tools (adb) installed and either:
  - Added to PATH (recommended), or
  - Located in one of: `C:\platform-tools\adb.exe`, `C:\Program Files (x86)\Android\platform-tools\adb.exe`, `C:\Program Files\Android\platform-tools\adb.exe`  
- USB debugging enabled on device and device authorized

## Quick Start

1. Build and run the WinForms application.  
2. Click **Refresh devices** to list connected devices. Select a device to target operations or leave none selected to target any device.  
3. Common actions:
   - Reboot: Click **Reboot**  
   - Reboot to bootloader: Click **Downloadmode**  
   - Reboot to recovery: Click **Recovery**  
   - Factory reset: Click **Format** and type `FORMAT` to confirm  
   - Install APK: Click **Choose APK**, select file, then **Install**  
   - Batch install: Click **Batch Install** and select multiple APKs  
   - Push / Pull files: Click **Push File** / **Pull File** and follow prompts  
   - Batch uninstall: Click **Batch Uninstall** and enter package names (comma-separated)  
   - Diagnostics: Click **Show Device Info** to collect dumpsys summaries  
4. Use the log pane for timestamped command output, exit codes, and stderr.

Example manual check:
```
adb devices -l
```

## Implementation Notes

- Adb calls use RunAdbCommandAsync which starts a Process, captures stdout/stderr, and applies a timeout to avoid hangs.  
- Controls are null-checked so the form can be adapted without breaking logic.  
- Helpers: SetBusy, AppendLog, GetDumpsysAsync, InstallApkAsync, PushFileAsync, PullFileAsync, BatchInstallAsync, BatchUninstallAsync.

## Extending

- Add more dumpsys services or custom shell commands via GetDumpsysAsync.  
- Replace Process-based adb calls with a managed adb library for parallel/more advanced control.  
- Improve adb output parsing or add device-specific workflows (rooted vs non-rooted).

## License

Choose and add a license file (e.g., MIT or Apache-2.0) to the repository root.
