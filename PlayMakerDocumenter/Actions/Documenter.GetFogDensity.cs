using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFogDensity(this StringBuilder sb, GetFogDensity action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFogDensity)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.density), action.density, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .BuildTable();
}
