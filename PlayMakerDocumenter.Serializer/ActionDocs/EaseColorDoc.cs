using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record EaseColorDoc : FsmActionDoc
{
    internal EaseColorDoc(ActionContext Ctx, EaseColor action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.colorVariable), action.colorVariable);
        this.AddProperty(nameof(action.finishInNextStep), action.finishInNextStep);
        this.AddProperty(nameof(action.fromValue), action.fromValue);
        this.AddProperty(nameof(action.toValue), action.toValue);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static EaseColorDoc Document(this ActionContext ctx, EaseColor Action) =>
        new(ctx, Action);
}
