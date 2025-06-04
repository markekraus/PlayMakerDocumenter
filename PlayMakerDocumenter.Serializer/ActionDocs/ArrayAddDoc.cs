using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayAddDoc : FsmActionDoc
{
    internal ArrayAddDoc(ActionContext Ctx, ArrayAdd action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.value), action.value);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayAddDoc Document(this ActionContext ctx, ArrayAdd Action) =>
        new(ctx, Action);
}
