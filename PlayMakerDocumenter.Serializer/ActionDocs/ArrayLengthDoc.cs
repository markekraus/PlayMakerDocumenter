using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayLengthDoc : FsmActionDoc
{
    internal ArrayLengthDoc(ActionContext Ctx, ArrayLength action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.length), action.length);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayLengthDoc Document(this ActionContext ctx, ArrayLength Action) =>
        new(ctx, Action);
}
