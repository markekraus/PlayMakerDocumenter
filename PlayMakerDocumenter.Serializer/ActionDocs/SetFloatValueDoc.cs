using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetFloatValueDoc : FsmActionDoc
{
    internal SetFloatValueDoc(ActionContext Ctx, SetFloatValue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.floatValue), action.floatValue);
        this.AddProperty(nameof(action.floatVariable), action.floatVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetFloatValueDoc Document(this ActionContext ctx, SetFloatValue Action) =>
        new(ctx, Action);
}
