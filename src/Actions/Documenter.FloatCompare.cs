using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFloatCompare(this StringBuilder sb, FloatCompare action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FloatCompare)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.equal), action.equal, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.float1), action.float1, ctx)
            .AddRow(nameof(action.float2), action.float2, ctx)
            .AddRow(nameof(action.greaterThan), action.greaterThan, ctx)
            .AddRow(nameof(action.lessThan), action.lessThan, ctx)
            .AddRow(nameof(action.tolerance), action.tolerance, ctx)
            .BuildTable();
}
