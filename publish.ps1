. .\build.ps1

$staging = ".\Publish\PlayMakerDocumenter"
$zip = ".\Publish\PlayMakerDocumenter.zip"
Remove-Item -Path $staging -Force -Recurse -ErrorAction SilentlyContinue
Remove-Item -Path $zip -Force -ErrorAction SilentlyContinue
$mods = Join-Path $staging "Mods"
$ulib = Join-Path $staging "UserLibs"
mkdir $staging
mkdir $mods
mkdir $ulib
Copy-Item -Force -Path .\Publish\PlayMakerDocumenter.ML.IL2CPP\PlayMakerDocumenter.ML.IL2CPP.dll -Destination $mods -Verbose
Copy-Item -Force -Path .\Publish\PlayMakerDocumenter.ML.IL2CPP\UUIDNext.dll -Destination $ulib -Verbose
Compress-Archive -Path "$staging\*" -DestinationPath $zip -CompressionLevel Optimal -Force

Copy-Item -Force -Path .\Publish\PlayMakerDocumenter.ML.IL2CPP\PlayMakerDocumenter.ML.IL2CPP.dll -Destination ..\..\Mods\ -Verbose
Copy-Item -Force -Path .\Publish\PlayMakerDocumenter.ML.IL2CPP\UUIDNext.dll -Destination ..\..\UserLibs\ -Verbose
Get-Date