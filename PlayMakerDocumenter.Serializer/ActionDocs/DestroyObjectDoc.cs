using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record DestroyObjectDoc : FsmActionDoc
{
    internal DestroyObjectDoc(ActionContext Ctx, DestroyObject action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.delay), action.delay);
        this.AddProperty(nameof(action.detachChildren), action.detachChildren);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static DestroyObjectDoc Document(this ActionContext ctx, DestroyObject Action) =>
        new(ctx, Action);
}
