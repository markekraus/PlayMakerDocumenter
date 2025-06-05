using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionTimeSinceLastPlayAction(this StringBuilder sb, TimeSinceLastPlayAction action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(TimeSinceLastPlayAction)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
