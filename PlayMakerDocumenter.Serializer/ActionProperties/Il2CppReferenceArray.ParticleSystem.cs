using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, Il2CppReferenceArray<ParticleSystem> Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            action.AddProperty($"{Property}[{i}]", Value[i]);
        }
    }
}