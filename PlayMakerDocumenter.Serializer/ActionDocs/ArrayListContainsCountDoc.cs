using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListContainsCountDoc : FsmActionDoc
{
    internal ArrayListContainsCountDoc(ActionContext Ctx, ArrayListContainsCount action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.atIndex), action.atIndex);
        this.AddProperty(nameof(action.count), action.count);
        this.AddProperty(nameof(action.failureEvent), action.failureEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.totalArrayCount), action.totalArrayCount);
        this.AddProperty(nameof(action.variable), action.variable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListContainsCountDoc Document(this ActionContext ctx, ArrayListContainsCount Action) =>
        new(ctx, Action);
}
