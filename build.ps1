pushd UniverseLib
dotnet build .\src\UniverseLib.sln -c Release_IL2CPP_Interop_ML
popd

# pushd .\src

$Path = ".\Release\PlayMakerDocumenter.ML.IL2CPP"
# $UniverseLib = "..\Release\PlayMakerDocumenter.ML.IL2CPP\publish\UniverseLib.IL2CPP.Interop.dll"
$Lib1 = "..\..\MelonLoader\Il2CppAssemblies\"
$Lib2 = "..\..\MelonLoader\net6\"

Remove-Item -Path $Path -Force -Recurse -ErrorAction SilentlyContinue
dotnet build .\PlayMakerDocumenter.slnx -c ML_Cpp_CoreCLR
# ilrepack.exe /target:library /lib:$Path /lib:$Lib1 /lib:$Lib2 /internalize /out:$Path/PlayMakerDocumenter.ML.IL2CPP.dll $Path\PlayMakerDocumenter.ML.IL2CPP.dll $UniverseLib
ilrepack.exe /target:library /lib:$Path /lib:$Lib1 /lib:$Lib2 /internalize /out:$Path/PlayMakerDocumenter.ML.IL2CPP.dll $Path\PlayMakerDocumenter.ML.IL2CPP.dll

# popd