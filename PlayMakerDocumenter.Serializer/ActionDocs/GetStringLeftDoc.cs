using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetStringLeftDoc : FsmActionDoc
{
    internal GetStringLeftDoc(ActionContext Ctx, GetStringLeft action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.charCount), action.charCount);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetStringLeftDoc Document(this ActionContext ctx, GetStringLeft Action) =>
        new(ctx, Action);
}
