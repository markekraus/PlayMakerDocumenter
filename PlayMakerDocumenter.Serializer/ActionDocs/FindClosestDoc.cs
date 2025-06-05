using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FindClosestDoc : FsmActionDoc
{
    internal FindClosestDoc(ActionContext Ctx, FindClosest action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.ignoreOwner), action.ignoreOwner);
        this.AddProperty(nameof(action.mustBeVisible), action.mustBeVisible);
        this.AddProperty(nameof(action.storeDistance), action.storeDistance);
        this.AddProperty(nameof(action.storeObject), action.storeObject);
        this.AddProperty(nameof(action.withTag), action.withTag);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FindClosestDoc Document(this ActionContext ctx, FindClosest Action) =>
        new(ctx, Action);
}
