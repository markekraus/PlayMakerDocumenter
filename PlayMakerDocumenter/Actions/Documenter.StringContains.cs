using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionStringContains(this StringBuilder sb, StringContains action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(StringContains)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.containsString), action.containsString, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.falseEvent), action.falseEvent, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .AddRow(nameof(action.stringVariable), action.stringVariable, ctx)
            .AddRow(nameof(action.trueEvent), action.trueEvent, ctx)
            .BuildTable();
}
