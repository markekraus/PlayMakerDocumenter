using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetFsmObject(this StringBuilder sb, SetFsmObject action, ActionContext ctx = null) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmObject)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame)
            .AddRow(nameof(action.fsm), action.fsm)
            .AddRow(nameof(action.fsmName), action.fsmName)
            .AddRow(nameof(action.fsmNameLastFrame), action.fsmNameLastFrame)
            .AddRow(nameof(action.gameObject), action.gameObject, action)
            .AddRow(nameof(action.goLastFrame), action.goLastFrame)
            .AddRow(nameof(action.setValue), action.setValue)
            .AddRow(nameof(action.variableName), action.variableName)
            .BuildTable();
}
