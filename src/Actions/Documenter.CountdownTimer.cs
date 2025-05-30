using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionCountdownTimer(this StringBuilder sb, CountdownTimer action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(CountdownTimer)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.finishEvent), action.finishEvent, ctx)
            .AddRow(nameof(action.realTime), action.realTime, ctx)
            .AddRow(nameof(action.startTime), action.startTime, ctx)
            .AddRow(nameof(action.stopOn), action.stopOn, ctx)
            .AddRow(nameof(action.storeValue), action.storeValue, ctx)
            .AddRow(nameof(action.theTime), action.theTime, ctx)
            .AddRow(nameof(action.time), action.time, ctx)
            .AddRow(nameof(action.timer), action.timer, ctx)
            .BuildTable();
}
