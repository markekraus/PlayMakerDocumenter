using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayGetDoc : FsmActionDoc
{
    internal ArrayGetDoc(ActionContext Ctx, ArrayGet action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.index), action.index);
        this.AddProperty(nameof(action.indexOutOfRange), action.indexOutOfRange);
        this.AddProperty(nameof(action.storeValue), action.storeValue);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayGetDoc Document(this ActionContext ctx, ArrayGet Action) =>
        new(ctx, Action);
}
