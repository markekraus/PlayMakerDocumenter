using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetLayerRecursiveDoc : FsmActionDoc
{
    internal SetLayerRecursiveDoc(ActionContext Ctx, SetLayerRecursive action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.children), action.children);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.layer), action.layer);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetLayerRecursiveDoc Document(this ActionContext ctx, SetLayerRecursive Action) =>
        new(ctx, Action);
}
