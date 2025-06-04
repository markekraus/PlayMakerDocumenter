using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FloatOperatorDoc : FsmActionDoc
{
    internal FloatOperatorDoc(ActionContext Ctx, FloatOperator action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.float1), action.float1);
        this.AddProperty(nameof(action.float2), action.float2);
        this.AddProperty(nameof(action.operation), action.operation);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FloatOperatorDoc Document(this ActionContext ctx, FloatOperator Action) =>
        new(ctx, Action);
}
