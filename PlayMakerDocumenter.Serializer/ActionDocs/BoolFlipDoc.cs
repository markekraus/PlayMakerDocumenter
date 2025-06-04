using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record BoolFlipDoc : FsmActionDoc
{
    internal BoolFlipDoc(ActionContext Ctx, BoolFlip action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.boolVariable), action.boolVariable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static BoolFlipDoc Document(this ActionContext ctx, BoolFlip Action) =>
        new(ctx, Action);
}
