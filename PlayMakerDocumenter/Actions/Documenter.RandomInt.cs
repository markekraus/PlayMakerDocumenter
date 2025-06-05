using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionRandomInt(this StringBuilder sb, RandomInt action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(RandomInt)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.inclusiveMax), action.inclusiveMax, ctx)
            .AddRow(nameof(action.lastIndex), action.lastIndex, ctx)
            .AddRow(nameof(action.max), action.max, ctx)
            .AddRow(nameof(action.min), action.min, ctx)
            .AddRow(nameof(action.noRepeat), action.noRepeat, ctx)
            .AddRow(nameof(action.randomIndex), action.randomIndex, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
