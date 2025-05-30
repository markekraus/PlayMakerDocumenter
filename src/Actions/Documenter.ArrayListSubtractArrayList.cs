using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListSubtractArrayList(this StringBuilder sb, ArrayListSubtractArrayList action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListSubtractArrayList)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.ObjectWithSubtractArray), action.ObjectWithSubtractArray, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.SubtractReference), action.SubtractReference, ctx)
            .AddRow(nameof(action.Type), action.Type, ctx)
            .BuildTable();
}
