using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using PlayMakerDocumenter.Serializer.FsmVariables;
using UniverseLib;

namespace PlayMakerDocumenter.Serializer;

public class FsmVariablesDoc : List<FsmVariableDoc>
{
    public FsmVariablesDoc() : base() { }
    private FsmVariablesDoc(PlayMakerFSM Fsm) : base()
    {
        if (Fsm is null || Fsm.FsmVariables is null || Fsm.FsmVariables._variableLookup is null) return;
        foreach (var lookup in Fsm.FsmVariables._variableLookup)
        {
            var name = lookup.Key;
            var fsmVar = lookup.Value;
            if (fsmVar is null)
            {
                Add(new(name, "null", "null"));
                continue;
            }
            AddRange(fsmVar.GetValue());
        }
    }
    public static implicit operator FsmVariablesDoc(PlayMakerFSM Fsm) =>
        new(Fsm);
}
