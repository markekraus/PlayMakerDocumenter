using Il2CppHutongGames.PlayMaker;
using PlayMakerDocumenter.Serializer.FsmVariables;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, FsmBool Value)
    {
        if (action is null || Property is null) return;
        if (Value is null)
        {
            action.AddProperty(Property, "null");
            return;
        }
        action.AddProperty(Property, Value.Value);
    }
}