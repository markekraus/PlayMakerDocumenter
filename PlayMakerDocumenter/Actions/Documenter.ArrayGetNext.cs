using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayGetNext(this StringBuilder sb, ArrayGetNext action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayGetNext)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.array), action.array, ctx)
            .AddRow(nameof(action.currentIndex), action.currentIndex, ctx)
            .AddRow(nameof(action.endIndex), action.endIndex, ctx)
            .AddRow(nameof(action.finishedEvent), action.finishedEvent, ctx)
            .AddRow(nameof(action.loopEvent), action.loopEvent, ctx)
            .AddRow(nameof(action.nextItemIndex), action.nextItemIndex, ctx)
            .AddRow(nameof(action.resetFlag), action.resetFlag, ctx)
            .AddRow(nameof(action.result), action.result, ctx)
            .AddRow(nameof(action.startIndex), action.startIndex, ctx)
            .BuildTable();
}
