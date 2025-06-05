using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionLoadSceneAsynch(this StringBuilder sb, LoadSceneAsynch action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(LoadSceneAsynch)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._asynchOperationUid), action._asynchOperationUid, ctx)
            .AddRow(nameof(action._asyncOperation), action._asyncOperation, ctx)
            .AddRow(nameof(action.allowSceneActivation), action.allowSceneActivation, ctx)
            .AddRow(nameof(action.aSyncOperationHashCode), action.aSyncOperationHashCode, ctx)
            .AddRow(nameof(action.doneEvent), action.doneEvent, ctx)
            .AddRow(nameof(action.isDone), action.isDone, ctx)
            .AddRow(nameof(action.loadSceneMode), action.loadSceneMode, ctx)
            .AddRow(nameof(action.operationPriority), action.operationPriority, ctx)
            .AddRow(nameof(action.pendingActivation), action.pendingActivation, ctx)
            .AddRow(nameof(action.pendingActivationCallBackDone), action.pendingActivationCallBackDone, ctx)
            .AddRow(nameof(action.pendingActivationEvent), action.pendingActivationEvent, ctx)
            .AddRow(nameof(action.progress), action.progress, ctx)
            .AddRow(nameof(action.sceneAtIndex), action.sceneAtIndex, ctx)
            .AddRow(nameof(action.sceneByName), action.sceneByName, ctx)
            .AddRow(nameof(action.sceneNotFoundEvent), action.sceneNotFoundEvent, ctx)
            .AddRow(nameof(action.sceneReference), action.sceneReference, ctx)
            .BuildTable();
}
