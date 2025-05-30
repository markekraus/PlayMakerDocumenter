using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayDeleteAt(this StringBuilder sb, ArrayDeleteAt action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayDeleteAt)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.array), action.array, ctx)
            .AddRow(nameof(action.index), action.index, ctx)
            .AddRow(nameof(action.indexOutOfRangeEvent), action.indexOutOfRangeEvent, ctx)
            .BuildTable();
}
