using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayResizeDoc : FsmActionDoc
{
    internal ArrayResizeDoc(ActionContext Ctx, ArrayResize action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.newSize), action.newSize);
        this.AddProperty(nameof(action.sizeOutOfRangeEvent), action.sizeOutOfRangeEvent);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayResizeDoc Document(this ActionContext ctx, ArrayResize Action) =>
        new(ctx, Action);
}
