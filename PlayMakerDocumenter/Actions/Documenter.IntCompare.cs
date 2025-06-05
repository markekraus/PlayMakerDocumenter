using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    

    private static StringBuilder DocActionIntCompare(this StringBuilder sb, IntCompare action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IntCompare)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.integer1), action.integer1, ctx)
            .AddRow(nameof(action.integer2), action.integer2, ctx)
            .AddRow(nameof(action.equal), action.equal, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.greaterThan), action.greaterThan, ctx)
            .AddRow(nameof(action.lessThan), action.lessThan, ctx)
            .BuildTable();
}
