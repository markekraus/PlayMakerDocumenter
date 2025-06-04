using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record IsControllerDoc : FsmActionDoc
{
    internal IsControllerDoc(ActionContext Ctx, IsController action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static IsControllerDoc Document(this ActionContext ctx, IsController Action) =>
        new(ctx, Action);
}
