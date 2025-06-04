using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record HashTableRevertSnapShotDoc : FsmActionDoc
{
    internal HashTableRevertSnapShotDoc(ActionContext Ctx, HashTableRevertSnapShot action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static HashTableRevertSnapShotDoc Document(this ActionContext ctx, HashTableRevertSnapShot Action) =>
        new(ctx, Action);
}
