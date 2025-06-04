using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackPlayParallelActionDoc : FsmActionDoc
{
    internal TrackPlayParallelActionDoc(ActionContext Ctx, TrackPlayParallelAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.GroupID), action.GroupID);
        this.AddProperty(nameof(action.OnlyPlaying), action.OnlyPlaying);
        this.AddProperty(nameof(action.StopAllOthers), action.StopAllOthers);
        this.AddProperty(nameof(action.TrackID), action.TrackID);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackPlayParallelActionDoc Document(this ActionContext ctx, TrackPlayParallelAction Action) =>
        new(ctx, Action);
}
