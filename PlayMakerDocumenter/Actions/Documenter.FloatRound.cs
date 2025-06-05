using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFloatRound(this StringBuilder sb, FloatRound action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FloatRound)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.floatVariable), action.floatVariable, ctx)
            .AddRow(nameof(action.resultAsFloat), action.resultAsFloat, ctx)
            .AddRow(nameof(action.resultAsInt), action.resultAsInt, ctx)
            .BuildTable();
}
