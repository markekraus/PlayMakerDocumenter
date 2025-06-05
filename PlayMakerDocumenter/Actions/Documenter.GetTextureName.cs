using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetTextureName(this StringBuilder sb, GetTextureName action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetTextureName)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.texture), action.texture, ctx)
            .AddRow(nameof(action.textureName), action.textureName, ctx)
            .BuildTable();
}
