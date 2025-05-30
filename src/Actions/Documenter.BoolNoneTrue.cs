using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionBoolNoneTrue(this StringBuilder sb, BoolNoneTrue action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(BoolNoneTrue)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.boolVariables), action.boolVariables, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.sendEvent), action.sendEvent, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
