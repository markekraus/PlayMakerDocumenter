using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetMeshDoc : FsmActionDoc
{
    internal SetMeshDoc(ActionContext Ctx, SetMesh action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.meshObject), action.meshObject);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetMeshDoc Document(this ActionContext ctx, SetMesh Action) =>
        new(ctx, Action);
}
