using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionAudioStop(this StringBuilder sb, AudioStop action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(AudioStop)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.fadeTime), action.fadeTime, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.volume), action.volume, ctx)
            .BuildTable();
}
