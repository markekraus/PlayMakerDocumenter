using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListIndexOf(this StringBuilder sb, ArrayListIndexOf action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListIndexOf)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.count), action.count, ctx)
            .AddRow(nameof(action.failureEvent), action.failureEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.indexOf), action.indexOf, ctx)
            .AddRow(nameof(action.itemFound), action.itemFound, ctx)
            .AddRow(nameof(action.itemNotFound), action.itemNotFound, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.startIndex), action.startIndex, ctx)
            .AddRow(nameof(action.variable), action.variable, ctx)
            .BuildTable();
}
