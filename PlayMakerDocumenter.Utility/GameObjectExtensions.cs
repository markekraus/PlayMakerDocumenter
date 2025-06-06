using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using UnityEngine;
using UUIDNext;

[assembly: InternalsVisibleTo("PlayMakerDocumenter.Serializer.ML.IL2CPP")]
[assembly: InternalsVisibleTo("PlayMakerDocumenter.ML.IL2CPP")]

namespace PlayMakerDocumenter
{
    public static class GameObjectExtensions
    {
        public const string AppNamespaceString = "c9d71ad1-b78e-4bc8-94cc-404db44cfd48";
        public static readonly Guid AppNamespace = new(AppNamespaceString);
        public static string GetFullPath(this GameObject go)
        {
            if (go is null) return "null";
            try { return go.transform.GetFullPath(); } catch { return "null"; }
        }
        public static string GetFullPath(this PlayMakerFSM fsm) =>
            fsm is null || fsm.transform is null
            ? "null"
            : fsm.transform.GetFullPath();
        public static string GetFullPath(this Transform current) =>
            current is null
            ? "null"
            : current.parent is null
                ? "/" + current.name
                : current.parent.GetFullPath() + "/" + current.name;
        internal static string GetUuid(this PlayMakerFSM fsm)
        {
            if (fsm is null) { return "null"; }
            var index = Array.IndexOf(fsm.gameObject.GetComponents<PlayMakerFSM>(), fsm);
            var go = fsm.GetFullPath();
            return Uuid.NewNameBased(AppNamespace, $"{go}[{index}]").ToString();
        }
    }
}
