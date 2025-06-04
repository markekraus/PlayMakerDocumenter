using Il2Cpp;

namespace PlayMakerDocumenter.Serializer;

public record FsmDetailsDoc
{
    public string Uuid;
    public string Active;
    public string ActiveStateName;
    public string Enabled;
    public string FsmDescription;
    public string FsmName;
    public string FullPath;
    public FsmDetailsDoc() { }
    public FsmDetailsDoc(PlayMakerFSM Fsm)
    {
        Uuid = Fsm.GetUuid();
        Active = $"{Fsm.Active}";
        ActiveStateName = $"{Fsm.ActiveStateName}";
        Enabled = $"{Fsm.enabled}";
        FsmDescription = $"{Fsm.FsmDescription}";
        FsmName = $"{Fsm.FsmName}";
        FullPath = Fsm.GetFullPath();
    }
    public static implicit operator FsmDetailsDoc(PlayMakerFSM Fsm) => new(Fsm);
}