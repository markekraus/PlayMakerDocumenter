using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AudioMixerSetFloatValueDoc : FsmActionDoc
{
    internal AudioMixerSetFloatValueDoc(ActionContext Ctx, AudioMixerSetFloatValue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.exposedFloatName), action.exposedFloatName);
        this.AddProperty(nameof(action.floatvalue), action.floatvalue);
        this.AddProperty(nameof(action.theMixer), action.theMixer);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AudioMixerSetFloatValueDoc Document(this ActionContext ctx, AudioMixerSetFloatValue Action) =>
        new(ctx, Action);
}
