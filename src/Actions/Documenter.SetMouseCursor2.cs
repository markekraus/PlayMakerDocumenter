using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetMouseCursor2(this StringBuilder sb, SetMouseCursor2 action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetMouseCursor2)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.cursorTexture), action.cursorTexture, ctx)
            .AddRow(nameof(action.hideCursor), action.hideCursor, ctx)
            .AddRow(nameof(action.lockCursor), action.lockCursor, ctx)
            .BuildTable();
}
