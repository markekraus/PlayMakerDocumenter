using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayRemoveAllDoc : FsmActionDoc
{
    internal ArrayRemoveAllDoc(ActionContext Ctx, ArrayRemoveAll action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayRemoveAllDoc Document(this ActionContext ctx, ArrayRemoveAll Action) =>
        new(ctx, Action);
}
