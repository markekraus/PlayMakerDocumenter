using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListAddRange(this StringBuilder sb, ArrayListAddRange action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListAddRange)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.convertIntsToBytes), action.convertIntsToBytes, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.variables), action.variables, ctx)
            .BuildTable();
}
