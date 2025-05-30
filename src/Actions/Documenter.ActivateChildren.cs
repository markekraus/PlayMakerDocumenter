using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionActivateChildren(this StringBuilder sb, ActivateChildren action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ActivateChildren)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.activate), action.activate, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.parent), action.parent, ctx)
            .AddRow(nameof(action.recursiveDepth), action.recursiveDepth, ctx)
            .AddRow(nameof(action.resetOnExit), action.resetOnExit, ctx)
            .BuildTable();
}
