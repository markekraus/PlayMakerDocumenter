using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetMouseButtonUp(this StringBuilder sb, GetMouseButtonUp action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetMouseButtonUp)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.button), action.button, ctx)
            .AddRow(nameof(action.inUpdateOnly), action.inUpdateOnly, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
