using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record UIScreenCanOpenActionDoc : FsmActionDoc
{
    internal UIScreenCanOpenActionDoc(ActionContext Ctx, UIScreenCanOpenAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.CannotOpenEvent), action.CannotOpenEvent);
        this.AddProperty(nameof(action.CanOpenEvent), action.CanOpenEvent);
        this.AddProperty(nameof(action.Target), action.Target);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static UIScreenCanOpenActionDoc Document(this ActionContext ctx, UIScreenCanOpenAction Action) =>
        new(ctx, Action);
}
