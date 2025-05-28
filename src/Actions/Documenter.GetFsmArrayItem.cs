using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

public static partial class Documenter
{
    private static StringBuilder DocActionGetFsmArrayItem(this StringBuilder sb, GetFsmArrayItem action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmArrayItem)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.index, index =>
                new string[] { nameof(index), $"{index.Value}" })
            .AddRowIfNotNull(action.storeValue, storeValue =>
                new string[] { "storeValue.Type", $"{storeValue.Type}" })
            .AddRowIfNotNull(action.storeValue, storeValue =>
                new string[] { "storeValue.Value", storeValue.GetValue(action.fsmComponent) })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
}
