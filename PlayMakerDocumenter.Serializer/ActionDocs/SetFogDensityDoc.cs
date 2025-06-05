using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetFogDensityDoc : FsmActionDoc
{
    internal SetFogDensityDoc(ActionContext Ctx, SetFogDensity action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.fogDensity), action.fogDensity);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetFogDensityDoc Document(this ActionContext ctx, SetFogDensity Action) =>
        new(ctx, Action);
}
