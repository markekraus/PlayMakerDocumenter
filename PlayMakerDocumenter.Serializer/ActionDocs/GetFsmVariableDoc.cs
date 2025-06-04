using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetFsmVariableDoc : FsmActionDoc
{
    internal GetFsmVariableDoc(ActionContext Ctx, GetFsmVariable action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.cachedFsmName), action.cachedFsmName);
        this.AddProperty(nameof(action.cachedGO), action.cachedGO);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.fsmName), action.fsmName);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.sourceFsm), action.sourceFsm);
        this.AddProperty(nameof(action.sourceVariable), action.sourceVariable);
        this.AddProperty(nameof(action.storeValue), action.storeValue);
        this.AddProperty(nameof(action.targetVariable), action.targetVariable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetFsmVariableDoc Document(this ActionContext ctx, GetFsmVariable Action) =>
        new(ctx, Action);
}
