using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

public static partial class Documenter
{
    private static StringBuilder DocActionGetFsmVariable(this StringBuilder sb, GetFsmVariable action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmVariable)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.sourceFsm, sourceFsm =>
                new string[] { nameof(sourceFsm), sourceFsm.GetFullPath() })
            .BuildTable();
}
