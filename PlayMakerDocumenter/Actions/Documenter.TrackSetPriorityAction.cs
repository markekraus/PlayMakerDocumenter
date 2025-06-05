using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionTrackSetPriorityAction(this StringBuilder sb, TrackSetPriorityAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(TrackSetPriorityAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.GroupID), action.GroupID, ctx)
            .AddRow(nameof(action.Priority), action.Priority, ctx)
            .BuildTable();
}
