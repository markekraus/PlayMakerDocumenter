using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionBuildString(this StringBuilder sb, BuildString action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(BuildString)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.addToEnd), action.addToEnd, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.result), action.result, ctx)
            .AddRow(nameof(action.separator), action.separator, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .AddRow(nameof(action.stringParts), action.stringParts, ctx)
            .BuildTable();
}
