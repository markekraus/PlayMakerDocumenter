using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionRandomIntSeed(this StringBuilder sb, RandomIntSeed action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(RandomIntSeed)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.max), action.max, ctx)
            .AddRow(nameof(action.min), action.min, ctx)
            .AddRow(nameof(action.seed), action.seed, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
