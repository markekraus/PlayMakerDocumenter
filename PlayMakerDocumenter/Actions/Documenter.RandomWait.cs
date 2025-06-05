using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionRandomWait(this StringBuilder sb, RandomWait action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(RandomWait)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.finishEvent), action.finishEvent, ctx)
            .AddRow(nameof(action.max), action.max, ctx)
            .AddRow(nameof(action.min), action.min, ctx)
            .AddRow(nameof(action.realTime), action.realTime, ctx)
            .AddRow(nameof(action.startTime), action.startTime, ctx)
            .AddRow(nameof(action.time), action.time, ctx)
            .AddRow(nameof(action.timer), action.timer, ctx)
            .BuildTable();
}
