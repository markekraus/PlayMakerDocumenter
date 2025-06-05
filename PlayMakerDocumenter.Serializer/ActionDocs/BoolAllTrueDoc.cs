using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record BoolAllTrueDoc : FsmActionDoc
{
    internal BoolAllTrueDoc(ActionContext Ctx, BoolAllTrue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.boolVariables), action.boolVariables);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static BoolAllTrueDoc Document(this ActionContext ctx, BoolAllTrue Action) =>
        new(ctx, Action);
}
