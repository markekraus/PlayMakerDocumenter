using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionConvertIntToDate(this StringBuilder sb, ConvertIntToDate action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ConvertIntToDate)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.dateInt), action.dateInt, ctx)
            .AddRow(nameof(action.dateString), action.dateString, ctx)
            .AddRow(nameof(action.dayOfMonth), action.dayOfMonth, ctx)
            .AddRow(nameof(action.dayOfWeek), action.dayOfWeek, ctx)
            .AddRow(nameof(action.month), action.month, ctx)
            .AddRow(nameof(action.year), action.year, ctx)
            .BuildTable();
}
