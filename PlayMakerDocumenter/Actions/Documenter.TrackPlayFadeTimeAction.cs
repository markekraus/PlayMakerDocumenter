using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionTrackPlayFadeTimeAction(this StringBuilder sb, TrackPlayFadeTimeAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(TrackPlayFadeTimeAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.FadeUpTime), action.FadeUpTime, ctx)
            .AddRow(nameof(action.GroupID), action.GroupID, ctx)
            .BuildTable();
}
