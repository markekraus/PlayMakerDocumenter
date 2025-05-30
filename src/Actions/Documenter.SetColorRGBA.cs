using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetColorRGBA(this StringBuilder sb, SetColorRGBA action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetColorRGBA)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.alpha), action.alpha, ctx)
            .AddRow(nameof(action.blue), action.blue, ctx)
            .AddRow(nameof(action.colorVariable), action.colorVariable, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.green), action.green, ctx)
            .AddRow(nameof(action.red), action.red, ctx)
            .BuildTable();
}
