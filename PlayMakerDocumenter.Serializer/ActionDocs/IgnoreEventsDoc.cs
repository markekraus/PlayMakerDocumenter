using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record IgnoreEventsDoc : FsmActionDoc
{
    internal IgnoreEventsDoc(ActionContext Ctx, IgnoreEvents action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.events), action.events);
        this.AddProperty(nameof(action.eventTypes), action.eventTypes);
        this.AddProperty(nameof(action.logIgnoredEvents), action.logIgnoredEvents);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static IgnoreEventsDoc Document(this ActionContext ctx, IgnoreEvents Action) =>
        new(ctx, Action);
}
