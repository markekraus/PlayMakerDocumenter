using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetMouseButtonDownDoc : FsmActionDoc
{
    internal GetMouseButtonDownDoc(ActionContext Ctx, GetMouseButtonDown action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.button), action.button);
        this.AddProperty(nameof(action.inUpdateOnly), action.inUpdateOnly);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetMouseButtonDownDoc Document(this ActionContext ctx, GetMouseButtonDown Action) =>
        new(ctx, Action);
}
