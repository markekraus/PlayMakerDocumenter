using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SelectRandomStringDoc : FsmActionDoc
{
    internal SelectRandomStringDoc(ActionContext Ctx, SelectRandomString action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.storeString), action.storeString);
        this.AddProperty(nameof(action.strings), action.strings);
        this.AddProperty(nameof(action.weights), action.weights);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SelectRandomStringDoc Document(this ActionContext ctx, SelectRandomString Action) =>
        new(ctx, Action);
}
