using System.Linq;
using Il2Cpp;

namespace PlayMakerDocumenter.Serializer;

public class FsmStateDoc
{
    public FsmStateDetailsDoc Details;
    public FsmStateTransitionsDoc Transitions;
    public FsmActionsDoc Actions;
    public FsmStateDoc() { }
    internal FsmStateDoc(PlayMakerFSM fsm, int StateIndex)
    {
        var ctx = new StateContext(fsm, fsm.FsmStates[StateIndex], StateIndex, new());
        Details = ctx;
        Transitions = ctx;
        Actions = ctx;
    }
}
