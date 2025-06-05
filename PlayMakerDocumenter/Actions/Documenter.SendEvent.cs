using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSendEvent(this StringBuilder sb, SendEvent action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SendEvent)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.delay), action.delay, ctx)
            .AddRow(nameof(action.delayedEvent), action.delayedEvent, ctx)
            .AddRow(nameof(action.eventTarget), action.eventTarget, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .BuildTable();
}
