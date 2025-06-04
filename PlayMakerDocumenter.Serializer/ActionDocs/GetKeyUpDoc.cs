using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetKeyUpDoc : FsmActionDoc
{
    internal GetKeyUpDoc(ActionContext Ctx, GetKeyUp action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.key), action.key);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetKeyUpDoc Document(this ActionContext ctx, GetKeyUp Action) =>
        new(ctx, Action);
}
