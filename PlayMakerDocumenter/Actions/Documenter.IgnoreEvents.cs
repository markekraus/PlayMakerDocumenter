using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionIgnoreEvents(this StringBuilder sb, IgnoreEvents action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IgnoreEvents)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.events), action.events, ctx)
            .AddRow(nameof(action.eventTypes), action.eventTypes, ctx)
            .AddRow(nameof(action.logIgnoredEvents), action.logIgnoredEvents, ctx)
            .BuildTable();
}
