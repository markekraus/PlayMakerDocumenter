using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionAudioMixerGetFloatValue(this StringBuilder sb, AudioMixerGetFloatValue action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(AudioMixerGetFloatValue)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.exposedFloatName), action.exposedFloatName, ctx)
            .AddRow(nameof(action.storeFloatValue), action.storeFloatValue, ctx)
            .AddRow(nameof(action.theMixer), action.theMixer, ctx)
            .BuildTable();
}
