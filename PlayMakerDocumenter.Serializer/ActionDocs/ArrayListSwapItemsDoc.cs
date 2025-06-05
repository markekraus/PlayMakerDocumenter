using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListSwapItemsDoc : FsmActionDoc
{
    internal ArrayListSwapItemsDoc(ActionContext Ctx, ArrayListSwapItems action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.failureEvent), action.failureEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.index1), action.index1);
        this.AddProperty(nameof(action.index2), action.index2);
        this.AddProperty(nameof(action.reference), action.reference);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListSwapItemsDoc Document(this ActionContext ctx, ArrayListSwapItems Action) =>
        new(ctx, Action);
}
