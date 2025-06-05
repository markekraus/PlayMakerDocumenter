using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record IsActiveDoc : FsmActionDoc
{
    internal IsActiveDoc(ActionContext Ctx, IsActive action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.isActive), action.isActive);
        this.AddProperty(nameof(action.isActiveEvent), action.isActiveEvent);
        this.AddProperty(nameof(action.isNotActiveEvent), action.isNotActiveEvent);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static IsActiveDoc Document(this ActionContext ctx, IsActive Action) =>
        new(ctx, Action);
}
