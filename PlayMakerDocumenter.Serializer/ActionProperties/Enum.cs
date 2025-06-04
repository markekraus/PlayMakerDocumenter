using PlayMakerDocumenter.Serializer.FsmVariables;
using UnityEngine;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty<T>(this FsmActionDoc action, string Property, T Value) where T : System.Enum
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty(Property, $"{Value}");
    }
}