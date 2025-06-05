using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionHashTableGet(this StringBuilder sb, HashTableGet action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(HashTableGet)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.key), action.key, ctx)
            .AddRow(nameof(action.KeyFoundEvent), action.KeyFoundEvent, ctx)
            .AddRow(nameof(action.KeyNotFoundEvent), action.KeyNotFoundEvent, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.result), action.result, ctx)
            .BuildTable();
}
