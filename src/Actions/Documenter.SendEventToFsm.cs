using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSendEventToFsm(this StringBuilder sb, SendEventToFsm action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SendEventToFsm)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.delay), action.delay, ctx)
            .AddRow(nameof(action.delayedEvent), action.delayedEvent, ctx)
            .AddRow(nameof(action.fsmName), action.fsmName, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.go), action.go, ctx)
            .AddRow(nameof(action.requireReceiver), action.requireReceiver, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .BuildTable();
}
