using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GameObjectIsNullDoc : FsmActionDoc
{
    internal GameObjectIsNullDoc(ActionContext Ctx, GameObjectIsNull action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.isNotNull), action.isNotNull);
        this.AddProperty(nameof(action.isNull), action.isNull);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GameObjectIsNullDoc Document(this ActionContext ctx, GameObjectIsNull Action) =>
        new(ctx, Action);
}
