using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListReverseDoc : FsmActionDoc
{
    internal ArrayListReverseDoc(ActionContext Ctx, ArrayListReverse action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListReverseDoc Document(this ActionContext ctx, ArrayListReverse Action) =>
        new(ctx, Action);
}
