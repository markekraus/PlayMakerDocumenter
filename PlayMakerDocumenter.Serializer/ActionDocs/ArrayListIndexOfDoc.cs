using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListIndexOfDoc : FsmActionDoc
{
    internal ArrayListIndexOfDoc(ActionContext Ctx, ArrayListIndexOf action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.count), action.count);
        this.AddProperty(nameof(action.failureEvent), action.failureEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.indexOf), action.indexOf);
        this.AddProperty(nameof(action.itemFound), action.itemFound);
        this.AddProperty(nameof(action.itemNotFound), action.itemNotFound);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.startIndex), action.startIndex);
        this.AddProperty(nameof(action.variable), action.variable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListIndexOfDoc Document(this ActionContext ctx, ArrayListIndexOf Action) =>
        new(ctx, Action);
}
