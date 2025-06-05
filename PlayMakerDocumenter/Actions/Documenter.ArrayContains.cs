using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayContains(this StringBuilder sb, ArrayContains action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayContains)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.array), action.array, ctx)
            .AddRow(nameof(action.index), action.index, ctx)
            .AddRow(nameof(action.isContained), action.isContained, ctx)
            .AddRow(nameof(action.isContainedEvent), action.isContainedEvent, ctx)
            .AddRow(nameof(action.isNotContainedEvent), action.isNotContainedEvent, ctx)
            .AddRow(nameof(action.value), action.value, ctx)
            .BuildTable();
}
