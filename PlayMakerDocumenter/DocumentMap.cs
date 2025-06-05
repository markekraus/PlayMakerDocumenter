using System;
using System.IO;
using Il2Cpp;

namespace PlayMakerDocumenter;

internal record DocumentMap(string FileName, string GameObject, int ComponentIndex)
{
    public static DocumentMap Create(PlayMakerFSM fsm)
    {
        if (fsm is null) { throw new ArgumentNullException(nameof(fsm)); }

        var index = Array.IndexOf(fsm.gameObject.GetComponents<PlayMakerFSM>(), fsm);
        var go = fsm.GetFullPath();
        var name = fsm.GetUuid() + ".md";
        return new(name, go, index);
    }
}

internal static class DocumentMapExtensions
{
    public static string GetFullPath(this DocumentMap dm, DirectoryInfo directory) =>
        Path.Join(directory.FullName, dm.FileName);
}