using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FloatAddDoc : FsmActionDoc
{
    internal FloatAddDoc(ActionContext Ctx, FloatAdd action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.add), action.add);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.floatVariable), action.floatVariable);
        this.AddProperty(nameof(action.perSecond), action.perSecond);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FloatAddDoc Document(this ActionContext ctx, FloatAdd Action) =>
        new(ctx, Action);
}
