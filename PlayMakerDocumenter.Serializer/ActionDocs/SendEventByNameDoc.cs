using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SendEventByNameDoc : FsmActionDoc
{
    internal SendEventByNameDoc(ActionContext Ctx, SendEventByName action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.delay), action.delay);
        this.AddProperty(nameof(action.delayedEvent), action.delayedEvent);
        this.AddProperty(nameof(action.eventTarget), action.eventTarget);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SendEventByNameDoc Document(this ActionContext ctx, SendEventByName Action) =>
        new(ctx, Action);
}
