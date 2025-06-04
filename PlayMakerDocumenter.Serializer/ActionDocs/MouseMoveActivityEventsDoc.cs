using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record MouseMoveActivityEventsDoc : FsmActionDoc
{
    internal MouseMoveActivityEventsDoc(ActionContext Ctx, MouseMoveActivityEvents action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._isInactive), action._isInactive);
        this.AddProperty(nameof(action._lastMoveTime), action._lastMoveTime);
        this.AddProperty(nameof(action._lastPosition), action._lastPosition);
        this.AddProperty(nameof(action.eventTarget), action.eventTarget);
        this.AddProperty(nameof(action.inactivityThreshold), action.inactivityThreshold);
        this.AddProperty(nameof(action.isInactive), action.isInactive);
        this.AddProperty(nameof(action.mouseMoveEvent), action.mouseMoveEvent);
        this.AddProperty(nameof(action.mouseStillEvent), action.mouseStillEvent);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static MouseMoveActivityEventsDoc Document(this ActionContext ctx, MouseMoveActivityEvents Action) =>
        new(ctx, Action);
}
