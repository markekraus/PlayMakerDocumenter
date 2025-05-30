using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionAnimatorPlay(this StringBuilder sb, AnimatorPlay action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(AnimatorPlay)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.animator), action.animator, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.layer), action.layer, ctx)
            .AddRow(nameof(action.normalizedTime), action.normalizedTime, ctx)
            .AddRow(nameof(action.stateName), action.stateName, ctx)
            .BuildTable();
}
