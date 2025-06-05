using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionStringReplace(this StringBuilder sb, StringReplace action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(StringReplace)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.replace), action.replace, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .AddRow(nameof(action.stringVariable), action.stringVariable, ctx)
            .AddRow(nameof(action.with), action.with, ctx)
            .BuildTable();
}
