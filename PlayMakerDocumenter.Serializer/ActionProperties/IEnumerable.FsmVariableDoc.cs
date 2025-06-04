using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;
using PlayMakerDocumenter.Serializer.FsmVariables;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddPropertyRange(this FsmActionDoc action, IEnumerable<FsmVariableDoc> list)
    {
        if (list is null) return;
        action.TypeDetails.AddRange(list.ConvertToActionProperty());
    }
}