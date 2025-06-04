using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TriggerEventDoc : FsmActionDoc
{
    internal TriggerEventDoc(ActionContext Ctx, TriggerEvent action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.cachedProxy), action.cachedProxy);
        this.AddProperty(nameof(action.collideTag), action.collideTag);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.storeCollider), action.storeCollider);
        this.AddProperty(nameof(action.trigger), action.trigger);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TriggerEventDoc Document(this ActionContext ctx, TriggerEvent Action) =>
        new(ctx, Action);
}
