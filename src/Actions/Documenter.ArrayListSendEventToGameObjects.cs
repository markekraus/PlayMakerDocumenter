using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListSendEventToGameObjects(this StringBuilder sb, ArrayListSendEventToGameObjects action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListSendEventToGameObjects)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.excludeSelf), action.excludeSelf, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .AddRow(nameof(action.sendToChildren), action.sendToChildren, ctx)
            .BuildTable();
}
