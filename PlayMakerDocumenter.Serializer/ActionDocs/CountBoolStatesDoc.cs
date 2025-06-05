using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record CountBoolStatesDoc : FsmActionDoc
{
    internal CountBoolStatesDoc(ActionContext Ctx, CountBoolStates action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.boolVariables), action.boolVariables);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.falseCount), action.falseCount);
        this.AddProperty(nameof(action.trueCount), action.trueCount);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static CountBoolStatesDoc Document(this ActionContext ctx, CountBoolStates Action) =>
        new(ctx, Action);
}
