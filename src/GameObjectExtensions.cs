using Il2Cpp;
using UnityEngine;

namespace PlayMakerDocumenter
{
    public static class GameObjectExtensions
    {
        public static string GetFullPath(this GameObject go) =>
            go is null
            ? "null"
            : go.transform.GetFullPath();
        public static string GetFullPath(this PlayMakerFSM fsm) =>
            fsm is null
            ? "null"
            : fsm.transform.GetFullPath();
        public static string GetFullPath(this Transform current) =>
            current is null
            ? "null"
            : current.parent is null
                ? "/" + current.name
                : current.parent.GetFullPath() + "/" + current.name;
    }        
}
