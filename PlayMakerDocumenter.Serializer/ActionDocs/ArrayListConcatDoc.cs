using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListConcatDoc : FsmActionDoc
{
    internal ArrayListConcatDoc(ActionContext Ctx, ArrayListConcat action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.arrayListGameObjectTargets), action.arrayListGameObjectTargets);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.referenceTargets), action.referenceTargets);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListConcatDoc Document(this ActionContext ctx, ArrayListConcat Action) =>
        new(ctx, Action);
}
