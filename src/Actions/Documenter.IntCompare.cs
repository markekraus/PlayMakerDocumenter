using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

public static partial class Documenter
{
    

    private static StringBuilder DocActionIntCompare(this StringBuilder sb, IntCompare action, Dictionary<string, string> eventToState) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IntCompare)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRowIfNotNull(action.integer1, integer1 =>
                new string[] { nameof(integer1), integer1.FormatValue() })
            .AddRowIfNotNull(action.integer2, integer2 =>
                new string[] { nameof(integer2), integer2.FormatValue() })
            .AddRowIfNotNull(action.equal, equal =>
                new string[] { nameof(equal), equal.Name })
            .AddRowIfNotNull(action.equal, equal =>
                new string[] { "equalState", eventToState.GetValueOrDefault(equal.Name)})
            .AddRowIfNotNull(action.greaterThan, greaterThan =>
                new string[] { nameof(greaterThan), greaterThan.Name })
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.greaterThan, greaterThan =>
                new string[] { "greaterThanState", eventToState.GetValueOrDefault(greaterThan.Name)})
            .AddRowIfNotNull(action.lessThan, lessThan =>
                new string[] { nameof(lessThan), lessThan.Name })
            .AddRowIfNotNull(action.lessThan, lessThan =>
                new string[] { "lessThanState", eventToState.GetValueOrDefault(lessThan.Name)})
            .BuildTable();
}
