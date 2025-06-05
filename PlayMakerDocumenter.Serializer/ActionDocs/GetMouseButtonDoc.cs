using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetMouseButtonDoc : FsmActionDoc
{
    internal GetMouseButtonDoc(ActionContext Ctx, GetMouseButton action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.button), action.button);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetMouseButtonDoc Document(this ActionContext ctx, GetMouseButton Action) =>
        new(ctx, Action);
}
