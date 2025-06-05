using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFloatClamp(this StringBuilder sb, FloatClamp action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FloatClamp)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.floatVariable), action.floatVariable, ctx)
            .AddRow(nameof(action.maxValue), action.maxValue, ctx)
            .AddRow(nameof(action.minValue), action.minValue, ctx)
            .BuildTable();
}
