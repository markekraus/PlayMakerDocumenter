using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetFogEndDistanceDoc : FsmActionDoc
{
    internal SetFogEndDistanceDoc(ActionContext Ctx, SetFogEndDistance action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.endDistance), action.endDistance);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetFogEndDistanceDoc Document(this ActionContext ctx, SetFogEndDistance Action) =>
        new(ctx, Action);
}
