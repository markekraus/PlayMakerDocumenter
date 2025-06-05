using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record HashTableKeysDoc : FsmActionDoc
{
    internal HashTableKeysDoc(ActionContext Ctx, HashTableKeys action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.arrayListGameObject), action.arrayListGameObject);
        this.AddProperty(nameof(action.arrayListReference), action.arrayListReference);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static HashTableKeysDoc Document(this ActionContext ctx, HashTableKeys Action) =>
        new(ctx, Action);
}
