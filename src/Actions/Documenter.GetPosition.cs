using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetPosition(this StringBuilder sb, GetPosition action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetPosition)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.space), action.space, ctx)
            .AddRow(nameof(action.vector), action.vector, ctx)
            .AddRow(nameof(action.x), action.x, ctx)
            .AddRow(nameof(action.y), action.y, ctx)
            .AddRow(nameof(action.z), action.z, ctx)
            .BuildTable();
}
