using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionEaseFloat(this StringBuilder sb, EaseFloat action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(EaseFloat)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.finishInNextStep), action.finishInNextStep, ctx)
            .AddRow(nameof(action.floatVariable), action.floatVariable, ctx)
            .AddRow(nameof(action.fromValue), action.fromValue, ctx)
            .AddRow(nameof(action.toValue), action.toValue, ctx)
            .BuildTable();
}
