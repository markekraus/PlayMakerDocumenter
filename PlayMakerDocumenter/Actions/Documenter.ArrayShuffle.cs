using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayShuffle(this StringBuilder sb, ArrayShuffle action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayShuffle)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.array), action.array, ctx)
            .AddRow(nameof(action.shufflingRange), action.shufflingRange, ctx)
            .AddRow(nameof(action.startIndex), action.startIndex, ctx)
            .BuildTable();
}
