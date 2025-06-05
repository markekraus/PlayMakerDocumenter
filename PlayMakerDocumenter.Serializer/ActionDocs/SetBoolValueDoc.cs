using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetBoolValueDoc : FsmActionDoc
{
    internal SetBoolValueDoc(ActionContext Ctx, SetBoolValue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.boolValue), action.boolValue);
        this.AddProperty(nameof(action.boolVariable), action.boolVariable);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetBoolValueDoc Document(this ActionContext ctx, SetBoolValue Action) =>
        new(ctx, Action);
}
