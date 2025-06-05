namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, string Value)
    {
        if (action is null || Property is null) return;
        if (Value is null)
        {
            action.TypeDetails.Add(new(Property, "null"));
            return;
        }
        action.TypeDetails.Add(new(Property, Value));
    }
}