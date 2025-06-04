using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record VideoPlayerPlayDoc : FsmActionDoc
{
    internal VideoPlayerPlayDoc(ActionContext Ctx, VideoPlayerPlay action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._vp), action._vp);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.go), action.go);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static VideoPlayerPlayDoc Document(this ActionContext ctx, VideoPlayerPlay Action) =>
        new(ctx, Action);
}
