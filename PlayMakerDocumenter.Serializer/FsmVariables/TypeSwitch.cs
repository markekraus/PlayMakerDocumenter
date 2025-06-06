using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter.Serializer.FsmVariables;

internal static partial class FsmVariableExtensions
{
    public static IEnumerable<FsmVariableDoc> GetFsmValue(this object fsmVar, string Property)
    {
        if (fsmVar is null) yield break;
        object actual;
        try {actual = fsmVar.TryCast();}
        catch { actual = fsmVar; }
        var type = actual.GetActualType().Name;
        switch (actual)
        {
            case FsmArray value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmBool value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmColor value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmEnum value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmFloat value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmGameObject value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmInt value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmMaterial value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmQuaternion value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmRect value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmString value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmTexture value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmVector2 value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmVector3 value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            case FsmObject value:
                foreach (var item in value.GetValue(Property)) { yield return item; }
                break;
            default:
                FsmVariableDoc result;
                try { result = new(Property, type, actual.ToString()); }
                catch { result = new(Property, type, "*Unknown*"); }
                yield return result;
                break;
        }
    }
}