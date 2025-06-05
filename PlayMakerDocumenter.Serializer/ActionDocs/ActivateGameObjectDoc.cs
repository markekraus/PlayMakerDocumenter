using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ActivateGameObjectDoc : FsmActionDoc
{
    internal ActivateGameObjectDoc(ActionContext Ctx, ActivateGameObject action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.activate), action.activate);
        this.AddProperty(nameof(action.activatedGameObject), action.activatedGameObject);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.recursive), action.recursive);
        this.AddProperty(nameof(action.resetOnExit), action.resetOnExit);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ActivateGameObjectDoc Document(this ActionContext ctx, ActivateGameObject Action) =>
        new(ctx, Action);
}
