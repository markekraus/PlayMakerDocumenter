namespace PlayMakerDocumenter.Serializer;

public record FsmStateDetailsDoc(string Name, int StateIndex, string Description, bool HandlesOnEvent, int MaxLoopCount)
{
    public static implicit operator FsmStateDetailsDoc(StateContext ctx) =>
        new(ctx.State.Name, ctx.StateIndex, ctx.State.Description, ctx.State.HandlesOnEvent, ctx.State.maxLoopCount);
}