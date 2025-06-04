using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetMainCameraDoc : FsmActionDoc
{
    internal SetMainCameraDoc(ActionContext Ctx, SetMainCamera action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetMainCameraDoc Document(this ActionContext ctx, SetMainCamera Action) =>
        new(ctx, Action);
}
