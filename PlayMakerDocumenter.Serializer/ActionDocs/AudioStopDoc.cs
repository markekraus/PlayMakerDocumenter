using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AudioStopDoc : FsmActionDoc
{
    internal AudioStopDoc(ActionContext Ctx, AudioStop action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.fadeTime), action.fadeTime);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.volume), action.volume);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AudioStopDoc Document(this ActionContext ctx, AudioStop Action) =>
        new(ctx, Action);
}
