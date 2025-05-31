. .\build.ps1
Copy-Item -Force -Path .\Publish\PlayMakerDocumenter.ML.IL2CPP\PlayMakerDocumenter.ML.IL2CPP.dll -Destination ..\..\Mods\ -Verbose
Copy-Item -Force -Path .\Publish\PlayMakerDocumenter.ML.IL2CPP\UUIDNext.dll -Destination ..\..\UserLibs\ -Verbose
Get-Date