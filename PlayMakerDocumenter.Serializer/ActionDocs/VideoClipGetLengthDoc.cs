using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record VideoClipGetLengthDoc : FsmActionDoc
{
    internal VideoClipGetLengthDoc(ActionContext Ctx, VideoClipGetLength action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._vc), action._vc);
        this.AddProperty(nameof(action._vp), action._vp);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.go), action.go);
        this.AddProperty(nameof(action.length), action.length);
        this.AddProperty(nameof(action.orVideoClip), action.orVideoClip);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static VideoClipGetLengthDoc Document(this ActionContext ctx, VideoClipGetLength Action) =>
        new(ctx, Action);
}
