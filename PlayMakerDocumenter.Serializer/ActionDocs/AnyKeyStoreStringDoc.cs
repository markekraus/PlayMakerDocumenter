using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record AnyKeyStoreStringDoc : FsmActionDoc
{
    internal AnyKeyStoreStringDoc(ActionContext Ctx, AnyKeyStoreString action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static AnyKeyStoreStringDoc Document(this ActionContext ctx, AnyKeyStoreString Action) =>
        new(ctx, Action);
}
