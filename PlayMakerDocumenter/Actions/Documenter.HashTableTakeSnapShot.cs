using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionHashTableTakeSnapShot(this StringBuilder sb, HashTableTakeSnapShot action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(HashTableTakeSnapShot)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .BuildTable();
}
