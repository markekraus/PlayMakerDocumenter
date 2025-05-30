using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionAudioFade(this StringBuilder sb, AudioFade action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(AudioFade)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.currentTime), action.currentTime, ctx)
            .AddRow(nameof(action.fadeTo), action.fadeTo, ctx)
            .AddRow(nameof(action.finishEvent), action.finishEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.mode), action.mode, ctx)
            .AddRow(nameof(action.realTime), action.realTime, ctx)
            .AddRow(nameof(action.startingVolume), action.startingVolume, ctx)
            .AddRow(nameof(action.startTime), action.startTime, ctx)
            .AddRow(nameof(action.time), action.time, ctx)
            .BuildTable();
}
