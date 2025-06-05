using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionAudioPlay(this StringBuilder sb, AudioPlay action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(AudioPlay)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.finishedEvent), action.finishedEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.oneShotClip), action.oneShotClip, ctx)
            .AddRow(nameof(action.volume), action.volume, ctx)
            .AddRow(nameof(action.WaitForEndOfClip), action.WaitForEndOfClip, ctx)
            .BuildTable();
}
