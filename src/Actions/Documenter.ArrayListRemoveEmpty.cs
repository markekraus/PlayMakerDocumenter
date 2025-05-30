using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListRemoveEmpty(this StringBuilder sb, ArrayListRemoveEmpty action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListRemoveEmpty)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.proxy), action.proxy, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .BuildTable();
}
