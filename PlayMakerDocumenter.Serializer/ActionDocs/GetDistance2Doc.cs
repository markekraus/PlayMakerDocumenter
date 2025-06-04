using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetDistance2Doc : FsmActionDoc
{
    internal GetDistance2Doc(ActionContext Ctx, GetDistance2 action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.orVector3), action.orVector3);
        this.AddProperty(nameof(action.orVector3Target), action.orVector3Target);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.target), action.target);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetDistance2Doc Document(this ActionContext ctx, GetDistance2 Action) =>
        new(ctx, Action);
}
