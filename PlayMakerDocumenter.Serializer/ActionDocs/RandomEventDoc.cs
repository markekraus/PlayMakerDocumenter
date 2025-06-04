using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record RandomEventDoc : FsmActionDoc
{
    internal RandomEventDoc(ActionContext Ctx, RandomEvent action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.delay), action.delay);
        this.AddProperty(nameof(action.delayedEvent), action.delayedEvent);
        this.AddProperty(nameof(action.lastEventIndex), action.lastEventIndex);
        this.AddProperty(nameof(action.noRepeat), action.noRepeat);
        this.AddProperty(nameof(action.randomEventIndex), action.randomEventIndex);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static RandomEventDoc Document(this ActionContext ctx, RandomEvent Action) =>
        new(ctx, Action);
}
