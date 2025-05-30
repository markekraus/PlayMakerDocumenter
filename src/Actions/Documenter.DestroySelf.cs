using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionDestroySelf(this StringBuilder sb, DestroySelf action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(DestroySelf)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.delay), action.delay, ctx)
            .AddRow(nameof(action.detachChildren), action.detachChildren, ctx)
            .AddRow(nameof(action.elapsedTime), action.elapsedTime, ctx)
            .AddRow(nameof(action.realTime), action.realTime, ctx)
            .BuildTable();
}
