using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionEnableFOVOffsetAction(this StringBuilder sb, EnableFOVOffsetAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(EnableFOVOffsetAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.EnableOffset), action.EnableOffset, ctx)
            .AddRow(nameof(action.FadeTime), action.FadeTime, ctx)
            .BuildTable();
}
