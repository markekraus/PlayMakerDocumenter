using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AudioFadeOutDoc : FsmActionDoc
{
    internal AudioFadeOutDoc(ActionContext Ctx, AudioFadeOut action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._audioSource), action._audioSource);
        this.AddProperty(nameof(action.b), action.b);
        this.AddProperty(nameof(action.currentTime), action.currentTime);
        this.AddProperty(nameof(action.finishEvent), action.finishEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.m), action.m);
        this.AddProperty(nameof(action.realTime), action.realTime);
        this.AddProperty(nameof(action.startTime), action.startTime);
        this.AddProperty(nameof(action.time), action.time);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AudioFadeOutDoc Document(this ActionContext ctx, AudioFadeOut Action) =>
        new(ctx, Action);
}
