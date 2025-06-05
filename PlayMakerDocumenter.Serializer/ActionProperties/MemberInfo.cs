using Il2CppSystem.Reflection;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, MemberInfo Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.DeclaringType)}", Value.DeclaringType);
        action.AddProperty($"{Property}.{nameof(Value.MemberType)}", Value.MemberType);
        action.AddProperty($"{Property}.{nameof(Value.Name)}", Value.Name);
        action.AddProperty($"{Property}.{nameof(Value.ToString)}", Value.ToString());
    }
}