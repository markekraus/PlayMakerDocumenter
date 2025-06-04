using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetAudioClipDoc : FsmActionDoc
{
    internal SetAudioClipDoc(ActionContext Ctx, SetAudioClip action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.audioClip), action.audioClip);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetAudioClipDoc Document(this ActionContext ctx, SetAudioClip Action) =>
        new(ctx, Action);
}
