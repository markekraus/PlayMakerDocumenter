using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record HashTableGetDoc : FsmActionDoc
{
    internal HashTableGetDoc(ActionContext Ctx, HashTableGet action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.key), action.key);
        this.AddProperty(nameof(action.KeyFoundEvent), action.KeyFoundEvent);
        this.AddProperty(nameof(action.KeyNotFoundEvent), action.KeyNotFoundEvent);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.result), action.result);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static HashTableGetDoc Document(this ActionContext ctx, HashTableGet Action) =>
        new(ctx, Action);
}
