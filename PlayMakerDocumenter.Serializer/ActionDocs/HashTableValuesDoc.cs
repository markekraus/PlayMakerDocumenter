using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record HashTableValuesDoc : FsmActionDoc
{
    internal HashTableValuesDoc(ActionContext Ctx, HashTableValues action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.arrayListGameObject), action.arrayListGameObject);
        this.AddProperty(nameof(action.arrayListReference), action.arrayListReference);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static HashTableValuesDoc Document(this ActionContext ctx, HashTableValues Action) =>
        new(ctx, Action);
}
