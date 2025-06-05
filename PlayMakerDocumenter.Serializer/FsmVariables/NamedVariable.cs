using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter.Serializer.FsmVariables;

internal static partial class FsmVariableExtensions
{
    public static IEnumerable<FsmVariableDoc> GetValue(this NamedVariable fsmVar) =>
        fsmVar.GetValue(fsmVar.Name);
    public static IEnumerable<FsmVariableDoc> GetValue(this NamedVariable fsmVar, string Property) =>
        fsmVar.GetFsmValue(Property);
}