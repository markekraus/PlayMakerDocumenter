using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListCopyToDoc : FsmActionDoc
{
    internal ArrayListCopyToDoc(ActionContext Ctx, ArrayListCopyTo action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.count), action.count);
        this.AddProperty(nameof(action.Failed), action.Failed);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.gameObjectTarget), action.gameObjectTarget);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.referenceTarget), action.referenceTarget);
        this.AddProperty(nameof(action.startIndex), action.startIndex);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListCopyToDoc Document(this ActionContext ctx, ArrayListCopyTo Action) =>
        new(ctx, Action);
}
