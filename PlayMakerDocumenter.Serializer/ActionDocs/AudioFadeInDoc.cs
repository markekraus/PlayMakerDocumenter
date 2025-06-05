using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AudioFadeInDoc : FsmActionDoc
{
    internal AudioFadeInDoc(ActionContext Ctx, AudioFadeIn action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._audioSource), action._audioSource);
        this.AddProperty(nameof(action.currentTime), action.currentTime);
        this.AddProperty(nameof(action.finishEvent), action.finishEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.inVolume), action.inVolume);
        this.AddProperty(nameof(action.m), action.m);
        this.AddProperty(nameof(action.realTime), action.realTime);
        this.AddProperty(nameof(action.startTime), action.startTime);
        this.AddProperty(nameof(action.time), action.time);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AudioFadeInDoc Document(this ActionContext ctx, AudioFadeIn Action) =>
        new(ctx, Action);
}
