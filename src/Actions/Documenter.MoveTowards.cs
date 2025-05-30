using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionMoveTowards(this StringBuilder sb, MoveTowards action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(MoveTowards)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.finishDistance), action.finishDistance, ctx)
            .AddRow(nameof(action.finishEvent), action.finishEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.go), action.go, ctx)
            .AddRow(nameof(action.goTarget), action.goTarget, ctx)
            .AddRow(nameof(action.ignoreVertical), action.ignoreVertical, ctx)
            .AddRow(nameof(action.maxSpeed), action.maxSpeed, ctx)
            .AddRow(nameof(action.targetObject), action.targetObject, ctx)
            .AddRow(nameof(action.targetPos), action.targetPos, ctx)
            .AddRow(nameof(action.targetPosition), action.targetPosition, ctx)
            .AddRow(nameof(action.targetPosWithVertical), action.targetPosWithVertical, ctx)
            .BuildTable();
}
