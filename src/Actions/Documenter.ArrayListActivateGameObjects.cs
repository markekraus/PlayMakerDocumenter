using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListActivateGameObjects(this StringBuilder sb, ArrayListActivateGameObjects action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListActivateGameObjects)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._activeStates), action._activeStates, ctx)
            .AddRow(nameof(action.activate), action.activate, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.resetOnExit), action.resetOnExit, ctx)
            .BuildTable();
}
