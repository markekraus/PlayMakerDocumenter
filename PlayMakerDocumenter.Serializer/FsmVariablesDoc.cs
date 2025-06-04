using System.Collections.Generic;
using Il2Cpp;
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
                Add(new(
                    Name: name,
                    Type: "null",
                    Value: "null"
                ));
                continue;
            }
            Add(new(
                Name: name,
                Type: fsmVar.GetActualType().Name,
                Value: fsmVar.GetValue(Fsm)
            ));
        }
    }
    public static implicit operator FsmVariablesDoc(PlayMakerFSM Fsm) =>
        new(Fsm);
}
