using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ConvertFloatToIntDoc : FsmActionDoc
{
    internal ConvertFloatToIntDoc(ActionContext Ctx, ConvertFloatToInt action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.floatVariable), action.floatVariable);
        this.AddProperty(nameof(action.intVariable), action.intVariable);
        this.AddProperty(nameof(action.rounding), action.rounding);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ConvertFloatToIntDoc Document(this ActionContext ctx, ConvertFloatToInt Action) =>
        new(ctx, Action);
}
