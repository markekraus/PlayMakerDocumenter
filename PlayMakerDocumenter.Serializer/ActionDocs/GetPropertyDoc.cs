using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetPropertyDoc : FsmActionDoc
{
    internal GetPropertyDoc(ActionContext Ctx, GetProperty action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.targetProperty), action.targetProperty);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetPropertyDoc Document(this ActionContext ctx, GetProperty Action) =>
        new(ctx, Action);
}
