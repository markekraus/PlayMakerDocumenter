using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackStopActionDoc : FsmActionDoc
{
    internal TrackStopActionDoc(ActionContext Ctx, TrackStopAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.GroupID), action.GroupID);
        this.AddProperty(nameof(action.PriorityCheckEnabled), action.PriorityCheckEnabled);
        this.AddProperty(nameof(action.PriorityCheckValue), action.PriorityCheckValue);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackStopActionDoc Document(this ActionContext ctx, TrackStopAction Action) =>
        new(ctx, Action);
}
