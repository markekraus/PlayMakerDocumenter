using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListContainsDoc : FsmActionDoc
{
    internal ArrayListContainsDoc(ActionContext Ctx, ArrayListContains action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.indexResult), action.indexResult);
        this.AddProperty(nameof(action.isContained), action.isContained);
        this.AddProperty(nameof(action.isContainedEvent), action.isContainedEvent);
        this.AddProperty(nameof(action.isNotContainedEvent), action.isNotContainedEvent);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.variable), action.variable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListContainsDoc Document(this ActionContext ctx, ArrayListContains Action) =>
        new(ctx, Action);
}
