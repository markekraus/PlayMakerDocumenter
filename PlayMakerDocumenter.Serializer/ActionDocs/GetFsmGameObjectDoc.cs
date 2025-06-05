using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetFsmGameObjectDoc : FsmActionDoc
{
    internal GetFsmGameObjectDoc(ActionContext Ctx, GetFsmGameObject action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.fsm), action.fsm);
        this.AddProperty(nameof(action.fsmName), action.fsmName);
        this.AddProperty(nameof(action.fsmNameLastFrame), action.fsmNameLastFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.goLastFrame), action.goLastFrame);
        this.AddProperty(nameof(action.storeValue), action.storeValue);
        this.AddProperty(nameof(action.variableName), action.variableName);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetFsmGameObjectDoc Document(this ActionContext ctx, GetFsmGameObject Action) =>
        new(ctx, Action);
}
