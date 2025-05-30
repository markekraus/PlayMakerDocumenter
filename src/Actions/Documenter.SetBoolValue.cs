using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetBoolValue(this StringBuilder sb, SetBoolValue action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetBoolValue)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.boolValue), action.boolValue, ctx)
            .AddRow(nameof(action.boolVariable), action.boolVariable, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .BuildTable();
}
