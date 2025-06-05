using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetParentDoc : FsmActionDoc
{
    internal SetParentDoc(ActionContext Ctx, SetParent action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.parent), action.parent);
        this.AddProperty(nameof(action.resetLocalPosition), action.resetLocalPosition);
        this.AddProperty(nameof(action.resetLocalRotation), action.resetLocalRotation);
        this.AddProperty(nameof(action.worldPositionStays), action.worldPositionStays);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetParentDoc Document(this ActionContext ctx, SetParent Action) =>
        new(ctx, Action);
}
