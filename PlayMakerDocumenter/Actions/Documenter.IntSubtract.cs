using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionIntSubtract(this StringBuilder sb, IntSubtract action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IntSubtract)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._acc), action._acc, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.intVariable), action.intVariable, ctx)
            .AddRow(nameof(action.perSecond), action.perSecond, ctx)
            .AddRow(nameof(action.subtract), action.subtract, ctx)
            .BuildTable();
}
