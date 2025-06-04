using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FindClosest2Doc : FsmActionDoc
{
    internal FindClosest2Doc(ActionContext Ctx, FindClosest2 action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._layerMask), action._layerMask);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.ignoreOwner), action.ignoreOwner);
        this.AddProperty(nameof(action.invertMask), action.invertMask);
        this.AddProperty(nameof(action.layerMask), action.layerMask);
        this.AddProperty(nameof(action.mustBeVisible), action.mustBeVisible);
        this.AddProperty(nameof(action.storeDistance), action.storeDistance);
        this.AddProperty(nameof(action.storeObject), action.storeObject);
        this.AddProperty(nameof(action.withTag), action.withTag);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FindClosest2Doc Document(this ActionContext ctx, FindClosest2 Action) =>
        new(ctx, Action);
}
