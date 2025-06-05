using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackPlayActionDoc : FsmActionDoc
{
    internal TrackPlayActionDoc(ActionContext Ctx, TrackPlayAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.GroupID), action.GroupID);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackPlayActionDoc Document(this ActionContext ctx, TrackPlayAction Action) =>
        new(ctx, Action);
}
