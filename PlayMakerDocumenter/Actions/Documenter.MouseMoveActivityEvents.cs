using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionMouseMoveActivityEvents(this StringBuilder sb, MouseMoveActivityEvents action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(MouseMoveActivityEvents)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._isInactive), action._isInactive, ctx)
            .AddRow(nameof(action._lastMoveTime), action._lastMoveTime, ctx)
            .AddRow(nameof(action._lastPosition), action._lastPosition, ctx)
            .AddRow(nameof(action.eventTarget), action.eventTarget, ctx)
            .AddRow(nameof(action.inactivityThreshold), action.inactivityThreshold, ctx)
            .AddRow(nameof(action.isInactive), action.isInactive, ctx)
            .AddRow(nameof(action.mouseMoveEvent), action.mouseMoveEvent, ctx)
            .AddRow(nameof(action.mouseStillEvent), action.mouseStillEvent, ctx)
            .BuildTable();
}
