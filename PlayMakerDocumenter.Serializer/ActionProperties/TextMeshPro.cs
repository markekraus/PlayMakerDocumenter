using Il2CppTMPro;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, TextMeshPro Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.enabled)}", Value.enabled);
        action.AddProperty($"{Property}.{nameof(Value.gameObject)}", Value.gameObject);
        action.AddProperty($"{Property}.{nameof(Value.name)}", Value.name);
        action.AddProperty($"{Property}.{nameof(Value.text)}", Value.text);
    }
}