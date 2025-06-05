using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetLayerDoc : FsmActionDoc
{
    internal SetLayerDoc(ActionContext Ctx, SetLayer action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.layer), action.layer);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetLayerDoc Document(this ActionContext ctx, SetLayer Action) =>
        new(ctx, Action);
}
