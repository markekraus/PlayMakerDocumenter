using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetTextureNameDoc : FsmActionDoc
{
    internal GetTextureNameDoc(ActionContext Ctx, GetTextureName action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.texture), action.texture);
        this.AddProperty(nameof(action.textureName), action.textureName);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetTextureNameDoc Document(this ActionContext ctx, GetTextureName Action) =>
        new(ctx, Action);
}
