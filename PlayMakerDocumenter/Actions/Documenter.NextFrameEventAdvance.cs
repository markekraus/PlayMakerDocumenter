using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionNextFrameEventAdvance(this StringBuilder sb, NextFrameEventAdvance action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(NextFrameEventAdvance)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.frameCount), action.frameCount, ctx)
            .AddRow(nameof(action.loop), action.loop, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .BuildTable();
}
