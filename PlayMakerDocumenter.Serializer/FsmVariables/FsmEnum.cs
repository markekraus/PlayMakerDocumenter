using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter.Serializer.FsmVariables;

internal static partial class FsmVariableExtensions
{
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmEnum fsmVar) =>
        fsmVar.GetValue(fsmVar.Name);
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmEnum fsmVar, string Property)
    {
        if (fsmVar is null) yield break;
        yield return new(Property, fsmVar.GetActualType().Name, $"{fsmVar.Value}");
        yield return new(Property + ".EnumType", fsmVar.GetActualType().Name, $"{fsmVar.EnumType}");
        yield return new(Property + ".intValue", fsmVar.GetActualType().Name, $"{fsmVar.intValue}");
        yield return new(Property + ".parsedIntValue", fsmVar.GetActualType().Name, $"{fsmVar.parsedIntValue}");
    }
}