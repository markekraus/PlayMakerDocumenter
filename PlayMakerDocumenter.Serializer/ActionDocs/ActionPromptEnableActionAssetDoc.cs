using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ActionPromptEnableActionAssetDoc : FsmActionDoc
{
    internal ActionPromptEnableActionAssetDoc(ActionContext Ctx, ActionPromptEnableActionAsset action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.IsEnabled), action.IsEnabled);
        this.AddProperty(nameof(action.TargetAsset), action.TargetAsset);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ActionPromptEnableActionAssetDoc Document(this ActionContext ctx, ActionPromptEnableActionAsset Action) =>
        new(ctx, Action);
}
