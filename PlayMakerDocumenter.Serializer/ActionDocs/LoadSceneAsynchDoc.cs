using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record LoadSceneAsynchDoc : FsmActionDoc
{
    internal LoadSceneAsynchDoc(ActionContext Ctx, LoadSceneAsynch action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._asynchOperationUid), action._asynchOperationUid);
        this.AddProperty(nameof(action._asyncOperation), action._asyncOperation);
        this.AddProperty(nameof(action.allowSceneActivation), action.allowSceneActivation);
        this.AddProperty(nameof(action.aSyncOperationHashCode), action.aSyncOperationHashCode);
        this.AddProperty(nameof(action.doneEvent), action.doneEvent);
        this.AddProperty(nameof(action.isDone), action.isDone);
        this.AddProperty(nameof(action.loadSceneMode), action.loadSceneMode);
        this.AddProperty(nameof(action.operationPriority), action.operationPriority);
        this.AddProperty(nameof(action.pendingActivation), action.pendingActivation);
        this.AddProperty(nameof(action.pendingActivationCallBackDone), action.pendingActivationCallBackDone);
        this.AddProperty(nameof(action.pendingActivationEvent), action.pendingActivationEvent);
        this.AddProperty(nameof(action.progress), action.progress);
        this.AddProperty(nameof(action.sceneAtIndex), action.sceneAtIndex);
        this.AddProperty(nameof(action.sceneByName), action.sceneByName);
        this.AddProperty(nameof(action.sceneNotFoundEvent), action.sceneNotFoundEvent);
        this.AddProperty(nameof(action.sceneReference), action.sceneReference);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static LoadSceneAsynchDoc Document(this ActionContext ctx, LoadSceneAsynch Action) =>
        new(ctx, Action);
}
