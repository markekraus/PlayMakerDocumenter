using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record IntCompareDoc : FsmActionDoc
{
    internal IntCompareDoc(ActionContext Ctx, IntCompare action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.equal), action.equal);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.greaterThan), action.greaterThan);
        this.AddProperty(nameof(action.integer1), action.integer1);
        this.AddProperty(nameof(action.integer2), action.integer2);
        this.AddProperty(nameof(action.lessThan), action.lessThan);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static IntCompareDoc Document(this ActionContext ctx, IntCompare Action) =>
        new(ctx, Action);
}
