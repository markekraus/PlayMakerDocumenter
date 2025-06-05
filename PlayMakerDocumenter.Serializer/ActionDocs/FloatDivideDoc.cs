using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FloatDivideDoc : FsmActionDoc
{
    internal FloatDivideDoc(ActionContext Ctx, FloatDivide action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.divideBy), action.divideBy);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.floatVariable), action.floatVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FloatDivideDoc Document(this ActionContext ctx, FloatDivide Action) =>
        new(ctx, Action);
}
