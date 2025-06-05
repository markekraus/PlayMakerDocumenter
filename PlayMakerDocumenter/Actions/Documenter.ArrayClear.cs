using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayClear(this StringBuilder sb, ArrayClear action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayClear)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.array), action.array, ctx)
            .AddRow(nameof(action.resetValue), action.resetValue, ctx)
            .BuildTable();
}
