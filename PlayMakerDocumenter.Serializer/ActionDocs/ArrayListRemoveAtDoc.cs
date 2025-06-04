using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListRemoveAtDoc : FsmActionDoc
{
    internal ArrayListRemoveAtDoc(ActionContext Ctx, ArrayListRemoveAt action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.failureEvent), action.failureEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.index), action.index);
        this.AddProperty(nameof(action.reference), action.reference);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListRemoveAtDoc Document(this ActionContext ctx, ArrayListRemoveAt Action) =>
        new(ctx, Action);
}
