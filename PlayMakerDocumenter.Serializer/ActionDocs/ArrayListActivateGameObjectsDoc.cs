using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListActivateGameObjectsDoc : FsmActionDoc
{
    internal ArrayListActivateGameObjectsDoc(ActionContext Ctx, ArrayListActivateGameObjects action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._activeStates), action._activeStates);
        this.AddProperty(nameof(action.activate), action.activate);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.resetOnExit), action.resetOnExit);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListActivateGameObjectsDoc Document(this ActionContext ctx, ArrayListActivateGameObjects Action) =>
        new(ctx, Action);
}
