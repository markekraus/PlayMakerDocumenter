using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionTrackSetLevelAction(this StringBuilder sb, TrackSetLevelAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(TrackSetLevelAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.GroupID), action.GroupID, ctx)
            .AddRow(nameof(action.Level), action.Level, ctx)
            .BuildTable();
}
