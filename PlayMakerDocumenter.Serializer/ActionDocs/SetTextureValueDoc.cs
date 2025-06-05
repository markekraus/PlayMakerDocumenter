using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetTextureValueDoc : FsmActionDoc
{
    internal SetTextureValueDoc(ActionContext Ctx, SetTextureValue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.textureValue), action.textureValue);
        this.AddProperty(nameof(action.textureVariable), action.textureVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetTextureValueDoc Document(this ActionContext ctx, SetTextureValue Action) =>
        new(ctx, Action);
}
