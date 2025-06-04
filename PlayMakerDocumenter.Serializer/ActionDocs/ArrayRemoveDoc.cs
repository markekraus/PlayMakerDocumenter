using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayRemoveDoc : FsmActionDoc
{
    internal ArrayRemoveDoc(ActionContext Ctx, ArrayRemove action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.allMatches), action.allMatches);
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.value), action.value);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayRemoveDoc Document(this ActionContext ctx, ArrayRemove Action) =>
        new(ctx, Action);
}
