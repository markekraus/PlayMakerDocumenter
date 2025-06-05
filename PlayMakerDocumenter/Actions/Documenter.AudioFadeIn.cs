using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionAudioFadeIn(this StringBuilder sb, AudioFadeIn action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(AudioFadeIn)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._audioSource), action._audioSource, ctx)
            .AddRow(nameof(action.currentTime), action.currentTime, ctx)
            .AddRow(nameof(action.finishEvent), action.finishEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.inVolume), action.inVolume, ctx)
            .AddRow(nameof(action.m), action.m, ctx)
            .AddRow(nameof(action.realTime), action.realTime, ctx)
            .AddRow(nameof(action.startTime), action.startTime, ctx)
            .AddRow(nameof(action.time), action.time, ctx)
            .BuildTable();
}
