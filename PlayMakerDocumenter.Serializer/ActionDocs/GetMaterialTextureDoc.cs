using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetMaterialTextureDoc : FsmActionDoc
{
    internal GetMaterialTextureDoc(ActionContext Ctx, GetMaterialTexture action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.getFromSharedMaterial), action.getFromSharedMaterial);
        this.AddProperty(nameof(action.materialIndex), action.materialIndex);
        this.AddProperty(nameof(action.namedTexture), action.namedTexture);
        this.AddProperty(nameof(action.storedTexture), action.storedTexture);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetMaterialTextureDoc Document(this ActionContext ctx, GetMaterialTexture Action) =>
        new(ctx, Action);
}
