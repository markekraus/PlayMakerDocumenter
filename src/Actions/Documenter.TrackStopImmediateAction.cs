using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionTrackStopImmediateAction(this StringBuilder sb, TrackStopImmediateAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(TrackStopImmediateAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.GroupID), action.GroupID, ctx)
            .AddRow(nameof(action.PriorityCheckEnabled), action.PriorityCheckEnabled, ctx)
            .AddRow(nameof(action.PriorityCheckValue), action.PriorityCheckValue, ctx)
            .BuildTable();
}
