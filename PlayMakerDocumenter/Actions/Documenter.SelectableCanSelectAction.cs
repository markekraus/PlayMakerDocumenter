using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSelectableCanSelectAction(this StringBuilder sb, SelectableCanSelectAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SelectableCanSelectAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.CanInteract), action.CanInteract, ctx)
            .AddRow(nameof(action.Target), action.Target, ctx)
            .BuildTable();
}
