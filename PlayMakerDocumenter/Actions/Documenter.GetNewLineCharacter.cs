using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetNewLineCharacter(this StringBuilder sb, GetNewLineCharacter action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetNewLineCharacter)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.newLine), action.newLine, ctx)
            .BuildTable();
}
