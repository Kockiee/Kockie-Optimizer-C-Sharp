@echo off
cls
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
::Remove Apps
winget uninstall Microsoft.BingNews_8wekyb3d8bbwe -h
winget uninstall Microsoft.BingWeather_8wekyb3d8bbwe -h
winget uninstall Microsoft.GetHelp_8wekyb3d8bbwe -h
winget uninstall Microsoft.Getstarted_8wekyb3d8bbwe -h
winget uninstall Microsoft.MicrosoftOfficeHub_8wekyb3d8bbwe -h
winget uninstall Microsoft.MicrosoftSolitaireCollection_8wekyb3d8bbwe -h
winget uninstall Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe -h
winget uninstall Microsoft.People_8wekyb3d8bbwe -h
winget uninstall Microsoft.WindowsAlarms_8wekyb3d8bbwe -h
winget uninstall Microsoft.WindowsCamera_8wekyb3d8bbwe -h
winget uninstall Microsoft.WindowsMaps_8wekyb3d8bbwe -h
winget uninstall Microsoft.WindowsSoundRecorder_8wekyb3d8bbwe -h
winget uninstall Microsoft.YourPhone_8wekyb3d8bbwe -h
winget uninstall Microsoft.ZuneMusic_8wekyb3d8bbwe -h
winget uninstall Microsoft.ZuneVideo_8wekyb3d8bbwe -h
winget uninstall microsoft.windowscommunicationsapps_8wekyb3d8bbwe -h
winget uninstall Microsoft.Paint_8wekyb3d8bbwe -h
winget uninstall Microsoft.549981C3F5F10_8wekyb3d8bbwe -h
winget uninstall MicrosoftTeams_8wekyb3d8bbwe -h
winget uninstall Microsoft.Windows.Photos_8wekyb3d8bbwe -h
winget uninstall Microsoft.WindowsFeedbackHub_8wekyb3d8bbwe -h
winget uninstall Microsoft.PowerAutomateDesktop_8wekyb3d8bbwe -h
winget uninstall Microsoft.ScreenSketch_8wekyb3d8bbwe -h
winget uninstall Microsoft.OneDrive -h

TIMEOUT /T 5
taskkill /f /im explorer.exe
start explorer.exe