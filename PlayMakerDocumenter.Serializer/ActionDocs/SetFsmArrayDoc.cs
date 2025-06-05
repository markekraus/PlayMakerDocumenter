using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetFsmArrayDoc : FsmActionDoc
{
    internal SetFsmArrayDoc(ActionContext Ctx, SetFsmArray action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.copyValues), action.copyValues);
        this.AddProperty(nameof(action.fsmName), action.fsmName);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.setValue), action.setValue);
        this.AddProperty(nameof(action.variableName), action.variableName);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetFsmArrayDoc Document(this ActionContext ctx, SetFsmArray Action) =>
        new(ctx, Action);
}
