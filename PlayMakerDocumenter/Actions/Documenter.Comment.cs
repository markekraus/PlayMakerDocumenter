using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionComment(this StringBuilder sb, Comment action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(Comment)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.comment), action.comment, ctx)
            .BuildTable();
}
