using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TextureCompareDoc : FsmActionDoc
{
    internal TextureCompareDoc(ActionContext Ctx, TextureCompare action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.compareTo), action.compareTo);
        this.AddProperty(nameof(action.equalEvent), action.equalEvent);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.notEqualEvent), action.notEqualEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.textureVariable), action.textureVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TextureCompareDoc Document(this ActionContext ctx, TextureCompare Action) =>
        new(ctx, Action);
}
