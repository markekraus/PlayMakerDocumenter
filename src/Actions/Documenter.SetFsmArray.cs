using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetFsmArray(this StringBuilder sb, SetFsmArray action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmArray)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.copyValues), action.copyValues)
            .AddRow(nameof(action.fsm), action.fsm)
            .AddRow(nameof(action.fsmName), action.fsmName)
            .AddRow(nameof(action.setValue), action.setValue)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.variableName), action.variableName)
            .BuildTable();
}
