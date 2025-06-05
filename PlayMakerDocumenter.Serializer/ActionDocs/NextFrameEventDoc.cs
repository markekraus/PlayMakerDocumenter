using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record NextFrameEventDoc : FsmActionDoc
{
    internal NextFrameEventDoc(ActionContext Ctx, NextFrameEvent action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static NextFrameEventDoc Document(this ActionContext ctx, NextFrameEvent Action) =>
        new(ctx, Action);
}
