using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackSetPriorityActionDoc : FsmActionDoc
{
    internal TrackSetPriorityActionDoc(ActionContext Ctx, TrackSetPriorityAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.GroupID), action.GroupID);
        this.AddProperty(nameof(action.Priority), action.Priority);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackSetPriorityActionDoc Document(this ActionContext ctx, TrackSetPriorityAction Action) =>
        new(ctx, Action);
}
