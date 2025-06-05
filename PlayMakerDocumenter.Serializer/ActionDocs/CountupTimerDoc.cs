using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record CountupTimerDoc : FsmActionDoc
{
    internal CountupTimerDoc(ActionContext Ctx, CountupTimer action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.pause), action.pause);
        this.AddProperty(nameof(action.realTime), action.realTime);
        this.AddProperty(nameof(action.reset), action.reset);
        this.AddProperty(nameof(action.restartOnEnter), action.restartOnEnter);
        this.AddProperty(nameof(action.startTime), action.startTime);
        this.AddProperty(nameof(action.storeTime), action.storeTime);
        this.AddProperty(nameof(action.timer), action.timer);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static CountupTimerDoc Document(this ActionContext ctx, CountupTimer Action) =>
        new(ctx, Action);
}
