using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmArray(this StringBuilder sb, GetFsmArray action) =>
    action is null
    ? sb
    : sb.AppendHeader($"{nameof(GetFsmArray)} Details:")
        .NewTable()
        .WithPropertyValueHeaders()
        .AddRow("copyValues", $"{action.copyValues}")
        .AddRowIfNotNull(action.fsmName, fsmName =>
            new string[] { nameof(fsmName), fsmName.FormatValue() })
        .AddGameObjectRows(action, action.gameObject)
        .AddRowIfNotNull(action.storeValue, storeValue =>
            new string[] { nameof(storeValue), storeValue.FormatValue() })
        .AddRowIfNotNull(action.variableName, variableName =>
            new string[] { nameof(variableName), variableName.FormatValue() })
        .BuildTable();
}
