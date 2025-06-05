namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, int Value)
    {
        if (action is null || Property is null) return;
        action.AddProperty(Property, $"{Value}");
    }
}