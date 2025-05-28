using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

public static partial class Documenter
{
    private static StringBuilder DocActionWait(this StringBuilder sb, Wait action, Dictionary<string, string> eventToState) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(Wait)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRowIfNotNull(action.time, time =>
                new string[] { nameof(time), time.FormatValue() })
            .AddRowIfNotNull(action.finishEvent, finishEvent =>
                new string[] { nameof(finishEvent), finishEvent.Name })
            .AddRow("realTime", $"{action.realTime}")
            .AddRow("startTime", $"{action.startTime}")
            .AddRow("timer", $"{action.timer}")
            .AddRowIfNotNull(action.finishEvent, finishEvent =>
                new string[] { "targetState", eventToState.GetValueOrDefault(finishEvent.Name) })
            .BuildTable();
}
