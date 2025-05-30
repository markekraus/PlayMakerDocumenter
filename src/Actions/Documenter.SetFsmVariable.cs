using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetFsmVariable(this StringBuilder sb, SetFsmVariable action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmVariable)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.fsmName), action.fsmName, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.setValue), action.setValue, ctx)
            .AddRow(nameof(action.variableName), action.variableName, ctx)
            .BuildTable();
}
