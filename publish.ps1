dotnet publish -c Release
Copy-Item -Force -Path .\bin\Release\net6\*.dll -Destination ..\..\Mods\ -Verbose
Get-Date