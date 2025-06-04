using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListCountDoc : FsmActionDoc
{
    internal ArrayListCountDoc(ActionContext Ctx, ArrayListCount action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.count), action.count);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListCountDoc Document(this ActionContext ctx, ArrayListCount Action) =>
        new(ctx, Action);
}
