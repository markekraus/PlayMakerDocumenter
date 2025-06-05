using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListRemoveEmptyDoc : FsmActionDoc
{
    internal ArrayListRemoveEmptyDoc(ActionContext Ctx, ArrayListRemoveEmpty action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.proxy), action.proxy);
        this.AddProperty(nameof(action.reference), action.reference);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListRemoveEmptyDoc Document(this ActionContext ctx, ArrayListRemoveEmpty Action) =>
        new(ctx, Action);
}
