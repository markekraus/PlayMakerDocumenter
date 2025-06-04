using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record LoadLevelDoc : FsmActionDoc
{
    internal LoadLevelDoc(ActionContext Ctx, LoadLevel action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.additive), action.additive);
        this.AddProperty(nameof(action.async), action.async);
        this.AddProperty(nameof(action.asyncOperation), action.asyncOperation);
        this.AddProperty(nameof(action.dontDestroyOnLoad), action.dontDestroyOnLoad);
        this.AddProperty(nameof(action.failedEvent), action.failedEvent);
        this.AddProperty(nameof(action.levelName), action.levelName);
        this.AddProperty(nameof(action.loadedEvent), action.loadedEvent);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static LoadLevelDoc Document(this ActionContext ctx, LoadLevel Action) =>
        new(ctx, Action);
}
