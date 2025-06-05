using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter.Serializer.FsmVariables;

internal static partial class FsmVariableExtensions
{
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmRect fsmVar) =>
        fsmVar.GetValue(fsmVar.Name);
    public static IEnumerable<FsmVariableDoc> GetValue(this FsmRect fsmVar, string Property)
    {
        if (fsmVar is null) yield break;
        var type = fsmVar.GetActualType().Name;
        yield return new(Property + ".bottom", type, $"{fsmVar.Value.bottom}");
        yield return new(Property + ".center.x", type, $"{fsmVar.Value.center.x}");
        yield return new(Property + ".center.y", type, $"{fsmVar.Value.center.y}");
        yield return new(Property + ".height", type, $"{fsmVar.Value.height}");
        yield return new(Property + ".left", type, $"{fsmVar.Value.left}");
        yield return new(Property + ".max", type, $"{fsmVar.Value.max}");
        yield return new(Property + ".min", type, $"{fsmVar.Value.min}");
        yield return new(Property + ".position.x", type, $"{fsmVar.Value.position.x}");
        yield return new(Property + ".position.y", type, $"{fsmVar.Value.position.y}");
        yield return new(Property + ".right", type, $"{fsmVar.Value.right}");
        yield return new(Property + ".size", type, $"{fsmVar.Value.size}");
        yield return new(Property + ".top", type, $"{fsmVar.Value.top}");
        yield return new(Property + ".width", type, $"{fsmVar.Value.width}");
        yield return new(Property + ".x", type, $"{fsmVar.Value.x}");
        yield return new(Property + ".xMax", type, $"{fsmVar.Value.xMax}");
        yield return new(Property + ".xMin", type, $"{fsmVar.Value.xMin}");
        yield return new(Property + ".y", type, $"{fsmVar.Value.y}");
        yield return new(Property + ".yMax", type, $"{fsmVar.Value.yMax}");
        yield return new(Property + ".yMin", type, $"{fsmVar.Value.yMin}");
    }
}