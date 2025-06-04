using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetOwnerDoc : FsmActionDoc
{
    internal GetOwnerDoc(ActionContext Ctx, GetOwner action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.storeGameObject), action.storeGameObject);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetOwnerDoc Document(this ActionContext ctx, GetOwner Action) =>
        new(ctx, Action);
}
