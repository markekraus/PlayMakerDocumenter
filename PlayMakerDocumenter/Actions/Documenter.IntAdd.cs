using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionIntAdd(this StringBuilder sb, IntAdd action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IntAdd)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.add), action.add, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.intVariable), action.intVariable, ctx)
            .BuildTable();
}
