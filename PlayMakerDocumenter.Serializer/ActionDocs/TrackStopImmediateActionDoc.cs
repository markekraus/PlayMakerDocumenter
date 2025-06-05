using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackStopImmediateActionDoc : FsmActionDoc
{
    internal TrackStopImmediateActionDoc(ActionContext Ctx, TrackStopImmediateAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.GroupID), action.GroupID);
        this.AddProperty(nameof(action.PriorityCheckEnabled), action.PriorityCheckEnabled);
        this.AddProperty(nameof(action.PriorityCheckValue), action.PriorityCheckValue);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackStopImmediateActionDoc Document(this ActionContext ctx, TrackStopImmediateAction Action) =>
        new(ctx, Action);
}
