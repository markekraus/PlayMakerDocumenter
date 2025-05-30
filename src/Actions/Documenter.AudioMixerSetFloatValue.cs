using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionAudioMixerSetFloatValue(this StringBuilder sb, AudioMixerSetFloatValue action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(AudioMixerSetFloatValue)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.exposedFloatName), action.exposedFloatName, ctx)
            .AddRow(nameof(action.floatvalue), action.floatvalue, ctx)
            .AddRow(nameof(action.theMixer), action.theMixer, ctx)
            .BuildTable();
}
