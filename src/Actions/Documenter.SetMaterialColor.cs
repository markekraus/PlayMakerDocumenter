using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetMaterialColor(this StringBuilder sb, SetMaterialColor action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetMaterialColor)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.color), action.color, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.material), action.material, ctx)
            .AddRow(nameof(action.materialIndex), action.materialIndex, ctx)
            .AddRow(nameof(action.namedColor), action.namedColor, ctx)
            .BuildTable();
}
