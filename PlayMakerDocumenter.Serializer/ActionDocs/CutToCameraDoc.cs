using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record CutToCameraDoc : FsmActionDoc
{
    internal CutToCameraDoc(ActionContext Ctx, CutToCamera action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.camera), action.camera);
        this.AddProperty(nameof(action.cutBackOnExit), action.cutBackOnExit);
        this.AddProperty(nameof(action.makeMainCamera), action.makeMainCamera);
        this.AddProperty(nameof(action.oldCamera), action.oldCamera);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static CutToCameraDoc Document(this ActionContext ctx, CutToCamera Action) =>
        new(ctx, Action);
}
