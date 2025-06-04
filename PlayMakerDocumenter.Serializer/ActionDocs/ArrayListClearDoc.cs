using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListClearDoc : FsmActionDoc
{
    internal ArrayListClearDoc(ActionContext Ctx, ArrayListClear action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListClearDoc Document(this ActionContext ctx, ArrayListClear Action) =>
        new(ctx, Action);
}
