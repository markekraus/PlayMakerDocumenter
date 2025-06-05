using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetKeyUp(this StringBuilder sb, GetKeyUp action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetKeyUp)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.key), action.key, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
