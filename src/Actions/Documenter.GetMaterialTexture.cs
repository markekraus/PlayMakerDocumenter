using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetMaterialTexture(this StringBuilder sb, GetMaterialTexture action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetMaterialTexture)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.getFromSharedMaterial), action.getFromSharedMaterial, ctx)
            .AddRow(nameof(action.materialIndex), action.materialIndex, ctx)
            .AddRow(nameof(action.namedTexture), action.namedTexture, ctx)
            .AddRow(nameof(action.storedTexture), action.storedTexture, ctx)
            .BuildTable();
}
