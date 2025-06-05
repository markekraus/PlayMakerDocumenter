using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AudioFadeDoc : FsmActionDoc
{
    internal AudioFadeDoc(ActionContext Ctx, AudioFade action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.currentTime), action.currentTime);
        this.AddProperty(nameof(action.fadeTo), action.fadeTo);
        this.AddProperty(nameof(action.finishEvent), action.finishEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.mode), action.mode);
        this.AddProperty(nameof(action.realTime), action.realTime);
        this.AddProperty(nameof(action.startingVolume), action.startingVolume);
        this.AddProperty(nameof(action.startTime), action.startTime);
        this.AddProperty(nameof(action.time), action.time);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AudioFadeDoc Document(this ActionContext ctx, AudioFade Action) =>
        new(ctx, Action);
}
