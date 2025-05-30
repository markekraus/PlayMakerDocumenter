using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSendEventByTag(this StringBuilder sb, SendEventByTag action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SendEventByTag)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.fsmName), action.fsmName, ctx)
            .AddRow(nameof(action.gos), action.gos, ctx)
            .AddRow(nameof(action.layer), action.layer, ctx)
            .AddRow(nameof(action.layerFilterOn), action.layerFilterOn, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .AddRow(nameof(action.sendEventName), action.sendEventName, ctx)
            .AddRow(nameof(action.tag), action.tag, ctx)
            .BuildTable();
}
