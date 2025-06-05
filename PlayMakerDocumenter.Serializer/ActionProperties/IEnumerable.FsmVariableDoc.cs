using System.Collections.Generic;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddPropertyRange(this FsmActionDoc action, IEnumerable<FsmVariableDoc> list)
    {
        if (list is null) return;
        action.TypeDetails.AddRange(list.ConvertToActionProperty());
    }
}