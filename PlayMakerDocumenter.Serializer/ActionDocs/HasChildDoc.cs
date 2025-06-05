using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record HasChildDoc : FsmActionDoc
{
    internal HasChildDoc(ActionContext Ctx, HasChild action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.childName), action.childName);
        this.AddProperty(nameof(action.found), action.found);
        this.AddProperty(nameof(action.foundEvent), action.foundEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.notFoundEvent), action.notFoundEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.withTag), action.withTag);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static HasChildDoc Document(this ActionContext ctx, HasChild Action) =>
        new(ctx, Action);
}
