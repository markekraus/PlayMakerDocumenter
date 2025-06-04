using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListFindGameObjectsByTagDoc : FsmActionDoc
{
    internal ArrayListFindGameObjectsByTagDoc(ActionContext Ctx, ArrayListFindGameObjectsByTag action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.tag), action.tag);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListFindGameObjectsByTagDoc Document(this ActionContext ctx, ArrayListFindGameObjectsByTag Action) =>
        new(ctx, Action);
}
