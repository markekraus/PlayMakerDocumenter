using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetComponentDoc : FsmActionDoc
{
    internal GetComponentDoc(ActionContext Ctx, GetComponent action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.storeComponent), action.storeComponent);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetComponentDoc Document(this ActionContext ctx, GetComponent Action) =>
        new(ctx, Action);
}
