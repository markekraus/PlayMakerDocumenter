using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FloatClampDoc : FsmActionDoc
{
    internal FloatClampDoc(ActionContext Ctx, FloatClamp action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.floatVariable), action.floatVariable);
        this.AddProperty(nameof(action.maxValue), action.maxValue);
        this.AddProperty(nameof(action.minValue), action.minValue);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FloatClampDoc Document(this ActionContext ctx, FloatClamp Action) =>
        new(ctx, Action);
}
