namespace PlayMakerDocumenter.Serializer;

public record FsmStateDetailsDoc
{
    public string Name;
    public int StateIndex;
    public string Description;
    public bool HandlesOnEvent;
    public int MaxLoopCount;
    public int ActionCount;
    public FsmStateDetailsDoc() { }
    public FsmStateDetailsDoc(string Name, int StateIndex, string Description, bool HandlesOnEvent, int MaxLoopCount, int ActionCount) =>
        (this.Name, this.StateIndex, this.Description, this.HandlesOnEvent, this.MaxLoopCount, this.ActionCount) =
        (Name, StateIndex, Description, HandlesOnEvent, MaxLoopCount, ActionCount);
    public static implicit operator FsmStateDetailsDoc(StateContext ctx) =>
        new(ctx.State.Name, ctx.StateIndex, ctx.State.Description, ctx.State.HandlesOnEvent, ctx.State.maxLoopCount, ctx.State.Actions is null ? 0 : ctx.State.Actions.Count);
}