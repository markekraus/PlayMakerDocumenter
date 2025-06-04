using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record CutToCamera2Doc : FsmActionDoc
{
    internal CutToCamera2Doc(ActionContext Ctx, CutToCamera2 action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._go), action._go);
        this.AddProperty(nameof(action.camera), action.camera);
        this.AddProperty(nameof(action.cutBackOnExit), action.cutBackOnExit);
        this.AddProperty(nameof(action.makeMainCamera), action.makeMainCamera);
        this.AddProperty(nameof(action.oldCamera), action.oldCamera);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static CutToCamera2Doc Document(this ActionContext ctx, CutToCamera2 Action) =>
        new(ctx, Action);
}
