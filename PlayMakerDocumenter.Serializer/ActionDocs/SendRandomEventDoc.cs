using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SendRandomEventDoc : FsmActionDoc
{
    internal SendRandomEventDoc(ActionContext Ctx, SendRandomEvent action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.delay), action.delay);
        this.AddProperty(nameof(action.delayedEvent), action.delayedEvent);
        this.AddProperty(nameof(action.events), action.events);
        this.AddProperty(nameof(action.weights), action.weights);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SendRandomEventDoc Document(this ActionContext ctx, SendRandomEvent Action) =>
        new(ctx, Action);
}
