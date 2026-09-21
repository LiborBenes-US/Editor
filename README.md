Title: Editor

App Version: v1.0.0

A fast, lightweight, and efficient native Windows desktop text editor application for basic note-taking. 

Description: Basic Plain Text Editor. No Rich Text Features.

This README.md is submitted to https://github.com/LiborBenes-US by Dr. Libor Benes, M.A., on Sunday, September 20, 2026.

This desktop application for Windows was developed on Sunday, September 20, 2026.

This application was developed by Dr. Libor Benes, M.A., using Google AI Mode for C# code generation and for this README.md.

Support E-mail: Benes@iwp.edu

Features:
• Ultra-Lightweight: Uses less than 25 MB of RAM.
• High Performance: Built using native WinForms components for instant startup and zero typing latency.
• Double-Click Integration: Automatically opens and reads text files when associated via Windows file system settings.
• Enhanced Readability: Set to a clean Consolas font at size 16 for comfortable reading.

Security & Privacy:
Security-First. No Tracking. No Data Collection. No Telemetry. No Ads. Local to the PC, No Network Activity Following Install.

Requirements:
• Windows Operating System
• .NET Framework 4.0 or higher (Installed by default on almost all modern Windows PCs)

How to Compile from Source:
You do not need an advanced IDE like Visual Studio to compile this project. You can build it using the built-in C# compiler (`csc.exe`) included with Windows.

1. Open Command Prompt (`cmd`).
2. Navigate to the folder containing `Editor.cs`.
3. Run the following compilation command:

```cmd
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /target:winexe Editor.cs
```

A standalone executable named `Editor.exe` will be generated in the same directory.

How to Use as Default Editor:
To open your `.txt` files with this application automatically:
1. Right-click any `.txt` file.
2. Select Open with > Choose another app.
3. Scroll down and click Look for another app on this PC.
4. Select your compiled `Editor.exe`.
5. Check the box that says "Always use this app to open .txt files".
