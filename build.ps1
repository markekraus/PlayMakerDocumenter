$Path = "bin\Release\net6\publish"
$Lib1 = "..\..\MelonLoader\Il2CppAssemblies\"
$Lib2 = "..\..\MelonLoader\net6\"

Remove-Item -Path $Path -Force -Recurse -ErrorAction SilentlyContinue
dotnet publish -c Release
ilrepack.exe /target:library /lib:$Path /lib:$Lib1 /lib:$Lib2 /internalize /out:$Path/PlayMakerDocumenter.ML.IL2CPP.CoreCLR.dll $Path\PlayMakerDocumenter.dll
