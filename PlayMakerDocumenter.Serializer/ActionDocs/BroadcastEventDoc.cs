using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record BroadcastEventDoc : FsmActionDoc
{
    internal BroadcastEventDoc(ActionContext Ctx, BroadcastEvent action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.broadcastEvent), action.broadcastEvent);
        this.AddProperty(nameof(action.excludeSelf), action.excludeSelf);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.sendToChildren), action.sendToChildren);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static BroadcastEventDoc Document(this ActionContext ctx, BroadcastEvent Action) =>
        new(ctx, Action);
}
