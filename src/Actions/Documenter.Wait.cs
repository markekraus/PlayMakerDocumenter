using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionWait(this StringBuilder sb, Wait action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(Wait)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.time), action.time)
            .AddRow(nameof(action.finishEvent), action.finishEvent, ctx)
            .AddRow(nameof(action.realTime), action.realTime)
            .AddRow(nameof(action.startTime), action.startTime)
            .AddRow(nameof(action.timer), action.timer)
            .BuildTable();
}
