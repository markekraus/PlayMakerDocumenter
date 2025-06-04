using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, FsmEvent Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.Name)}", Value.Name);
        action.AddProperty($"{Property}.targetState", action.ctx.GetEventState(Value));
    }
}