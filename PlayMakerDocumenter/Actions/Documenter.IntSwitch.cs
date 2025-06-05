using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionIntSwitch(this StringBuilder sb, IntSwitch action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IntSwitch)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.compareTo), action.compareTo, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.intVariable), action.intVariable, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .BuildTable();
}
