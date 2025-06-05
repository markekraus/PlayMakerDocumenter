using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record CommentDoc : FsmActionDoc
{
    internal CommentDoc(ActionContext Ctx, Comment action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.comment), action.comment);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static CommentDoc Document(this ActionContext ctx, Comment Action) =>
        new(ctx, Action);
}
