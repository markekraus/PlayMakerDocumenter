using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetAnimatorSpeedDoc : FsmActionDoc
{
    internal SetAnimatorSpeedDoc(ActionContext Ctx, SetAnimatorSpeed action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.speed), action.speed);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetAnimatorSpeedDoc Document(this ActionContext ctx, SetAnimatorSpeed Action) =>
        new(ctx, Action);
}
