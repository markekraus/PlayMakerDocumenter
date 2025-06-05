using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionBoolTest(this StringBuilder sb, BoolTest action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(BoolTest)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.boolVariable), action.boolVariable, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.isFalse), action.isFalse, ctx)
            .AddRow(nameof(action.isTrue), action.isTrue, ctx)
            .BuildTable();
}
