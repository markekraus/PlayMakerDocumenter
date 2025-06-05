using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListRemoveDoc : FsmActionDoc
{
    internal ArrayListRemoveDoc(ActionContext Ctx, ArrayListRemove action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.notFoundEvent), action.notFoundEvent);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.variable), action.variable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListRemoveDoc Document(this ActionContext ctx, ArrayListRemove Action) =>
        new(ctx, Action);
}
