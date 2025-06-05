using UnityEngine;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, Animator Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.enabled)}", Value.enabled);
        action.AddProperty($"{Property}.{nameof(Value.gameObject)}", Value.gameObject);
        action.AddProperty($"{Property}.{nameof(Value.name)}", Value.name);
    }
}