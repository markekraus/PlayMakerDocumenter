using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetGameObjectDoc : FsmActionDoc
{
    internal SetGameObjectDoc(ActionContext Ctx, SetGameObject action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.variable), action.variable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetGameObjectDoc Document(this ActionContext ctx, SetGameObject Action) =>
        new(ctx, Action);
}
