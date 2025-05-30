using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetAudioClip(this StringBuilder sb, SetAudioClip action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetAudioClip)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.audioClip), action.audioClip, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .BuildTable();
}
