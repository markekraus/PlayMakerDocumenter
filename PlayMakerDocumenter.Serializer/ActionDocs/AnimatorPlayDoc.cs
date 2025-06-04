using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AnimatorPlayDoc : FsmActionDoc
{
    internal AnimatorPlayDoc(ActionContext Ctx, AnimatorPlay action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.animator), action.animator);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.layer), action.layer);
        this.AddProperty(nameof(action.normalizedTime), action.normalizedTime);
        this.AddProperty(nameof(action.stateName), action.stateName);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AnimatorPlayDoc Document(this ActionContext ctx, AnimatorPlay Action) =>
        new(ctx, Action);
}
