@echo off
cls
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
echo Isso pode demorar, não feche a janela !!!
::Install Apps
winget install Microsoft.BingNews_8wekyb3d8bbwe -h
winget install Microsoft.BingWeather_8wekyb3d8bbwe -h
winget install Microsoft.GetHelp_8wekyb3d8bbwe -h
winget install Microsoft.Getstarted_8wekyb3d8bbwe -h
winget install Microsoft.MicrosoftOfficeHub_8wekyb3d8bbwe -h
winget install Microsoft.MicrosoftSolitaireCollection_8wekyb3d8bbwe -h
winget install Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe -h
winget install Microsoft.People_8wekyb3d8bbwe -h
winget install Microsoft.WindowsAlarms_8wekyb3d8bbwe -h
winget install Microsoft.WindowsCamera_8wekyb3d8bbwe -h
winget install Microsoft.WindowsMaps_8wekyb3d8bbwe -h
winget install Microsoft.WindowsSoundRecorder_8wekyb3d8bbwe -h
winget install Microsoft.YourPhone_8wekyb3d8bbwe -h
winget install Microsoft.ZuneMusic_8wekyb3d8bbwe -h
winget install Microsoft.ZuneVideo_8wekyb3d8bbwe -h
winget install microsoft.windowscommunicationsapps_8wekyb3d8bbwe -h
winget install Microsoft.Paint_8wekyb3d8bbwe -h
winget install Microsoft.549981C3F5F10_8wekyb3d8bbwe -h
winget install MicrosoftTeams_8wekyb3d8bbwe -h
winget install Microsoft.Windows.Photos_8wekyb3d8bbwe -h
winget install Microsoft.WindowsFeedbackHub_8wekyb3d8bbwe -h
winget install Microsoft.PowerAutomateDesktop_8wekyb3d8bbwe -h
winget install Microsoft.ScreenSketch_8wekyb3d8bbwe -h
winget install Microsoft.OneDrive -h

TIMEOUT /T 5
taskkill /f /im explorer.exe
start explorer.exe