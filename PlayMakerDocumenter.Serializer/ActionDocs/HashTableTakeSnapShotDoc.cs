using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record HashTableTakeSnapShotDoc : FsmActionDoc
{
    internal HashTableTakeSnapShotDoc(ActionContext Ctx, HashTableTakeSnapShot action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static HashTableTakeSnapShotDoc Document(this ActionContext ctx, HashTableTakeSnapShot Action) =>
        new(ctx, Action);
}
