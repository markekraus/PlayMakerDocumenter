using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FloatInterpolateDoc : FsmActionDoc
{
    internal FloatInterpolateDoc(ActionContext Ctx, FloatInterpolate action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.currentTime), action.currentTime);
        this.AddProperty(nameof(action.finishEvent), action.finishEvent);
        this.AddProperty(nameof(action.fromFloat), action.fromFloat);
        this.AddProperty(nameof(action.mode), action.mode);
        this.AddProperty(nameof(action.realTime), action.realTime);
        this.AddProperty(nameof(action.startTime), action.startTime);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.time), action.time);
        this.AddProperty(nameof(action.toFloat), action.toFloat);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FloatInterpolateDoc Document(this ActionContext ctx, FloatInterpolate Action) =>
        new(ctx, Action);
}
