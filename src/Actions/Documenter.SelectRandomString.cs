using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSelectRandomString(this StringBuilder sb, SelectRandomString action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SelectRandomString)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.storeString), action.storeString, ctx)
            .AddRow(nameof(action.strings), action.strings, ctx)
            .AddRow(nameof(action.weights), action.weights, ctx)
            .BuildTable();
}
