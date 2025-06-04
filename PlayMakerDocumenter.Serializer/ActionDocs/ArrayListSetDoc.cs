using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListSetDoc : FsmActionDoc
{
    internal ArrayListSetDoc(ActionContext Ctx, ArrayListSet action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.atIndex), action.atIndex);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.forceResizeIdNeeded), action.forceResizeIdNeeded);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.variable), action.variable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListSetDoc Document(this ActionContext ctx, ArrayListSet Action) =>
        new(ctx, Action);
}
