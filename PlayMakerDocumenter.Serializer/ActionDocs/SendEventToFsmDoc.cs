using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SendEventToFsmDoc : FsmActionDoc
{
    internal SendEventToFsmDoc(ActionContext Ctx, SendEventToFsm action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.delay), action.delay);
        this.AddProperty(nameof(action.delayedEvent), action.delayedEvent);
        this.AddProperty(nameof(action.fsmName), action.fsmName);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.go), action.go);
        this.AddProperty(nameof(action.requireReceiver), action.requireReceiver);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SendEventToFsmDoc Document(this ActionContext ctx, SendEventToFsm Action) =>
        new(ctx, Action);
}
