using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record MousePickEventDoc : FsmActionDoc
{
    internal MousePickEventDoc(ActionContext Ctx, MousePickEvent action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.GameObject), action.GameObject);
        this.AddProperty(nameof(action.ignoreCursorStick), action.ignoreCursorStick);
        this.AddProperty(nameof(action.invertMask), action.invertMask);
        this.AddProperty(nameof(action.layerMask), action.layerMask);
        this.AddProperty(nameof(action.mouseDown), action.mouseDown);
        this.AddProperty(nameof(action.mouseOff), action.mouseOff);
        this.AddProperty(nameof(action.mouseOver), action.mouseOver);
        this.AddProperty(nameof(action.mouseUp), action.mouseUp);
        this.AddProperty(nameof(action.rayDistance), action.rayDistance);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static MousePickEventDoc Document(this ActionContext ctx, MousePickEvent Action) =>
        new(ctx, Action);
}
