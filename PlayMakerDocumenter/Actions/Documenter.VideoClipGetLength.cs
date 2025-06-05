using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionVideoClipGetLength(this StringBuilder sb, VideoClipGetLength action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(VideoClipGetLength)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._vc), action._vc, ctx)
            .AddRow(nameof(action._vp), action._vp, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.go), action.go, ctx)
            .AddRow(nameof(action.length), action.length, ctx)
            .AddRow(nameof(action.orVideoClip), action.orVideoClip, ctx)
            .BuildTable();
}
