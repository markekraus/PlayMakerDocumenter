using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionConvertStringToFloat(this StringBuilder sb, ConvertStringToFloat action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ConvertStringToFloat)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.floatVariable), action.floatVariable, ctx)
            .AddRow(nameof(action.stringVariable), action.stringVariable, ctx)
            .BuildTable();
}
