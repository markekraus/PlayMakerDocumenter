using System;
using Il2Cpp;
using UnityEngine;
using UUIDNext;

namespace PlayMakerDocumenter
{
    public static class GameObjectExtensions
    {
        public static string GetFullPath(this GameObject go)
        {
            if (go is null || go.transform is null) return "null";
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
            if(fsm is null){ return "null"; }
            var index = Array.IndexOf(fsm.gameObject.GetComponents<PlayMakerFSM>(), fsm);
            var go = fsm.GetFullPath();
            return Uuid.NewNameBased(FsmDocumenter.AppNamespace, $"{go}[{index}]").ToString();
        }
    }        
}
