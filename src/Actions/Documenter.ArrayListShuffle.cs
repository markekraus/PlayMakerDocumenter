using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListShuffle(this StringBuilder sb, ArrayListShuffle action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListShuffle)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.reference), action.reference)
            .AddRow(nameof(action.shufflingRange), action.shufflingRange)
            .AddRow(nameof(action.startIndex), action.startIndex)
            .BuildTable();
}
