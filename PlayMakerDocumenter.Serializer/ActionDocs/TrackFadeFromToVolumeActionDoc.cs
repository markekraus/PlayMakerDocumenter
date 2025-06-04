using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackFadeFromToVolumeActionDoc : FsmActionDoc
{
    internal TrackFadeFromToVolumeActionDoc(ActionContext Ctx, TrackFadeFromToVolumeAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.fadeTime), action.fadeTime);
        this.AddProperty(nameof(action.playingOnly), action.playingOnly);
        this.AddProperty(nameof(action.priorityCheck), action.priorityCheck);
        this.AddProperty(nameof(action.priorityValue), action.priorityValue);
        this.AddProperty(nameof(action.startVolume), action.startVolume);
        this.AddProperty(nameof(action.targetGroup), action.targetGroup);
        this.AddProperty(nameof(action.targetVolume), action.targetVolume);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackFadeFromToVolumeActionDoc Document(this ActionContext ctx, TrackFadeFromToVolumeAction Action) =>
        new(ctx, Action);
}
