using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayRemoveAll(this StringBuilder sb, ArrayRemoveAll action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayRemoveAll)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.array), action.array, ctx)
            .BuildTable();
}
