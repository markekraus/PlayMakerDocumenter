using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionUIScreenActiveAction(this StringBuilder sb, UIScreenActiveAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(UIScreenActiveAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.ActiveEvent), action.ActiveEvent, ctx)
            .AddRow(nameof(action.Target), action.Target, ctx)
            .AddRow(nameof(action.UnactiveEvent), action.UnactiveEvent, ctx)
            .BuildTable();
}
