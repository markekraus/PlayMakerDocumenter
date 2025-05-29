using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetFsmArray(this StringBuilder sb, SetFsmArray action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmArray)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("copyValues", $"{action.copyValues}")
            .AddRowIfNotNull(action.fsm, fsm =>
                new string[] { nameof(fsm), fsm.GetFullPath() })
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
}
