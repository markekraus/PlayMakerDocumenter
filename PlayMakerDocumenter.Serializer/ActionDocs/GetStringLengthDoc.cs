using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetStringLengthDoc : FsmActionDoc
{
    internal GetStringLengthDoc(ActionContext Ctx, GetStringLength action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetStringLengthDoc Document(this ActionContext ctx, GetStringLength Action) =>
        new(ctx, Action);
}
