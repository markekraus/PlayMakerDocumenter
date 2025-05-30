using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListSwapItems(this StringBuilder sb, ArrayListSwapItems action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListSwapItems)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.failureEvent), action.failureEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.index1), action.index1, ctx)
            .AddRow(nameof(action.index2), action.index2, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .BuildTable();
}
