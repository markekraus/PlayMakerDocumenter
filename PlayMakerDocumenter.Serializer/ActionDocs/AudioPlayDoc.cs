using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AudioPlayDoc : FsmActionDoc
{
    internal AudioPlayDoc(ActionContext Ctx, AudioPlay action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.finishedEvent), action.finishedEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.oneShotClip), action.oneShotClip);
        this.AddProperty(nameof(action.volume), action.volume);
        this.AddProperty(nameof(action.WaitForEndOfClip), action.WaitForEndOfClip);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AudioPlayDoc Document(this ActionContext ctx, AudioPlay Action) =>
        new(ctx, Action);
}
