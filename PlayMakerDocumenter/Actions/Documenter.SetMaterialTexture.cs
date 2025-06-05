using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetMaterialTexture(this StringBuilder sb, SetMaterialTexture action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetMaterialTexture)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.material), action.material, ctx)
            .AddRow(nameof(action.materialIndex), action.materialIndex, ctx)
            .AddRow(nameof(action.namedTexture), action.namedTexture, ctx)
            .AddRow(nameof(action.texture), action.texture, ctx)
            .BuildTable();
}
