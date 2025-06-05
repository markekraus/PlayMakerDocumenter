using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionNextFrameEvent(this StringBuilder sb, NextFrameEvent action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(NextFrameEvent)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .BuildTable();
}
