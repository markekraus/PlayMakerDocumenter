using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionCameraFadeIn(this StringBuilder sb, CameraFadeIn action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(CameraFadeIn)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.color), action.color, ctx)
            .AddRow(nameof(action.colorLerp), action.colorLerp, ctx)
            .AddRow(nameof(action.currentTime), action.currentTime, ctx)
            .AddRow(nameof(action.finishEvent), action.finishEvent, ctx)
            .AddRow(nameof(action.realTime), action.realTime, ctx)
            .AddRow(nameof(action.startTime), action.startTime, ctx)
            .AddRow(nameof(action.time), action.time, ctx)
            .BuildTable();
}
