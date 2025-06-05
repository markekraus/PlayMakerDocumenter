using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListInsert(this StringBuilder sb, ArrayListInsert action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListInsert)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.convertIntToByte), action.convertIntToByte, ctx)
            .AddRow(nameof(action.failureEvent), action.failureEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.index), action.index, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.variable), action.variable, ctx)
            .BuildTable();
}
