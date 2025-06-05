using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record StringTypewriterDoc : FsmActionDoc
{
    internal StringTypewriterDoc(ActionContext Ctx, StringTypewriter action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._charCount), action._charCount);
        this.AddProperty(nameof(action._countTimer), action._countTimer);
        this.AddProperty(nameof(action.audioSource), action.audioSource);
        this.AddProperty(nameof(action.audioSourceObj), action.audioSourceObj);
        this.AddProperty(nameof(action.baseString), action.baseString);
        this.AddProperty(nameof(action.block), action.block);
        this.AddProperty(nameof(action.d1), action.d1);
        this.AddProperty(nameof(action.fBold), action.fBold);
        this.AddProperty(nameof(action.fColor), action.fColor);
        this.AddProperty(nameof(action.finishEvent), action.finishEvent);
        this.AddProperty(nameof(action.fItal), action.fItal);
        this.AddProperty(nameof(action.forcedPause), action.forcedPause);
        this.AddProperty(nameof(action.fSize), action.fSize);
        this.AddProperty(nameof(action.index), action.index);
        this.AddProperty(nameof(action.lastChar), action.lastChar);
        this.AddProperty(nameof(action.message), action.message);
        this.AddProperty(nameof(action.nextChar), action.nextChar);
        this.AddProperty(nameof(action.noSoundOnSpaces), action.noSoundOnSpaces);
        this.AddProperty(nameof(action.p), action.p);
        this.AddProperty(nameof(action.pause), action.pause);
        this.AddProperty(nameof(action.punctuation), action.punctuation);
        this.AddProperty(nameof(action.punctuationMultiplier), action.punctuationMultiplier);
        this.AddProperty(nameof(action.realtime), action.realtime);
        this.AddProperty(nameof(action.resultString), action.resultString);
        this.AddProperty(nameof(action.richText), action.richText);
        this.AddProperty(nameof(action.sound), action.sound);
        this.AddProperty(nameof(action.speedMultiplier), action.speedMultiplier);
        this.AddProperty(nameof(action.startTime), action.startTime);
        this.AddProperty(nameof(action.suffix), action.suffix);
        this.AddProperty(nameof(action.timer), action.timer);
        this.AddProperty(nameof(action.typingSound), action.typingSound);
        this.AddProperty(nameof(action.useSounds), action.useSounds);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static StringTypewriterDoc Document(this ActionContext ctx, StringTypewriter Action) =>
        new(ctx, Action);
}
