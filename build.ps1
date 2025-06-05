pushd $PSScriptRoot

pushd .\UniverseLib
dotnet build .\src\UniverseLib.sln -c Release_IL2CPP_Interop_ML
popd
pushd .\MarkdownUtilities
.\build.ps1
popd


$Path = ".\Publish\PlayMakerDocumenter.ML.IL2CPP"
$Name = "PlayMakerDocumenter.ML.IL2CPP.dll"
$MDU = ".\Publish\PlayMakerDocumenter.ML.IL2CPP\MarkdownUtilities.net6.dll"
$Log = ".\Publish\PlayMakerDocumenter.ML.IL2CPP\PlayMakerDocumenter.Logging.ML.IL2CPP.dll"
$Util = ".\Publish\PlayMakerDocumenter.ML.IL2CPP\PlayMakerDocumenter.Utility.ML.IL2CPP.dll"
$Seri = ".\Publish\PlayMakerDocumenter.ML.IL2CPP\PlayMakerDocumenter.Serializer.ML.IL2CPP.dll"
$Lib1 = "..\..\MelonLoader\Il2CppAssemblies\"
$Lib2 = "..\..\MelonLoader\net6\"

Remove-Item -Path $Path -Force -Recurse -ErrorAction SilentlyContinue
dotnet publish .\PlayMakerDocumenter.slnx -c ML_Cpp_CoreCLR
ilrepack.exe /target:library /lib:$Path /lib:$Lib1 /lib:$Lib2 /internalize /out:$Path/$Name $Path\$Name $MDU $Log $Util $Seri

popd