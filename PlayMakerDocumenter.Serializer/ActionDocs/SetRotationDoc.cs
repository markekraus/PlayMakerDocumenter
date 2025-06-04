using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetRotationDoc : FsmActionDoc
{
    internal SetRotationDoc(ActionContext Ctx, SetRotation action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.lateUpdate), action.lateUpdate);
        this.AddProperty(nameof(action.quaternion), action.quaternion);
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
    public static SetRotationDoc Document(this ActionContext ctx, SetRotation Action) =>
        new(ctx, Action);
}
