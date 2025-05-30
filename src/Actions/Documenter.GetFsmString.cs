using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmString(this StringBuilder sb, GetFsmString action, ActionContext ctx = null) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmString)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame)
            .AddRow(nameof(action.fsm), action.fsm)
            .AddRow(nameof(action.fsmName), action.fsmName)
            .AddRow(nameof(action.fsmNameLastFrame), action.fsmNameLastFrame)
            .AddRow(nameof(action.gameObject), action.gameObject, action)
            .AddRow(nameof(action.goLastFrame), action.goLastFrame)
            .AddRow(nameof(action.storeValue), action.storeValue)
            .AddRow(nameof(action.variableName), action.variableName)
            .BuildTable();
}
