using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListSendEventToGameObjectsDoc : FsmActionDoc
{
    internal ArrayListSendEventToGameObjectsDoc(ActionContext Ctx, ArrayListSendEventToGameObjects action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.excludeSelf), action.excludeSelf);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.sendToChildren), action.sendToChildren);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListSendEventToGameObjectsDoc Document(this ActionContext ctx, ArrayListSendEventToGameObjects Action) =>
        new(ctx, Action);
}
