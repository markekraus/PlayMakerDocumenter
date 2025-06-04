using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AudioMixerGetFloatValueDoc : FsmActionDoc
{
    internal AudioMixerGetFloatValueDoc(ActionContext Ctx, AudioMixerGetFloatValue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.exposedFloatName), action.exposedFloatName);
        this.AddProperty(nameof(action.storeFloatValue), action.storeFloatValue);
        this.AddProperty(nameof(action.theMixer), action.theMixer);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AudioMixerGetFloatValueDoc Document(this ActionContext ctx, AudioMixerGetFloatValue Action) =>
        new(ctx, Action);
}
