using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionBoolFlip(this StringBuilder sb, BoolFlip action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(BoolFlip)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.boolVariable), action.boolVariable, ctx)
            .BuildTable();
}
