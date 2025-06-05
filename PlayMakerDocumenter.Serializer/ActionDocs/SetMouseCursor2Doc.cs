using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetMouseCursor2Doc : FsmActionDoc
{
    internal SetMouseCursor2Doc(ActionContext Ctx, SetMouseCursor2 action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.cursorTexture), action.cursorTexture);
        this.AddProperty(nameof(action.hideCursor), action.hideCursor);
        this.AddProperty(nameof(action.lockCursor), action.lockCursor);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetMouseCursor2Doc Document(this ActionContext ctx, SetMouseCursor2 Action) =>
        new(ctx, Action);
}
