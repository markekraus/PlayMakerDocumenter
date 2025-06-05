using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListGetRandomDoc : FsmActionDoc
{
    internal ArrayListGetRandomDoc(ActionContext Ctx, ArrayListGetRandom action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.failureEvent), action.failureEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.randomIndex), action.randomIndex);
        this.AddProperty(nameof(action.randomItem), action.randomItem);
        this.AddProperty(nameof(action.reference), action.reference);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListGetRandomDoc Document(this ActionContext ctx, ArrayListGetRandom Action) =>
        new(ctx, Action);
}
