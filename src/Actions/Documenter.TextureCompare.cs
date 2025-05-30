using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionTextureCompare(this StringBuilder sb, TextureCompare action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(TextureCompare)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.compareTo), action.compareTo, ctx)
            .AddRow(nameof(action.equalEvent), action.equalEvent, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.notEqualEvent), action.notEqualEvent, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .AddRow(nameof(action.textureVariable), action.textureVariable, ctx)
            .BuildTable();
}
