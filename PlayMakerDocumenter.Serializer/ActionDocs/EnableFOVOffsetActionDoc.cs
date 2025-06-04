using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record EnableFOVOffsetActionDoc : FsmActionDoc
{
    internal EnableFOVOffsetActionDoc(ActionContext Ctx, EnableFOVOffsetAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.EnableOffset), action.EnableOffset);
        this.AddProperty(nameof(action.FadeTime), action.FadeTime);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static EnableFOVOffsetActionDoc Document(this ActionContext ctx, EnableFOVOffsetAction Action) =>
        new(ctx, Action);
}
