using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FloatRoundDoc : FsmActionDoc
{
    internal FloatRoundDoc(ActionContext Ctx, FloatRound action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.floatVariable), action.floatVariable);
        this.AddProperty(nameof(action.resultAsFloat), action.resultAsFloat);
        this.AddProperty(nameof(action.resultAsInt), action.resultAsInt);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FloatRoundDoc Document(this ActionContext ctx, FloatRound Action) =>
        new(ctx, Action);
}
