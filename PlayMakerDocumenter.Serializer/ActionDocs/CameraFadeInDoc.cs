using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record CameraFadeInDoc : FsmActionDoc
{
    internal CameraFadeInDoc(ActionContext Ctx, CameraFadeIn action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.color), action.color);
        this.AddProperty(nameof(action.colorLerp), action.colorLerp);
        this.AddProperty(nameof(action.currentTime), action.currentTime);
        this.AddProperty(nameof(action.finishEvent), action.finishEvent);
        this.AddProperty(nameof(action.realTime), action.realTime);
        this.AddProperty(nameof(action.startTime), action.startTime);
        this.AddProperty(nameof(action.time), action.time);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static CameraFadeInDoc Document(this ActionContext ctx, CameraFadeIn Action) =>
        new(ctx, Action);
}
