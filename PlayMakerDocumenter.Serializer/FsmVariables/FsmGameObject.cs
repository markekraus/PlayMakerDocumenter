using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter.Serializer.FsmVariables;

internal static partial class FsmVariableExtensions
{
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmGameObject fsmVar) =>
        fsmVar.GetValue(fsmVar.Name);
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmGameObject fsmVar, string Property)
    {
        if (fsmVar is null) yield break;
        var result = new FsmVariableDoc(Property, fsmVar.GetActualType().Name, "null");
        if (fsmVar.Value is null) { yield return result; yield break; }
        try { result = new(Property, fsmVar.GetActualType().Name, fsmVar.Value.GetFullPath()); }
            catch { }
        yield return result;
    }
}