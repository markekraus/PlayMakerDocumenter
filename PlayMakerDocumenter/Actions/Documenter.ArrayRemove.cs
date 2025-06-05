using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayRemove(this StringBuilder sb, ArrayRemove action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayRemove)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.allMatches), action.allMatches, ctx)
            .AddRow(nameof(action.array), action.array, ctx)
            .AddRow(nameof(action.value), action.value, ctx)
            .BuildTable();
}
