using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionPlaySound(this StringBuilder sb, PlaySound action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(PlaySound)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.clip), action.clip, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.position), action.position, ctx)
            .AddRow(nameof(action.volume), action.volume, ctx)
            .BuildTable();
}
