using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListSet(this StringBuilder sb, ArrayListSet action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListSet)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRowIfNotNull(action.atIndex, atIndex =>
                new string[] { "atIndex", $"{atIndex.Value}" })
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRow("forceResizeIdNeeded", $"{action.forceResizeIdNeeded}")
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.reference, reference =>
                new string[] { "reference", $"{reference.Value}" })
            .AddRowIfNotNull(action.variable, variable =>
                new string[] { "variable", variable.GetValue(action.fsmComponent) })
            .BuildTable();
}
