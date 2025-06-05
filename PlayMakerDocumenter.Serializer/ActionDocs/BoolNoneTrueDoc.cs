using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record BoolNoneTrueDoc : FsmActionDoc
{
    internal BoolNoneTrueDoc(ActionContext Ctx, BoolNoneTrue action) : base(Ctx)
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
    public static BoolNoneTrueDoc Document(this ActionContext ctx, BoolNoneTrue Action) =>
        new(ctx, Action);
}
