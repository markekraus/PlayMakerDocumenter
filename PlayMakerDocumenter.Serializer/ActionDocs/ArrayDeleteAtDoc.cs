using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayDeleteAtDoc : FsmActionDoc
{
    internal ArrayDeleteAtDoc(ActionContext Ctx, ArrayDeleteAt action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.index), action.index);
        this.AddProperty(nameof(action.indexOutOfRangeEvent), action.indexOutOfRangeEvent);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayDeleteAtDoc Document(this ActionContext ctx, ArrayDeleteAt Action) =>
        new(ctx, Action);
}
