using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayGet(this StringBuilder sb, ArrayGet action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayGet)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.array), action.array, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.index), action.index, ctx)
            .AddRow(nameof(action.indexOutOfRange), action.indexOutOfRange, ctx)
            .AddRow(nameof(action.storeValue), action.storeValue, ctx)
            .BuildTable();
}
