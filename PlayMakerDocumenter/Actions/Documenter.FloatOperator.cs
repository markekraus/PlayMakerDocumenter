using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFloatOperator(this StringBuilder sb, FloatOperator action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FloatOperator)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.float1), action.float1, ctx)
            .AddRow(nameof(action.float2), action.float2, ctx)
            .AddRow(nameof(action.operation), action.operation, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
