using Il2Cpp;
using UnityEngine;

namespace PlayMakerDocumenter
{
    public static class GameObjectExtensions
    {
        public static string GetFullPath(this GameObject go)
        {
            return go.transform.GetFullPath();
        }
        public static string GetFullPath(this PlayMakerFSM fsm)
        {
            return fsm.transform.GetFullPath();
        }
        public static string GetFullPath(this Transform current)
        {
            if (current.parent == null)
                return "/" + current.name;
            return current.parent.GetFullPath() + "/" + current.name;
        }
    }        
}
