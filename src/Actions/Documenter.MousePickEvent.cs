using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionMousePickEvent(this StringBuilder sb, MousePickEvent action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(MousePickEvent)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.GameObject), action.GameObject, ctx)
            .AddRow(nameof(action.ignoreCursorStick), action.ignoreCursorStick, ctx)
            .AddRow(nameof(action.invertMask), action.invertMask, ctx)
            .AddRow(nameof(action.layerMask), action.layerMask, ctx)
            .AddRow(nameof(action.mouseDown), action.mouseDown, ctx)
            .AddRow(nameof(action.mouseOff), action.mouseOff, ctx)
            .AddRow(nameof(action.mouseOver), action.mouseOver, ctx)
            .AddRow(nameof(action.mouseUp), action.mouseUp, ctx)
            .AddRow(nameof(action.rayDistance), action.rayDistance, ctx)
            .BuildTable();
}
