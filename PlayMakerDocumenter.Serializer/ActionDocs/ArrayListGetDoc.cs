using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListGetDoc : FsmActionDoc
{
    internal ArrayListGetDoc(ActionContext Ctx, ArrayListGet action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.atIndex), action.atIndex);
        this.AddProperty(nameof(action.failureEvent), action.failureEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.result), action.result);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListGetDoc Document(this ActionContext ctx, ArrayListGet Action) =>
        new(ctx, Action);
}
