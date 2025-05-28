pushd .\UniverseLib
dotnet build .\src\UniverseLib.sln -c Release_IL2CPP_Interop_ML
popd
pushd .\MarkdownUtilities
.\build.ps1
popd

# pushd .\src

$Path = ".\Release\PlayMakerDocumenter.ML.IL2CPP"
$Name = "PlayMakerDocumenter.ML.IL2CPP.dll"
$MarkdownUtilities = ".\MarkdownUtilities\Release\MarkdownUtilities.net6\MarkdownUtilities.net6.dll"
$Lib1 = "..\..\MelonLoader\Il2CppAssemblies\"
$Lib2 = "..\..\MelonLoader\net6\"
$Lib3 = ".\MarkdownUtilities\Release\MarkdownUtilities.net6\"

Remove-Item -Path $Path -Force -Recurse -ErrorAction SilentlyContinue
dotnet build .\PlayMakerDocumenter.slnx -c ML_Cpp_CoreCLR
# ilrepack.exe /target:library /lib:$Path /lib:$Lib1 /lib:$Lib2 /internalize /out:$Path/PlayMakerDocumenter.ML.IL2CPP.dll $Path\PlayMakerDocumenter.ML.IL2CPP.dll $UniverseLib
ilrepack.exe /target:library /lib:$Path /lib:$Lib1 /lib:$Lib2 /lib:$Lib3 /internalize /out:$Path/$Name $Path\$Name $MarkdownUtilities

# popd