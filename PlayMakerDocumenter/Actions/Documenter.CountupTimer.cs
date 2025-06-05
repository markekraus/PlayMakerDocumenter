using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionCountupTimer(this StringBuilder sb, CountupTimer action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(CountupTimer)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.pause), action.pause, ctx)
            .AddRow(nameof(action.realTime), action.realTime, ctx)
            .AddRow(nameof(action.reset), action.reset, ctx)
            .AddRow(nameof(action.restartOnEnter), action.restartOnEnter, ctx)
            .AddRow(nameof(action.startTime), action.startTime, ctx)
            .AddRow(nameof(action.storeTime), action.storeTime, ctx)
            .AddRow(nameof(action.timer), action.timer, ctx)
            .BuildTable();
}
