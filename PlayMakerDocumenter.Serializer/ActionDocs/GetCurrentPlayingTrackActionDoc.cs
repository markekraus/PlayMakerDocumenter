using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetCurrentPlayingTrackActionDoc : FsmActionDoc
{
    internal GetCurrentPlayingTrackActionDoc(ActionContext Ctx, GetCurrentPlayingTrackAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetCurrentPlayingTrackActionDoc Document(this ActionContext ctx, GetCurrentPlayingTrackAction Action) =>
        new(ctx, Action);
}
