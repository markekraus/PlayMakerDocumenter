using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListShuffle(this StringBuilder sb, ArrayListShuffle action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListShuffle)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddGameObjectRows(action, action.gameObject)
            .AddRow(nameof(action.reference), action.reference)
            .AddRow(nameof(action.shufflingRange), action.shufflingRange)
            .AddRow(nameof(action.startIndex), action.startIndex)
            .BuildTable();
}
