using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AnyTrackPlayingActionDoc : FsmActionDoc
{
    internal AnyTrackPlayingActionDoc(ActionContext Ctx, AnyTrackPlayingAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AnyTrackPlayingActionDoc Document(this ActionContext ctx, AnyTrackPlayingAction Action) =>
        new(ctx, Action);
}
