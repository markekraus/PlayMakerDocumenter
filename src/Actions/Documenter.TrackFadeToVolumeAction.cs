using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionTrackFadeToVolumeAction(this StringBuilder sb, TrackFadeToVolumeAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(TrackFadeToVolumeAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.fadeTime), action.fadeTime, ctx)
            .AddRow(nameof(action.playingOnly), action.playingOnly, ctx)
            .AddRow(nameof(action.priorityCheck), action.priorityCheck, ctx)
            .AddRow(nameof(action.priorityValue), action.priorityValue, ctx)
            .AddRow(nameof(action.targetGroup), action.targetGroup, ctx)
            .AddRow(nameof(action.targetVolume), action.targetVolume, ctx)
            .BuildTable();
}
