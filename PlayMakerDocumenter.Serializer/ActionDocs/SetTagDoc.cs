using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetTagDoc : FsmActionDoc
{
    internal SetTagDoc(ActionContext Ctx, SetTag action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.tag), action.tag);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetTagDoc Document(this ActionContext ctx, SetTag Action) =>
        new(ctx, Action);
}
