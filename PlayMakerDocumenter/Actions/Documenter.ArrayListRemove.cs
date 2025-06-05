using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListRemove(this StringBuilder sb, ArrayListRemove action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListRemove)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.notFoundEvent), action.notFoundEvent, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.variable), action.variable, ctx)
            .BuildTable();
}
