using System.Collections.Generic;
using Il2Cpp;

namespace PlayMakerDocumenter.Serializer;

public class FsmStatesDoc : List<FsmStateDoc>
{
    public FsmStatesDoc() : base() { }
    private FsmStatesDoc(PlayMakerFSM fsm) : base()
    {
        if (fsm is null || fsm.FsmStates is null) return;
        Capacity = fsm.FsmStates.Count;
        for (int i = 0; i < fsm.FsmStates.Count; i++)
            Add(new(fsm,i));
    }
    public static implicit operator FsmStatesDoc(PlayMakerFSM Fsm) =>
        new(Fsm);
}
