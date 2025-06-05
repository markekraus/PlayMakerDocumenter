using Il2Cpp;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, PlayMakerProxyBase Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.enabled)}", Value.enabled);
        action.AddProperty($"{Property}.{nameof(Value.gameObject)}", Value.gameObject);
        action.AddProperty($"{Property}.{nameof(Value.name)}", Value.name);
        for (int i = 0; Value.TargetFSMs is not null && i < Value.TargetFSMs.Count; i++)
        {
            action.AddProperty($"{Property}.{nameof(Value.TargetFSMs)}[{i}]", Value.TargetFSMs[i]);
        }
        for (int i = 0; Value.playMakerFSMs is not null && i < Value.playMakerFSMs.Count; i++)
        {
            action.AddProperty($"{Property}.{nameof(Value.playMakerFSMs)}[{i}]", Value.playMakerFSMs[i]);
        }
    }
}