using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionUIScreenCanOpenAction(this StringBuilder sb, UIScreenCanOpenAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(UIScreenCanOpenAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.CannotOpenEvent), action.CannotOpenEvent, ctx)
            .AddRow(nameof(action.CanOpenEvent), action.CanOpenEvent, ctx)
            .AddRow(nameof(action.Target), action.Target, ctx)
            .BuildTable();
}
