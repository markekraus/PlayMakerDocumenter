using System.Linq;
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
        public static Result<T, string> FindTypeFromParent<T>(string parent, string self) where T : MonoBehaviour
        {
            var result = GameObject.FindObjectsByType<T>(FindObjectsInactive.Include, FindObjectsSortMode.None)
                .FirstOrDefault(fsm => fsm.gameObject.name == self && fsm.gameObject.transform.parent.name == parent, null);
            return result is null
            ? Result<T, string>.Failure($"{parent}/{self}")
            : Result<T, string>.Success(result);
        }

        public static Result<T, string> Find<T>(string Name) where T : MonoBehaviour
        {
            var result = GameObject.Find("Global Manager").GetComponent<T>();
            return result is null
            ? Result<T, string>.Failure(Name)
            : Result<T, string>.Success(result);
        }
    }        
}
