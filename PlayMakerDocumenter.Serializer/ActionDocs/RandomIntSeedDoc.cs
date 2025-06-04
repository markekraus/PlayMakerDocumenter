using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record RandomIntSeedDoc : FsmActionDoc
{
    internal RandomIntSeedDoc(ActionContext Ctx, RandomIntSeed action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.max), action.max);
        this.AddProperty(nameof(action.min), action.min);
        this.AddProperty(nameof(action.seed), action.seed);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static RandomIntSeedDoc Document(this ActionContext ctx, RandomIntSeed Action) =>
        new(ctx, Action);
}
