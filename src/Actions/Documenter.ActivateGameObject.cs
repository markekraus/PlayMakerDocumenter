using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker;
using Il2CppHutongGames.PlayMaker.Actions;
using UniverseLib;

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
            .AddRow(nameof(action.activate), action.activate)
            .AddRow(nameof(action.activatedGameObject), action.activatedGameObject)
            .AddRow(nameof(action.everyFrame), action.everyFrame)
            .AddRow(nameof(action.recursive), action.recursive)
            .AddRow(nameof(action.resetOnExit), action.resetOnExit)
            .BuildTable();
}
