using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record PlayRandomSoundDoc : FsmActionDoc
{
    internal PlayRandomSoundDoc(ActionContext Ctx, PlayRandomSound action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        // this.AddProperty(nameof(action.audioClips), action.audioClips);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.lastIndex), action.lastIndex);
        this.AddProperty(nameof(action.noRepeat), action.noRepeat);
        this.AddProperty(nameof(action.position), action.position);
        this.AddProperty(nameof(action.randomIndex), action.randomIndex);
        this.AddProperty(nameof(action.volume), action.volume);
        this.AddProperty(nameof(action.weights), action.weights);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static PlayRandomSoundDoc Document(this ActionContext ctx, PlayRandomSound Action) =>
        new(ctx, Action);
}
