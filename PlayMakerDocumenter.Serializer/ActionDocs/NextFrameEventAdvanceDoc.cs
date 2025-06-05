using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record NextFrameEventAdvanceDoc : FsmActionDoc
{
    internal NextFrameEventAdvanceDoc(ActionContext Ctx, NextFrameEventAdvance action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.frameCount), action.frameCount);
        this.AddProperty(nameof(action.loop), action.loop);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static NextFrameEventAdvanceDoc Document(this ActionContext ctx, NextFrameEventAdvance Action) =>
        new(ctx, Action);
}
