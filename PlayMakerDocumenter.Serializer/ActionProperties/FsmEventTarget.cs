using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, FsmEventTarget Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.excludeSelf)}", Value.excludeSelf);
        action.AddProperty($"{Property}.{nameof(Value.fsmComponent)}", Value.fsmComponent);
        action.AddProperty($"{Property}.{nameof(Value.fsmName)}", Value.fsmName);
        action.AddProperty($"{Property}.{nameof(Value.gameObject)}", Value.gameObject);
        action.AddProperty($"{Property}.{nameof(Value.sendToChildren)}", Value.sendToChildren);
        action.AddProperty($"{Property}.{nameof(Value.target)}", Value.target);
    }
}