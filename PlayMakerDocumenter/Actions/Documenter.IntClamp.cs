using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionIntClamp(this StringBuilder sb, IntClamp action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IntClamp)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.intVariable), action.intVariable, ctx)
            .AddRow(nameof(action.maxValue), action.maxValue, ctx)
            .AddRow(nameof(action.minValue), action.minValue, ctx)
            .BuildTable();
}
