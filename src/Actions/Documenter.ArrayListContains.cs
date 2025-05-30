using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListContains(this StringBuilder sb, ArrayListContains action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListContains)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.indexResult), action.indexResult, ctx)
            .AddRow(nameof(action.isContained), action.isContained, ctx)
            .AddRow(nameof(action.isContainedEvent), action.isContainedEvent, ctx)
            .AddRow(nameof(action.isNotContainedEvent), action.isNotContainedEvent, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.variable), action.variable, ctx)
            .BuildTable();
}
