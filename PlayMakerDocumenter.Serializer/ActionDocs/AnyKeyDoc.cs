using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AnyKeyDoc : FsmActionDoc
{
    internal AnyKeyDoc(ActionContext Ctx, AnyKey action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.eventTarget), action.eventTarget);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AnyKeyDoc Document(this ActionContext ctx, AnyKey Action) =>
        new(ctx, Action);
}
