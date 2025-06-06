using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter.Serializer.FsmVariables;

internal static partial class FsmVariableExtensions
{
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmTexture fsmVar) =>
        fsmVar.GetValue(fsmVar.Name);
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmTexture fsmVar, string Property)
    {
        if (fsmVar is null) yield break;
        yield return fsmVar.Value is null
            ? new(Property, fsmVar.GetActualType().Name, "null")
            : new(Property + ".name", fsmVar.GetActualType().Name, $"{fsmVar.Value.name}");
    }
}