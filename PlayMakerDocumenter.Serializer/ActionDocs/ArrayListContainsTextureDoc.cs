using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListContainsTextureDoc : FsmActionDoc
{
    internal ArrayListContainsTextureDoc(ActionContext Ctx, ArrayListContainsTexture action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.indexResult), action.indexResult);
        this.AddProperty(nameof(action.isContained), action.isContained);
        this.AddProperty(nameof(action.isContainedEvent), action.isContainedEvent);
        this.AddProperty(nameof(action.isNotContainedEvent), action.isNotContainedEvent);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.TextureSearch), action.TextureSearch);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListContainsTextureDoc Document(this ActionContext ctx, ArrayListContainsTexture Action) =>
        new(ctx, Action);
}
