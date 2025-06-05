using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record IntOperatorDoc : FsmActionDoc
{
    internal IntOperatorDoc(ActionContext Ctx, IntOperator action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.integer1), action.integer1);
        this.AddProperty(nameof(action.integer2), action.integer2);
        this.AddProperty(nameof(action.operation), action.operation);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static IntOperatorDoc Document(this ActionContext ctx, IntOperator Action) =>
        new(ctx, Action);
}
