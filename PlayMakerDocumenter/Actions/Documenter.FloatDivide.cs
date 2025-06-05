using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFloatDivide(this StringBuilder sb, FloatDivide action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FloatDivide)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.divideBy), action.divideBy, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.floatVariable), action.floatVariable, ctx)
            .BuildTable();
}
