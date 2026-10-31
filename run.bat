@echo off
title CinePulse OTT Platform - ASP.NET MVC (.NET Framework 4.8)
echo ======================================================================
echo           CINEPULSE MOVIE STREAMING & CINEMA PLATFORM
echo               ASP.NET MVC 5 - .NET Framework 4.8
echo ======================================================================
echo.

set "IIS_PATH=%ProgramFiles%\IIS Express\iisexpress.exe"
if not exist "%IIS_PATH%" (
    set "IIS_PATH=%ProgramFiles(x86)%\IIS Express\iisexpress.exe"
)

if not exist "%IIS_PATH%" (
    echo [ERROR] IIS Express was not found on this computer.
    echo Please install IIS Express or run via Visual Studio.
    pause
    exit /b 1
)

echo [INFO] Starting IIS Express web server...
echo [INFO] Web Path : %~dp0
echo [INFO] Port     : 5215
echo [INFO] URL      : http://localhost:5215/
echo.
echo Launching your browser now...
start http://localhost:5215/

echo.
echo Press Ctrl+C in this window to stop the server when you are done.
echo.

"%IIS_PATH%" /path:"%~dp0." /port:5215
