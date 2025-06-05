using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFloatAdd(this StringBuilder sb, FloatAdd action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FloatAdd)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.add), action.add, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.floatVariable), action.floatVariable, ctx)
            .AddRow(nameof(action.perSecond), action.perSecond, ctx)
            .BuildTable();
}
