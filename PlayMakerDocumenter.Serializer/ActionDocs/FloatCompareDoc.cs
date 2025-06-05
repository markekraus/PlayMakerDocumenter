using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FloatCompareDoc : FsmActionDoc
{
    internal FloatCompareDoc(ActionContext Ctx, FloatCompare action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.equal), action.equal);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.float1), action.float1);
        this.AddProperty(nameof(action.float2), action.float2);
        this.AddProperty(nameof(action.greaterThan), action.greaterThan);
        this.AddProperty(nameof(action.lessThan), action.lessThan);
        this.AddProperty(nameof(action.tolerance), action.tolerance);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FloatCompareDoc Document(this ActionContext ctx, FloatCompare Action) =>
        new(ctx, Action);
}
