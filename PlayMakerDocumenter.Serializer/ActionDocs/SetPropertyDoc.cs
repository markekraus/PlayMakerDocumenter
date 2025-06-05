using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetPropertyDoc : FsmActionDoc
{
    internal SetPropertyDoc(ActionContext Ctx, SetProperty action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.targetProperty), action.targetProperty);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetPropertyDoc Document(this ActionContext ctx, SetProperty Action) =>
        new(ctx, Action);
}
