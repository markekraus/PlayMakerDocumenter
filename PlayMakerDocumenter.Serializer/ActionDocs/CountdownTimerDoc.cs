using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record CountdownTimerDoc : FsmActionDoc
{
    internal CountdownTimerDoc(ActionContext Ctx, CountdownTimer action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.finishEvent), action.finishEvent);
        this.AddProperty(nameof(action.realTime), action.realTime);
        this.AddProperty(nameof(action.startTime), action.startTime);
        this.AddProperty(nameof(action.stopOn), action.stopOn);
        this.AddProperty(nameof(action.storeValue), action.storeValue);
        this.AddProperty(nameof(action.theTime), action.theTime);
        this.AddProperty(nameof(action.time), action.time);
        this.AddProperty(nameof(action.timer), action.timer);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static CountdownTimerDoc Document(this ActionContext ctx, CountdownTimer Action) =>
        new(ctx, Action);
}
