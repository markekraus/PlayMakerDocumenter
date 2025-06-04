using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetFsmArrayDoc : FsmActionDoc
{
    internal GetFsmArrayDoc(ActionContext Ctx, GetFsmArray action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.copyValues), action.copyValues);
        this.AddProperty(nameof(action.fsmName), action.fsmName);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.storeValue), action.storeValue);
        this.AddProperty(nameof(action.variableName), action.variableName);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetFsmArrayDoc Document(this ActionContext ctx, GetFsmArray Action) =>
        new(ctx, Action);
}
