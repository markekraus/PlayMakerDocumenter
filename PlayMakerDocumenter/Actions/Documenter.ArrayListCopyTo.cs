using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListCopyTo(this StringBuilder sb, ArrayListCopyTo action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListCopyTo)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.count), action.count, ctx)
            .AddRow(nameof(action.Failed), action.Failed, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.gameObjectTarget), action.gameObjectTarget, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.referenceTarget), action.referenceTarget, ctx)
            .AddRow(nameof(action.startIndex), action.startIndex, ctx)
            .BuildTable();
}
