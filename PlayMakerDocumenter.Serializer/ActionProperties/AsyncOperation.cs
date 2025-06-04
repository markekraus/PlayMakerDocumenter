using PlayMakerDocumenter.Serializer.FsmVariables;
using UnityEngine;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, AsyncOperation Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.allowSceneActivation)}", Value.allowSceneActivation);
        action.AddProperty($"{Property}.{nameof(Value.isDone)}", Value.isDone);
        action.AddProperty($"{Property}.{nameof(Value.priority)}", Value.priority);
        action.AddProperty($"{Property}.{nameof(Value.progress)}", Value.progress);
    }
}