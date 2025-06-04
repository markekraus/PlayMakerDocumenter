using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TimeSinceLastPlayActionDoc : FsmActionDoc
{
    internal TimeSinceLastPlayActionDoc(ActionContext Ctx, TimeSinceLastPlayAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TimeSinceLastPlayActionDoc Document(this ActionContext ctx, TimeSinceLastPlayAction Action) =>
        new(ctx, Action);
}
