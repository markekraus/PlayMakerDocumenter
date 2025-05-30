using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListSet(this StringBuilder sb, ArrayListSet action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListSet)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.atIndex), action.atIndex)
            .AddRow(nameof(action.everyFrame), action.everyFrame)
            .AddRow(nameof(action.forceResizeIdNeeded), action.forceResizeIdNeeded)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.reference), action.reference)
            .AddRow(nameof(action.variable), action.variable, ctx)
            .BuildTable();
}
