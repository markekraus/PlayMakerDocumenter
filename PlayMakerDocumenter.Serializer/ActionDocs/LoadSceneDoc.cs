using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record LoadSceneDoc : FsmActionDoc
{
    internal LoadSceneDoc(ActionContext Ctx, LoadScene action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.failureEvent), action.failureEvent);
        this.AddProperty(nameof(action.loadSceneMode), action.loadSceneMode);
        this.AddProperty(nameof(action.sceneAtIndex), action.sceneAtIndex);
        this.AddProperty(nameof(action.sceneByName), action.sceneByName);
        this.AddProperty(nameof(action.sceneReference), action.sceneReference);
        this.AddProperty(nameof(action.success), action.success);
        this.AddProperty(nameof(action.successEvent), action.successEvent);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static LoadSceneDoc Document(this ActionContext ctx, LoadScene Action) =>
        new(ctx, Action);
}
