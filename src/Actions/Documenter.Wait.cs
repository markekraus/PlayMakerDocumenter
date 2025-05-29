using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionWait(this StringBuilder sb, Wait action, Dictionary<string, string> eventToState) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(Wait)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.time), action.time)
            .AddRow(nameof(action.finishEvent), action.finishEvent, eventToState)
            .AddRow(nameof(action.realTime), action.realTime)
            .AddRow(nameof(action.startTime), action.startTime)
            .AddRow(nameof(action.timer), action.timer)
            .BuildTable();
}
