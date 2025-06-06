namespace PlayMakerDocumenter.Serializer;

public record FsmActionGeneralDetailsDoc
{
    public int StateIndex;
    public int ActionIndex;
    public string Name;
    public string DisplayName;
    public string TypeName;
    public string TypeFullName;
    public bool BlockFinish;
    public bool Enabled;
    public FsmActionGeneralDetailsDoc() { }
    public FsmActionGeneralDetailsDoc(ActionContext ctx)
    {
        StateIndex = ctx.StateIndex;
        ActionIndex = ctx.ActionIndex;
        Name = ctx.Action.Name is null ? "null" : ctx.Action.Name;
        DisplayName = ctx.Action.DisplayName is null ? "null" : ctx.Action.DisplayName;
        TypeName = ctx.ActionType.Name;
        TypeFullName = ctx.ActionType.FullName;
        BlockFinish = ctx.Action.blocksFinish;
        Enabled = ctx.Action.enabled;
    }
    public static implicit operator FsmActionGeneralDetailsDoc(ActionContext ctx) =>
        new(ctx);
}
