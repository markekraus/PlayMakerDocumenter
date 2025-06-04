using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetMouseCursorDoc : FsmActionDoc
{
    internal SetMouseCursorDoc(ActionContext Ctx, SetMouseCursor action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.cursorTexture), action.cursorTexture);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.hideCursor), action.hideCursor);
        this.AddProperty(nameof(action.lockCursor), action.lockCursor);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetMouseCursorDoc Document(this ActionContext ctx, SetMouseCursor Action) =>
        new(ctx, Action);
}
