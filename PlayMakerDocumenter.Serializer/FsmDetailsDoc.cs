using Il2Cpp;

namespace PlayMakerDocumenter.Serializer;

public record FsmDetailsDoc
{
    public string Uuid;
    public bool Active;
    public string ActiveStateName;
    public bool Enabled;
    public string FsmDescription;
    public string FsmName;
    public string FullPath;
    public int StateCount;
    public int VariableCount;
    public FsmDetailsDoc() { }
    public FsmDetailsDoc(PlayMakerFSM Fsm)
    {
        Uuid = Fsm.GetUuid();
        Active = Fsm.Active;
        ActiveStateName = Fsm.ActiveStateName;
        Enabled = Fsm.enabled;
        FsmDescription = Fsm.FsmDescription;
        FsmName = Fsm.FsmName;
        FullPath = Fsm.GetFullPath();
        StateCount = Fsm.FsmStates is null ? 0 : Fsm.FsmStates.Count;
        VariableCount = Fsm.FsmVariables is null ? 0 : Fsm.FsmVariables.Count;
    }
    public static implicit operator FsmDetailsDoc(PlayMakerFSM Fsm) => new(Fsm);
}