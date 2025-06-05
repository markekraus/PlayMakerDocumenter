using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetStringLeft(this StringBuilder sb, GetStringLeft action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetStringLeft)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.charCount), action.charCount, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .AddRow(nameof(action.stringVariable), action.stringVariable, ctx)
            .BuildTable();
}
