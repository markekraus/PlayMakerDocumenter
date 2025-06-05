using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionBroadcastEvent(this StringBuilder sb, BroadcastEvent action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(BroadcastEvent)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.broadcastEvent), action.broadcastEvent, ctx)
            .AddRow(nameof(action.excludeSelf), action.excludeSelf, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.sendToChildren), action.sendToChildren, ctx)
            .BuildTable();
}
