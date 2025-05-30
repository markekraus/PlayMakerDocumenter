using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionConvertStringCase(this StringBuilder sb, ConvertStringCase action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ConvertStringCase)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.operation), action.operation, ctx)
            .AddRow(nameof(action.result), action.result, ctx)
            .AddRow(nameof(action.String), action.String, ctx)
            .BuildTable();
}
