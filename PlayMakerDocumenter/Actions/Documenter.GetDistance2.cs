using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetDistance2(this StringBuilder sb, GetDistance2 action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetDistance2)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.orVector3), action.orVector3, ctx)
            .AddRow(nameof(action.orVector3Target), action.orVector3Target, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .AddRow(nameof(action.target), action.target, ctx)
            .BuildTable();
}
