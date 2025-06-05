using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionConvertFloatToInt(this StringBuilder sb, ConvertFloatToInt action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ConvertFloatToInt)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.floatVariable), action.floatVariable, ctx)
            .AddRow(nameof(action.intVariable), action.intVariable, ctx)
            .AddRow(nameof(action.rounding), action.rounding, ctx)
            .BuildTable();
}
