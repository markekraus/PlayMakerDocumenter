using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record RandomFloatDoc : FsmActionDoc
{
    internal RandomFloatDoc(ActionContext Ctx, RandomFloat action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.max), action.max);
        this.AddProperty(nameof(action.min), action.min);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static RandomFloatDoc Document(this ActionContext ctx, RandomFloat Action) =>
        new(ctx, Action);
}
