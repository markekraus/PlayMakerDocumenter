using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record PlaySoundDoc : FsmActionDoc
{
    internal PlaySoundDoc(ActionContext Ctx, PlaySound action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.clip), action.clip);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.position), action.position);
        this.AddProperty(nameof(action.volume), action.volume);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static PlaySoundDoc Document(this ActionContext ctx, PlaySound Action) =>
        new(ctx, Action);
}
