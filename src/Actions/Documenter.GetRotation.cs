using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetRotation(this StringBuilder sb, GetRotation action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetRotation)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.quaternion), action.quaternion, ctx)
            .AddRow(nameof(action.space), action.space, ctx)
            .AddRow(nameof(action.vector), action.vector, ctx)
            .AddRow(nameof(action.xAngle), action.xAngle, ctx)
            .AddRow(nameof(action.yAngle), action.yAngle, ctx)
            .AddRow(nameof(action.zAngle), action.zAngle, ctx)
            .BuildTable();
}
