using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmArray(this StringBuilder sb, GetFsmArray action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmArray)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.copyValues), action.copyValues, ctx)
            .AddRow(nameof(action.fsmName), action.fsmName, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.storeValue), action.storeValue, ctx)
            .AddRow(nameof(action.variableName), action.variableName, ctx)
            .BuildTable();
}
