@echo off
cls
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
::Launchers
winget uninstall Valve.Steam -h
winget uninstall EpicGames.EpicGamesLauncher -h
winget uninstall Ubisoft.Connect -h

::Frameworks
winget uninstall Microsoft.dotnetRuntime.3-x64 -h
winget uninstall Microsoft.dotnetRuntime.5-x64 -h

::Drivers
winget uninstall AMD.RyzenMaster -h


::Uteís
winget uninstall Google.Chrome -h
winget uninstall RARLab.WinRAR
winget uninstall CPUID.CPU-Z -h
winget uninstall Microsoft.Office -h
winget uninstall Notepad++.Notepad++ -h

TIMEOUT /T 5
taskkill /f /im explorer.exe
start explorer.exe