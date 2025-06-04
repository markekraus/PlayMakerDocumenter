using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record CanDocBackActionDoc : FsmActionDoc
{
    internal CanDocBackActionDoc(ActionContext Ctx, CanDocBackAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.falseEvent), action.falseEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.trueEvent), action.trueEvent);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static CanDocBackActionDoc Document(this ActionContext ctx, CanDocBackAction Action) =>
        new(ctx, Action);
}
