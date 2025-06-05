using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackPlayFadeTimeActionDoc : FsmActionDoc
{
    internal TrackPlayFadeTimeActionDoc(ActionContext Ctx, TrackPlayFadeTimeAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.FadeUpTime), action.FadeUpTime);
        this.AddProperty(nameof(action.GroupID), action.GroupID);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackPlayFadeTimeActionDoc Document(this ActionContext ctx, TrackPlayFadeTimeAction Action) =>
        new(ctx, Action);
}
