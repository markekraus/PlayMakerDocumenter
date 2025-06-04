using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetMaterialTextureDoc : FsmActionDoc
{
    internal SetMaterialTextureDoc(ActionContext Ctx, SetMaterialTexture action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.material), action.material);
        this.AddProperty(nameof(action.materialIndex), action.materialIndex);
        this.AddProperty(nameof(action.namedTexture), action.namedTexture);
        this.AddProperty(nameof(action.texture), action.texture);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetMaterialTextureDoc Document(this ActionContext ctx, SetMaterialTexture Action) =>
        new(ctx, Action);
}
