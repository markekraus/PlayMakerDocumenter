using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record FindGameObjectDoc : FsmActionDoc
{
    internal FindGameObjectDoc(ActionContext Ctx, FindGameObject action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.objectName), action.objectName);
        this.AddProperty(nameof(action.store), action.store);
        this.AddProperty(nameof(action.withTag), action.withTag);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static FindGameObjectDoc Document(this ActionContext ctx, FindGameObject Action) =>
        new(ctx, Action);
}
