using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListGet(this StringBuilder sb, ArrayListGet action, Dictionary<string, string> eventToState) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListGet)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.atIndex), action.atIndex)
            .AddRow(nameof(action.failureEvent), action.failureEvent, eventToState)
            .AddRow(nameof(action.gameObject), action.gameObject, action)
            .AddRow(nameof(action.gameObject), action.gameObject, action)
            .AddRow(nameof(action.reference), action.reference)
            .AddRow(nameof(action.result), action.result, action)
            .BuildTable();
}
