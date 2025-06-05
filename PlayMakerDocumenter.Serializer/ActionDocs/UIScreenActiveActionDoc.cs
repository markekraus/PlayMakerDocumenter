using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record UIScreenActiveActionDoc : FsmActionDoc
{
    internal UIScreenActiveActionDoc(ActionContext Ctx, UIScreenActiveAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.ActiveEvent), action.ActiveEvent);
        this.AddProperty(nameof(action.Target), action.Target);
        this.AddProperty(nameof(action.UnactiveEvent), action.UnactiveEvent);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static UIScreenActiveActionDoc Document(this ActionContext ctx, UIScreenActiveAction Action) =>
        new(ctx, Action);
}
