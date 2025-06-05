using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetTextureValue(this StringBuilder sb, SetTextureValue action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetTextureValue)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.textureValue), action.textureValue, ctx)
            .AddRow(nameof(action.textureVariable), action.textureVariable, ctx)
            .BuildTable();
}
