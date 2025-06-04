using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record BoolAnyTrueDoc : FsmActionDoc
{
    internal BoolAnyTrueDoc(ActionContext Ctx, BoolAnyTrue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.boolVariables), action.boolVariables);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static BoolAnyTrueDoc Document(this ActionContext ctx, BoolAnyTrue Action) =>
        new(ctx, Action);
}
