using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayShuffleDoc : FsmActionDoc
{
    internal ArrayShuffleDoc(ActionContext Ctx, ArrayShuffle action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.array), action.array);
        this.AddProperty(nameof(action.shufflingRange), action.shufflingRange);
        this.AddProperty(nameof(action.startIndex), action.startIndex);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayShuffleDoc Document(this ActionContext ctx, ArrayShuffle Action) =>
        new(ctx, Action);
}
