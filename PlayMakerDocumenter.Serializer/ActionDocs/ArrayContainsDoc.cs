using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayContainsDoc : FsmActionDoc
{
    internal ArrayContainsDoc(ActionContext Ctx, ArrayContains action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.index), action.index);
        this.AddProperty(nameof(action.isContained), action.isContained);
        this.AddProperty(nameof(action.isContainedEvent), action.isContainedEvent);
        this.AddProperty(nameof(action.isNotContainedEvent), action.isNotContainedEvent);
        this.AddProperty(nameof(action.value), action.value);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayContainsDoc Document(this ActionContext ctx, ArrayContains Action) =>
        new(ctx, Action);
}
