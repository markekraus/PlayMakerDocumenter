using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record DestroySelfDoc : FsmActionDoc
{
    internal DestroySelfDoc(ActionContext Ctx, DestroySelf action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.delay), action.delay);
        this.AddProperty(nameof(action.detachChildren), action.detachChildren);
        this.AddProperty(nameof(action.elapsedTime), action.elapsedTime);
        this.AddProperty(nameof(action.realTime), action.realTime);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static DestroySelfDoc Document(this ActionContext ctx, DestroySelf Action) =>
        new(ctx, Action);
}
