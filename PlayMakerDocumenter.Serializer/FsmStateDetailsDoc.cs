namespace PlayMakerDocumenter.Serializer;

public record FsmStateDetailsDoc
{
    public string Name;
    public int StateIndex;
    public string Description;
    public bool HandlesOnEvent;
    public int MaxLoopCount;
    public FsmStateDetailsDoc() { }
    public FsmStateDetailsDoc(string Name, int StateIndex, string Description, bool HandlesOnEvent, int MaxLoopCount) =>
        (this.Name, this.StateIndex, this.Description, this.HandlesOnEvent, this.MaxLoopCount) =
        (Name, StateIndex, Description, HandlesOnEvent, MaxLoopCount);
    public static implicit operator FsmStateDetailsDoc(StateContext ctx) =>
        new(ctx.State.Name, ctx.StateIndex, ctx.State.Description, ctx.State.HandlesOnEvent, ctx.State.maxLoopCount);
}