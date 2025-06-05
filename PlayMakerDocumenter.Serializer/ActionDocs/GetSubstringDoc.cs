using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetSubstringDoc : FsmActionDoc
{
    internal GetSubstringDoc(ActionContext Ctx, GetSubstring action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.length), action.length);
        this.AddProperty(nameof(action.startIndex), action.startIndex);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetSubstringDoc Document(this ActionContext ctx, GetSubstring Action) =>
        new(ctx, Action);
}
