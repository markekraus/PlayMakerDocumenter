using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

public static partial class Documenter
{
    private static StringBuilder DocActionArrayListGet(this StringBuilder sb, ArrayListGet action, Dictionary<string, string> eventToState) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListGet)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRowIfNotNull(action.atIndex, atIndex =>
                new string[] { "atIndex", $"{atIndex.Value}" })
            .AddRowIfNotNull(action.failureEvent, failureEvent =>
                new string[] { "failureEvent", $"{failureEvent.Name}" })
            .AddRowIfNotNull(action.failureEvent, failureEvent =>
                new string[] { "failureEvent state", $"{eventToState.GetValueOrDefault(failureEvent.Name)}" })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.reference, reference =>
                new string[] { "reference", $"{reference.Value}" })
            .AddRowIfNotNull(action.result, result =>
                new string[] { "result.variableName", $"{result.variableName}" })
            .AddRowIfNotNull(action.result, result =>
                new string[] { "result.Type", $"{result.Type}" })
            .AddRowIfNotNull(action.result, result =>
                new string[] { "result.Value", result.GetValue(action.fsmComponent) })
            .BuildTable();
}
