using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetMouseButtonUpDoc : FsmActionDoc
{
    internal GetMouseButtonUpDoc(ActionContext Ctx, GetMouseButtonUp action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.button), action.button);
        this.AddProperty(nameof(action.inUpdateOnly), action.inUpdateOnly);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetMouseButtonUpDoc Document(this ActionContext ctx, GetMouseButtonUp Action) =>
        new(ctx, Action);
}
