using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetKeyDownDoc : FsmActionDoc
{
    internal GetKeyDownDoc(ActionContext Ctx, GetKeyDown action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.key), action.key);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetKeyDownDoc Document(this ActionContext ctx, GetKeyDown Action) =>
        new(ctx, Action);
}
