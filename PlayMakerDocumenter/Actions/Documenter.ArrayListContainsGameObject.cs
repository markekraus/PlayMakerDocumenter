using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListContainsGameObject(this StringBuilder sb, ArrayListContainsGameObject action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListContainsGameObject)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.gameObjectName), action.gameObjectName, ctx)
            .AddRow(nameof(action.isContained), action.isContained, ctx)
            .AddRow(nameof(action.isContainedEvent), action.isContainedEvent, ctx)
            .AddRow(nameof(action.isNotContainedEvent), action.isNotContainedEvent, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.result), action.result, ctx)
            .AddRow(nameof(action.resultIndex), action.resultIndex, ctx)
            .AddRow(nameof(action.withTag), action.withTag, ctx)
            .BuildTable();
}
