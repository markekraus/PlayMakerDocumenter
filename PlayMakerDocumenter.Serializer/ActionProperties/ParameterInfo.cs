using Il2CppSystem.Reflection;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, ParameterInfo Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.Attributes)}", Value.Attributes);
        action.AddProperty($"{Property}.{nameof(Value.DefaultValue)}", Value.DefaultValue.ToString());
        action.AddProperty($"{Property}.{nameof(Value.IsIn)}", Value.IsIn);
        action.AddProperty($"{Property}.{nameof(Value.IsOut)}", Value.IsOptional);
        action.AddProperty($"{Property}.{nameof(Value.IsOut)}", Value.IsOut);
        action.AddProperty($"{Property}.{nameof(Value.Member)}", Value.Member);
        action.AddProperty($"{Property}.{nameof(Value.Name)}", Value.Name);
        action.AddProperty($"{Property}.{nameof(Value.ParameterType)}", Value.ParameterType);
        action.AddProperty($"{Property}.{nameof(Value.Position)}", Value.Position);
        action.AddProperty($"{Property}.{nameof(Value.ToString)}", Value.ToString());
    }
}