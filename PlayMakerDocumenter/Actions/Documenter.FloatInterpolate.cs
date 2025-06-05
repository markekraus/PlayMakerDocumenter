using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFloatInterpolate(this StringBuilder sb, FloatInterpolate action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FloatInterpolate)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.currentTime), action.currentTime, ctx)
            .AddRow(nameof(action.finishEvent), action.finishEvent, ctx)
            .AddRow(nameof(action.fromFloat), action.fromFloat, ctx)
            .AddRow(nameof(action.mode), action.mode, ctx)
            .AddRow(nameof(action.realTime), action.realTime, ctx)
            .AddRow(nameof(action.startTime), action.startTime, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .AddRow(nameof(action.time), action.time, ctx)
            .AddRow(nameof(action.toFloat), action.toFloat, ctx)
            .BuildTable();
}
