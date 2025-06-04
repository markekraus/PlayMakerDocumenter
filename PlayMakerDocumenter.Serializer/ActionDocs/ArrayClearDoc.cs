using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayClearDoc : FsmActionDoc
{
    internal ArrayClearDoc(ActionContext Ctx, ArrayClear action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.resetValue), action.resetValue);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayClearDoc Document(this ActionContext ctx, ArrayClear Action) =>
        new(ctx, Action);
}
