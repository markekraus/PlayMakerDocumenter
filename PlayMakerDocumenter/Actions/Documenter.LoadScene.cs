using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionLoadScene(this StringBuilder sb, LoadScene action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(LoadScene)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.failureEvent), action.failureEvent, ctx)
            .AddRow(nameof(action.loadSceneMode), action.loadSceneMode, ctx)
            .AddRow(nameof(action.sceneAtIndex), action.sceneAtIndex, ctx)
            .AddRow(nameof(action.sceneByName), action.sceneByName, ctx)
            .AddRow(nameof(action.sceneReference), action.sceneReference, ctx)
            .AddRow(nameof(action.success), action.success, ctx)
            .AddRow(nameof(action.successEvent), action.successEvent, ctx)
            .BuildTable();
}
