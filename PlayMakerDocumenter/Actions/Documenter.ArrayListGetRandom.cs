using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListGetRandom(this StringBuilder sb, ArrayListGetRandom action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListGetRandom)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.failureEvent), action.failureEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.randomIndex), action.randomIndex, ctx)
            .AddRow(nameof(action.randomItem), action.randomItem, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .BuildTable();
}
