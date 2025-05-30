using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionEaseColor(this StringBuilder sb, EaseColor action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(EaseColor)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.colorVariable), action.colorVariable, ctx)
            .AddRow(nameof(action.finishInNextStep), action.finishInNextStep, ctx)
            .AddRow(nameof(action.fromValue), action.fromValue, ctx)
            .AddRow(nameof(action.toValue), action.toValue, ctx)
            .BuildTable();
}
