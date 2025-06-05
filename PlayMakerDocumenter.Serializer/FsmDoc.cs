using Il2Cpp;

namespace PlayMakerDocumenter.Serializer;

public record FsmDoc
{
    public EnvironmentDoc EnvironmentDetails = new();
    public FsmDetailsDoc FsmDetails;
    public TransitionsDoc GlobalTransitions;
    public FsmVariablesDoc Variables;
    public FsmEventsDoc Events;
    public FsmStatesDoc States;
    public FsmDoc() { }
    public FsmDoc(PlayMakerFSM Fsm)
    {
        EnvironmentDetails = new();
        FsmDetails = Fsm;
        GlobalTransitions = Fsm;
        Variables = Fsm;
        Events = Fsm;
        States = Fsm;
    }
    public static implicit operator FsmDoc(PlayMakerFSM Fsm) =>
        new(Fsm);
    public static FsmDoc Create(PlayMakerFSM Fsm) =>
        new(Fsm);
}
