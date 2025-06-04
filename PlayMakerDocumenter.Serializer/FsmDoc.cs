using Il2Cpp;

namespace PlayMakerDocumenter.Serializer;

public class FsmDoc
{
    public EnvironmentDoc EnvironmentDetails = new();
    public FsmDetailsDoc FsmDetails;
    public TransitionsDoc GlobalTransitions;
    public FsmVariablesDoc Variables;
    public FsmEventsDoc Events;
    public FsmStatesDoc States;
    private FsmDoc(PlayMakerFSM Fsm)
    {
        (FsmDetails, GlobalTransitions, Variables, Events, States) =
        (Fsm, Fsm, Fsm, Fsm, Fsm);
    }
}
