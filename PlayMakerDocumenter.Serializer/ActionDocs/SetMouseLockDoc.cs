using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetMouseLockDoc : FsmActionDoc
{
    internal SetMouseLockDoc(ActionContext Ctx, SetMouseLock action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.lockCursor), action.lockCursor);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetMouseLockDoc Document(this ActionContext ctx, SetMouseLock Action) =>
        new(ctx, Action);
}
