using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GameObjectCompareDoc : FsmActionDoc
{
    internal GameObjectCompareDoc(ActionContext Ctx, GameObjectCompare action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.compareTo), action.compareTo);
        this.AddProperty(nameof(action.equalEvent), action.equalEvent);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObjectVariable), action.gameObjectVariable);
        this.AddProperty(nameof(action.notEqualEvent), action.notEqualEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GameObjectCompareDoc Document(this ActionContext ctx, GameObjectCompare Action) =>
        new(ctx, Action);
}
