using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionStringTypewriter(this StringBuilder sb, StringTypewriter action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(StringTypewriter)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._charCount), action._charCount, ctx)
            .AddRow(nameof(action._countTimer), action._countTimer, ctx)
            .AddRow(nameof(action.audioSource), action.audioSource, ctx)
            .AddRow(nameof(action.audioSourceObj), action.audioSourceObj, ctx)
            .AddRow(nameof(action.baseString), action.baseString, ctx)
            .AddRow(nameof(action.block), action.block, ctx)
            .AddRow(nameof(action.d1), action.d1, ctx)
            .AddRow(nameof(action.fBold), action.fBold, ctx)
            .AddRow(nameof(action.fColor), action.fColor, ctx)
            .AddRow(nameof(action.finishEvent), action.finishEvent, ctx)
            .AddRow(nameof(action.fItal), action.fItal, ctx)
            .AddRow(nameof(action.forcedPause), action.forcedPause, ctx)
            .AddRow(nameof(action.fSize), action.fSize, ctx)
            .AddRow(nameof(action.index), action.index, ctx)
            .AddRow(nameof(action.lastChar), action.lastChar, ctx)
            .AddRow(nameof(action.message), action.message, ctx)
            .AddRow(nameof(action.nextChar), action.nextChar, ctx)
            .AddRow(nameof(action.noSoundOnSpaces), action.noSoundOnSpaces, ctx)
            .AddRow(nameof(action.p), action.p, ctx)
            .AddRow(nameof(action.pause), action.pause, ctx)
            .AddRow(nameof(action.punctuation), action.punctuation, ctx)
            .AddRow(nameof(action.punctuationMultiplier), action.punctuationMultiplier, ctx)
            .AddRow(nameof(action.realtime), action.realtime, ctx)
            .AddRow(nameof(action.resultString), action.resultString, ctx)
            .AddRow(nameof(action.richText), action.richText, ctx)
            .AddRow(nameof(action.sound), action.sound, ctx)
            .AddRow(nameof(action.speedMultiplier), action.speedMultiplier, ctx)
            .AddRow(nameof(action.startTime), action.startTime, ctx)
            .AddRow(nameof(action.suffix), action.suffix, ctx)
            .AddRow(nameof(action.timer), action.timer, ctx)
            .AddRow(nameof(action.typingSound), action.typingSound, ctx)
            .AddRow(nameof(action.useSounds), action.useSounds, ctx)
            .BuildTable();
}
