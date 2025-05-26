using System.Linq;
using UnityEngine;

namespace PlayMakerDocumenter
{
    internal static class Utility
    {
        public static T Get<T>(string name) where T : UnityEngine.Object
        {
            return Resources.FindObjectsOfTypeAll<T>().FirstOrDefault((T found) => found.name.Equals(name));
        }

        public static string GetFullPath(this Transform current)
        {
	        if (current.parent == null)
		    return "/" + current.name;
	        return current.parent.GetFullPath() + "/" + current.name;
        }
    }
}
