pushd .\src

$Path = "..\Release\PlayMakerDocumenter.ML.IL2CPP\"
$Lib0 = "..\Release\PlayMakerDocumenter.ML.IL2CPP\publish\"
$Lib1 = "..\..\..\MelonLoader\Il2CppAssemblies\"
$Lib2 = "..\..\..\MelonLoader\net6\"

Remove-Item -Path $Path -Force -Recurse -ErrorAction SilentlyContinue
dotnet publish -c ML_Cpp
ilrepack.exe /target:library /lib:$Path /lib:$Lib0 /lib:$Lib1 /lib:$Lib2 /internalize /out:$Path/PlayMakerDocumenter.ML.IL2CPP.dll $Path\PlayMakerDocumenter.ML.IL2CPP.dll

popd