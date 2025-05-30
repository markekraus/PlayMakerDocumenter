using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionConvertStringToInt(this StringBuilder sb, ConvertStringToInt action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ConvertStringToInt)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.intVariable), action.intVariable, ctx)
            .AddRow(nameof(action.stringVariable), action.stringVariable, ctx)
            .BuildTable();
}
