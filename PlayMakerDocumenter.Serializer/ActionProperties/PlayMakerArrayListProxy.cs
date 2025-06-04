using Il2Cpp;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, PlayMakerArrayListProxy Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.addEvent)}", Value.addEvent);
        action.AddProperty($"{Property}.{nameof(Value.arrayList)}", Value.arrayList);
        action.AddProperty($"{Property}.{nameof(Value.contentPreviewMaxRows)}", Value.contentPreviewMaxRows);
        action.AddProperty($"{Property}.{nameof(Value.condensedView)}", Value.condensedView);
        action.AddProperty($"{Property}.{nameof(Value.contentPreviewStartIndex)}", Value.contentPreviewStartIndex);
        action.AddProperty($"{Property}.{nameof(Value.enablePlayMakerEvents)}", Value.enablePlayMakerEvents);
        action.AddProperty($"{Property}.{nameof(Value.gameObject)}", Value.gameObject);
        action.AddProperty($"{Property}.{nameof(Value.name)}", Value.name);
        action.AddProperty($"{Property}.{nameof(Value.removeEvent)}", Value.removeEvent);
        action.AddProperty($"{Property}.{nameof(Value.setEvent)}", Value.setEvent);
        action.AddProperty($"{Property}.{nameof(Value.showContent)}", Value.showContent);
        action.AddProperty($"{Property}.{nameof(Value.showEvents)}", Value.showEvents);
    }
}