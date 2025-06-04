using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record EaseFloatDoc : FsmActionDoc
{
    internal EaseFloatDoc(ActionContext Ctx, EaseFloat action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.finishInNextStep), action.finishInNextStep);
        this.AddProperty(nameof(action.floatVariable), action.floatVariable);
        this.AddProperty(nameof(action.fromValue), action.fromValue);
        this.AddProperty(nameof(action.toValue), action.toValue);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static EaseFloatDoc Document(this ActionContext ctx, EaseFloat Action) =>
        new(ctx, Action);
}
