using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmVector3(this StringBuilder sb, GetFsmVector3 action, ActionContext ctx = null) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmVector3)} Details:")
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
