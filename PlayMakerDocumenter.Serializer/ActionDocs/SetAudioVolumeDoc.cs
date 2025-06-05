using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetAudioVolumeDoc : FsmActionDoc
{
    internal SetAudioVolumeDoc(ActionContext Ctx, SetAudioVolume action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.volume), action.volume);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetAudioVolumeDoc Document(this ActionContext ctx, SetAudioVolume Action) =>
        new(ctx, Action);
}
