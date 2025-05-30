using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionPlayRandomSound(this StringBuilder sb, PlayRandomSound action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(PlayRandomSound)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            // .AddRow(nameof(action.audioClips), action.audioClips, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.lastIndex), action.lastIndex, ctx)
            .AddRow(nameof(action.noRepeat), action.noRepeat, ctx)
            .AddRow(nameof(action.position), action.position, ctx)
            .AddRow(nameof(action.randomIndex), action.randomIndex, ctx)
            .AddRow(nameof(action.volume), action.volume, ctx)
            .AddRow(nameof(action.weights), action.weights, ctx)
            .BuildTable();
}
