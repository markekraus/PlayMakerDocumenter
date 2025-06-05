using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSelectRandomInt(this StringBuilder sb, SelectRandomInt action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SelectRandomInt)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.ints), action.ints, ctx)
            .AddRow(nameof(action.storeInt), action.storeInt, ctx)
            .AddRow(nameof(action.weights), action.weights, ctx)
            .BuildTable();
}
