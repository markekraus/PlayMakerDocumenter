using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetScaleDoc : FsmActionDoc
{
    internal SetScaleDoc(ActionContext Ctx, SetScale action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.lateUpdate), action.lateUpdate);
        this.AddProperty(nameof(action.vector), action.vector);
        this.AddProperty(nameof(action.x), action.x);
        this.AddProperty(nameof(action.y), action.y);
        this.AddProperty(nameof(action.z), action.z);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetScaleDoc Document(this ActionContext ctx, SetScale Action) =>
        new(ctx, Action);
}
