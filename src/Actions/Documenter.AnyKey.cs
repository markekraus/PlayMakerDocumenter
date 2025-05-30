using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionAnyKey(this StringBuilder sb, AnyKey action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(AnyKey)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.eventTarget), action.eventTarget, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .BuildTable();
}
