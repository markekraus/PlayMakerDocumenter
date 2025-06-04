using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackFadeToVolumeActionDoc : FsmActionDoc
{
    internal TrackFadeToVolumeActionDoc(ActionContext Ctx, TrackFadeToVolumeAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.fadeTime), action.fadeTime);
        this.AddProperty(nameof(action.playingOnly), action.playingOnly);
        this.AddProperty(nameof(action.priorityCheck), action.priorityCheck);
        this.AddProperty(nameof(action.priorityValue), action.priorityValue);
        this.AddProperty(nameof(action.targetGroup), action.targetGroup);
        this.AddProperty(nameof(action.targetVolume), action.targetVolume);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackFadeToVolumeActionDoc Document(this ActionContext ctx, TrackFadeToVolumeAction Action) =>
        new(ctx, Action);
}
