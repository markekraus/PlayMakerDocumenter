using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionHashTableGetNext(this StringBuilder sb, HashTableGetNext action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(HashTableGetNext)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._keys), action._keys, ctx)
            .AddRow(nameof(action.endIndex), action.endIndex, ctx)
            .AddRow(nameof(action.failureEvent), action.failureEvent, ctx)
            .AddRow(nameof(action.finishedEvent), action.finishedEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.key), action.key, ctx)
            .AddRow(nameof(action.loopEvent), action.loopEvent, ctx)
            .AddRow(nameof(action.nextItemIndex), action.nextItemIndex, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.reset), action.reset, ctx)
            .AddRow(nameof(action.result), action.result, ctx)
            .AddRow(nameof(action.startIndex), action.startIndex, ctx)
            .BuildTable();
}
