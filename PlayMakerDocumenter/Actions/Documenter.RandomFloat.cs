using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionRandomFloat(this StringBuilder sb, RandomFloat action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(RandomFloat)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.max), action.max, ctx)
            .AddRow(nameof(action.min), action.min, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
