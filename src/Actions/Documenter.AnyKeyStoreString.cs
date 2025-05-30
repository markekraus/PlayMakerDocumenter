using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionAnyKeyStoreString(this StringBuilder sb, AnyKeyStoreString action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(AnyKeyStoreString)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
