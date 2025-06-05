using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ConvertBoolToIntDoc : FsmActionDoc
{
    internal ConvertBoolToIntDoc(ActionContext Ctx, ConvertBoolToInt action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.boolVariable), action.boolVariable);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.falseValue), action.falseValue);
        this.AddProperty(nameof(action.intVariable), action.intVariable);
        this.AddProperty(nameof(action.trueValue), action.trueValue);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ConvertBoolToIntDoc Document(this ActionContext ctx, ConvertBoolToInt Action) =>
        new(ctx, Action);
}
