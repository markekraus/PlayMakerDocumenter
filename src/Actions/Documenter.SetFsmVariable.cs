using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

public static partial class Documenter
{
    private static StringBuilder DocActionSetFsmVariable(this StringBuilder sb, SetFsmVariable action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmVariable)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
}
