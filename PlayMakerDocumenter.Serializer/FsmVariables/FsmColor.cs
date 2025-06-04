using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter.Serializer.FsmVariables;

internal static partial class FsmVariableExtensions
{
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmColor fsmVar) =>
        fsmVar.GetValue(fsmVar.Name);
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmColor fsmVar, string Property)
    {
        if (fsmVar is null) yield break;
        yield return new(Property + ".a", fsmVar.GetActualType().Name, $"{fsmVar.Value.a}");
        yield return new(Property + ".b", fsmVar.GetActualType().Name, $"{fsmVar.Value.b}");
        yield return new(Property + ".g", fsmVar.GetActualType().Name, $"{fsmVar.Value.g}");
        yield return new(Property + ".r", fsmVar.GetActualType().Name, $"{fsmVar.Value.r}");
    }
}