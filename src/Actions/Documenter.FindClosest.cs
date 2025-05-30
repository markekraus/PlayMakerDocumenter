using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFindClosest(this StringBuilder sb, FindClosest action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FindClosest)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.ignoreOwner), action.ignoreOwner, ctx)
            .AddRow(nameof(action.mustBeVisible), action.mustBeVisible, ctx)
            .AddRow(nameof(action.storeDistance), action.storeDistance, ctx)
            .AddRow(nameof(action.storeObject), action.storeObject, ctx)
            .AddRow(nameof(action.withTag), action.withTag, ctx)
            .BuildTable();
}
