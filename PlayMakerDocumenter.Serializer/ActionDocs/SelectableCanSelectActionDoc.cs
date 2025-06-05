using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SelectableCanSelectActionDoc : FsmActionDoc
{
    internal SelectableCanSelectActionDoc(ActionContext Ctx, SelectableCanSelectAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.CanInteract), action.CanInteract);
        this.AddProperty(nameof(action.Target), action.Target);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SelectableCanSelectActionDoc Document(this ActionContext ctx, SelectableCanSelectAction Action) =>
        new(ctx, Action);
}
