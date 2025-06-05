using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListShuffleDoc : FsmActionDoc
{
    internal ArrayListShuffleDoc(ActionContext Ctx, ArrayListShuffle action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.shufflingRange), action.shufflingRange);
        this.AddProperty(nameof(action.startIndex), action.startIndex);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListShuffleDoc Document(this ActionContext ctx, ArrayListShuffle Action) =>
        new(ctx, Action);
}
