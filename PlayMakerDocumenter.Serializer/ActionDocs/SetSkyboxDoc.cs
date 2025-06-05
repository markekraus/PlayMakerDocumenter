using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetSkyboxDoc : FsmActionDoc
{
    internal SetSkyboxDoc(ActionContext Ctx, SetSkybox action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.skybox), action.skybox);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetSkyboxDoc Document(this ActionContext ctx, SetSkybox Action) =>
        new(ctx, Action);
}
