using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionVideoPlayerPlay(this StringBuilder sb, VideoPlayerPlay action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(VideoPlayerPlay)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._vp), action._vp, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.go), action.go, ctx)
            .BuildTable();
}
