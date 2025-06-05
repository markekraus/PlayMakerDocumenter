using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetLightIntensityDoc : FsmActionDoc
{
    internal SetLightIntensityDoc(ActionContext Ctx, SetLightIntensity action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.lightIntensity), action.lightIntensity);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetLightIntensityDoc Document(this ActionContext ctx, SetLightIntensity Action) =>
        new(ctx, Action);
}
