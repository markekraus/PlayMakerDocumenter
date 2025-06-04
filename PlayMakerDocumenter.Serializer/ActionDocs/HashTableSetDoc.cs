using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record HashTableSetDoc : FsmActionDoc
{
    internal HashTableSetDoc(ActionContext Ctx, HashTableSet action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.convertIntToByte), action.convertIntToByte);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.key), action.key);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.variable), action.variable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static HashTableSetDoc Document(this ActionContext ctx, HashTableSet Action) =>
        new(ctx, Action);
}
