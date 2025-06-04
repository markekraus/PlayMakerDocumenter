using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayGetNextDoc : FsmActionDoc
{
    internal ArrayGetNextDoc(ActionContext Ctx, ArrayGetNext action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.currentIndex), action.currentIndex);
        this.AddProperty(nameof(action.endIndex), action.endIndex);
        this.AddProperty(nameof(action.finishedEvent), action.finishedEvent);
        this.AddProperty(nameof(action.loopEvent), action.loopEvent);
        this.AddProperty(nameof(action.nextItemIndex), action.nextItemIndex);
        this.AddProperty(nameof(action.resetFlag), action.resetFlag);
        this.AddProperty(nameof(action.result), action.result);
        this.AddProperty(nameof(action.startIndex), action.startIndex);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayGetNextDoc Document(this ActionContext ctx, ArrayGetNext Action) =>
        new(ctx, Action);
}
