using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, DelayedEvent Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.delay)}", Value.delay);
        action.AddProperty($"{Property}.{nameof(Value.eventFired)}", Value.eventFired);
        action.AddProperty($"{Property}.{nameof(Value.eventData)}", Value.eventData);
        action.AddProperty($"{Property}.{nameof(Value.Finished)}", Value.Finished);
        action.AddProperty($"{Property}.{nameof(Value.FsmEvent)}", Value.FsmEvent);
        action.AddProperty($"{Property}.{nameof(Value.Timer)}", Value.Timer);
    }
}