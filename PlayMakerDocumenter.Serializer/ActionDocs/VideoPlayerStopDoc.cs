using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record VideoPlayerStopDoc : FsmActionDoc
{
    internal VideoPlayerStopDoc(ActionContext Ctx, VideoPlayerStop action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._vp), action._vp);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.go), action.go);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static VideoPlayerStopDoc Document(this ActionContext ctx, VideoPlayerStop Action) =>
        new(ctx, Action);
}
