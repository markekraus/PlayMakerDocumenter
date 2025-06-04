using System;
using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter.Serializer.FsmVariables;

internal static partial class FsmVariableExtensions
{
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmArray fsmVar) =>
        fsmVar.GetValue(fsmVar.Name);
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmArray fsmVar, string Property)
    {
        if (fsmVar is null) yield break;
        var type = fsmVar.GetActualType().Name;
        if (fsmVar.Values is null) { yield return new(Property, type, "null"); yield break; }
        yield return new(Property + ".Count", type, $"{fsmVar.Values.Count}");
        yield return new(Property + ".ElementType", type, $"{fsmVar.ElementType}");
        for (int i = 0; i < fsmVar.Values.Count; i++)
        {
            IEnumerable<FsmVariableDoc> results;
            try
            {
                var item = fsmVar.Values[i].TryCast();
                results = item.GetFsmValue($"{Property}[{i}]");
            }
            catch (Exception ex)
            {
                LogError($"Error processing {Property}[{i}]");
                LogException(ex);
                continue;
            }
            foreach (var result in results)
            {
                yield return result;
            }
        }
    }
}