using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    

    private static StringBuilder DocActionIntCompare(this StringBuilder sb, IntCompare action, Dictionary<string, string> eventToState) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IntCompare)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.integer1), action.integer1)
            .AddRow(nameof(action.integer2), action.integer2)
            .AddRow(nameof(action.equal), action.equal, eventToState)
            .AddRow(nameof(action.everyFrame), action.everyFrame)
            .AddRow(nameof(action.greaterThan), action.greaterThan, eventToState)
            .AddRow(nameof(action.lessThan), action.lessThan, eventToState)
            .BuildTable();
}
