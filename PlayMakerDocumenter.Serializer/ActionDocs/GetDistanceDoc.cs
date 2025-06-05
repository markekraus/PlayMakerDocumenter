using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetDistanceDoc : FsmActionDoc
{
    internal GetDistanceDoc(ActionContext Ctx, GetDistance action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.target), action.target);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetDistanceDoc Document(this ActionContext ctx, GetDistance Action) =>
        new(ctx, Action);
}
