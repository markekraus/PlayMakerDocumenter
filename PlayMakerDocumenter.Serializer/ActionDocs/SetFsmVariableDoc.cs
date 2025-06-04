using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetFsmVariableDoc : FsmActionDoc
{
    internal SetFsmVariableDoc(ActionContext Ctx, SetFsmVariable action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.cachedFsmName), action.cachedFsmName);
        this.AddProperty(nameof(action.cachedGameObject), action.cachedGameObject);
        this.AddProperty(nameof(action.cachedVariableName), action.cachedVariableName);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.fsmName), action.fsmName);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.setValue), action.setValue);
        this.AddProperty(nameof(action.targetFsm), action.targetFsm);
        this.AddProperty(nameof(action.targetVariable), action.targetVariable);
        this.AddProperty(nameof(action.variableName), action.variableName);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetFsmVariableDoc Document(this ActionContext ctx, SetFsmVariable Action) =>
        new(ctx, Action);
}
