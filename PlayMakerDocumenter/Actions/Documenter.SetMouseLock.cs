using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetMouseLock(this StringBuilder sb, SetMouseLock action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetMouseLock)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.lockCursor), action.lockCursor, ctx)
            .BuildTable();
}
