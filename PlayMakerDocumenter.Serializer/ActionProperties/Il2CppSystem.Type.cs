using Il2CppSystem;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, Type Value)
    {
        if (action is null || Property is null) return;
        action.AddProperty(Property, Value is null ? "null" : Value.FullName);
    }
}