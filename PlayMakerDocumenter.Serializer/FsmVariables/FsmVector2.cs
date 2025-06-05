using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter.Serializer.FsmVariables;

internal static partial class FsmVariableExtensions
{
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmVector2 fsmVar) =>
        fsmVar.GetValue(fsmVar.Name);
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmVector2 fsmVar, string Property)
    {
        if (fsmVar is null) yield break;
        yield return new(Property + ".x", fsmVar.GetActualType().Name, $"{fsmVar.Value.x}");
        yield return new(Property + ".y", fsmVar.GetActualType().Name, $"{fsmVar.Value.y}");
    }
}