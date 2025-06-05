using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListContainsGameObjectDoc : FsmActionDoc
{
    internal ArrayListContainsGameObjectDoc(ActionContext Ctx, ArrayListContainsGameObject action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.gameObjectName), action.gameObjectName);
        this.AddProperty(nameof(action.isContained), action.isContained);
        this.AddProperty(nameof(action.isContainedEvent), action.isContainedEvent);
        this.AddProperty(nameof(action.isNotContainedEvent), action.isNotContainedEvent);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.result), action.result);
        this.AddProperty(nameof(action.resultIndex), action.resultIndex);
        this.AddProperty(nameof(action.withTag), action.withTag);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListContainsGameObjectDoc Document(this ActionContext ctx, ArrayListContainsGameObject Action) =>
        new(ctx, Action);
}
