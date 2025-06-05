using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionDebugLog(this StringBuilder sb, DebugLog action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(DebugLog)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.logLevel), action.logLevel, ctx)
            .AddRow(nameof(action.text), action.text, ctx)
            .BuildTable();
}
