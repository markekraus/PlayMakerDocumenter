pushd $PSScriptRoot

pushd .\UniverseLib
dotnet build .\src\UniverseLib.sln -c Release_IL2CPP_Interop_ML
popd
pushd .\MarkdownUtilities
.\build.ps1
popd


$Path = ".\Publish\PlayMakerDocumenter.ML.IL2CPP"
$Name = "PlayMakerDocumenter.ML.IL2CPP.dll"
$MarkdownUtilities = ".\Publish\PlayMakerDocumenter.ML.IL2CPP\MarkdownUtilities.net6.dll"
$Lib1 = "..\..\MelonLoader\Il2CppAssemblies\"
$Lib2 = "..\..\MelonLoader\net6\"

Remove-Item -Path $Path -Force -Recurse -ErrorAction SilentlyContinue
dotnet publish .\PlayMakerDocumenter.slnx -c ML_Cpp_CoreCLR
ilrepack.exe /target:library /lib:$Path /lib:$Lib1 /lib:$Lib2 /internalize /out:$Path/$Name $Path\$Name $MarkdownUtilities

popd