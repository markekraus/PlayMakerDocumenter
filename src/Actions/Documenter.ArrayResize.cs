using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayResize(this StringBuilder sb, ArrayResize action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayResize)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.array), action.array, ctx)
            .AddRow(nameof(action.newSize), action.newSize, ctx)
            .AddRow(nameof(action.sizeOutOfRangeEvent), action.sizeOutOfRangeEvent, ctx)
            .BuildTable();
}
