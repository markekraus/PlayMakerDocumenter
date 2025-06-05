using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionTriggerEvent(this StringBuilder sb, TriggerEvent action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(TriggerEvent)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.cachedProxy), action.cachedProxy, ctx)
            .AddRow(nameof(action.collideTag), action.collideTag, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .AddRow(nameof(action.storeCollider), action.storeCollider, ctx)
            .AddRow(nameof(action.trigger), action.trigger, ctx)
            .BuildTable();
}
