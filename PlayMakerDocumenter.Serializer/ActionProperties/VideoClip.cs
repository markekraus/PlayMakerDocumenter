using UnityEngine.Video;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, VideoClip Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.name)}", Value.name);
        action.AddProperty($"{Property}.{nameof(Value.originalPath)}", Value.originalPath);
    }
}