using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackSetLevelActionDoc : FsmActionDoc
{
    internal TrackSetLevelActionDoc(ActionContext Ctx, TrackSetLevelAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.GroupID), action.GroupID);
        this.AddProperty(nameof(action.Level), action.Level);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackSetLevelActionDoc Document(this ActionContext ctx, TrackSetLevelAction Action) =>
        new(ctx, Action);
}
