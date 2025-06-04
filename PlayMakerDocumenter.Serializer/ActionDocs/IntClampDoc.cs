using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record IntClampDoc : FsmActionDoc
{
    internal IntClampDoc(ActionContext Ctx, IntClamp action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.intVariable), action.intVariable);
        this.AddProperty(nameof(action.maxValue), action.maxValue);
        this.AddProperty(nameof(action.minValue), action.minValue);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static IntClampDoc Document(this ActionContext ctx, IntClamp Action) =>
        new(ctx, Action);
}
