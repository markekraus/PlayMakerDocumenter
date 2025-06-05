using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record RandomWaitDoc : FsmActionDoc
{
    internal RandomWaitDoc(ActionContext Ctx, RandomWait action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.finishEvent), action.finishEvent);
        this.AddProperty(nameof(action.max), action.max);
        this.AddProperty(nameof(action.min), action.min);
        this.AddProperty(nameof(action.realTime), action.realTime);
        this.AddProperty(nameof(action.startTime), action.startTime);
        this.AddProperty(nameof(action.time), action.time);
        this.AddProperty(nameof(action.timer), action.timer);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static RandomWaitDoc Document(this ActionContext ctx, RandomWait Action) =>
        new(ctx, Action);
}
