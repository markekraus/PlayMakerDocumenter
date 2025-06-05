using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetFogColor(this StringBuilder sb, SetFogColor action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFogColor)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.fogColor), action.fogColor, ctx)
            .BuildTable();
}
