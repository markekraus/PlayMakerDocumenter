using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetFogDensityDoc : FsmActionDoc
{
    internal GetFogDensityDoc(ActionContext Ctx, GetFogDensity action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.density), action.density);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetFogDensityDoc Document(this ActionContext ctx, GetFogDensity Action) =>
        new(ctx, Action);
}
