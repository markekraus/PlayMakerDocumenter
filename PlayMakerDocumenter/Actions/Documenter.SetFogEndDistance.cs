using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetFogEndDistance(this StringBuilder sb, SetFogEndDistance action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFogEndDistance)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.endDistance), action.endDistance, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .BuildTable();
}
