using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionTrackPlayParallelAction(this StringBuilder sb, TrackPlayParallelAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(TrackPlayParallelAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.GroupID), action.GroupID, ctx)
            .AddRow(nameof(action.OnlyPlaying), action.OnlyPlaying, ctx)
            .AddRow(nameof(action.StopAllOthers), action.StopAllOthers, ctx)
            .AddRow(nameof(action.TrackID), action.TrackID, ctx)
            .BuildTable();
}
