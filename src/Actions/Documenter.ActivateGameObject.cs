using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionActivateGameObject(this StringBuilder sb, ActivateGameObject action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ActivateGameObject)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.activate), action.activate, ctx)
            .AddRow(nameof(action.activatedGameObject), action.activatedGameObject, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.recursive), action.recursive, ctx)
            .AddRow(nameof(action.resetOnExit), action.resetOnExit, ctx)
            .BuildTable();
}
