using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record HashTableGetNextDoc : FsmActionDoc
{
    internal HashTableGetNextDoc(ActionContext Ctx, HashTableGetNext action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._keys), action._keys);
        this.AddProperty(nameof(action.endIndex), action.endIndex);
        this.AddProperty(nameof(action.failureEvent), action.failureEvent);
        this.AddProperty(nameof(action.finishedEvent), action.finishedEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.key), action.key);
        this.AddProperty(nameof(action.loopEvent), action.loopEvent);
        this.AddProperty(nameof(action.nextItemIndex), action.nextItemIndex);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.reset), action.reset);
        this.AddProperty(nameof(action.result), action.result);
        this.AddProperty(nameof(action.startIndex), action.startIndex);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static HashTableGetNextDoc Document(this ActionContext ctx, HashTableGetNext Action) =>
        new(ctx, Action);
}
