using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetRotationDoc : FsmActionDoc
{
    internal GetRotationDoc(ActionContext Ctx, GetRotation action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.quaternion), action.quaternion);
        this.AddProperty(nameof(action.space), action.space);
        this.AddProperty(nameof(action.vector), action.vector);
        this.AddProperty(nameof(action.xAngle), action.xAngle);
        this.AddProperty(nameof(action.yAngle), action.yAngle);
        this.AddProperty(nameof(action.zAngle), action.zAngle);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetRotationDoc Document(this ActionContext ctx, GetRotation Action) =>
        new(ctx, Action);
}
