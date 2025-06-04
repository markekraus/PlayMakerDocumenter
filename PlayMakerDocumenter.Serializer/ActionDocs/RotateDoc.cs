using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record RotateDoc : FsmActionDoc
{
    internal RotateDoc(ActionContext Ctx, Rotate action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.fixedUpdate), action.fixedUpdate);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.lateUpdate), action.lateUpdate);
        this.AddProperty(nameof(action.perSecond), action.perSecond);
        this.AddProperty(nameof(action.space), action.space);
        this.AddProperty(nameof(action.vector), action.vector);
        this.AddProperty(nameof(action.xAngle), action.xAngle);
        this.AddProperty(nameof(action.yAngle), action.yAngle);
        this.AddProperty(nameof(action.zAngle), action.zAngle);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static RotateDoc Document(this ActionContext ctx, Rotate Action) =>
        new(ctx, Action);
}
