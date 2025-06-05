using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record BuildStringDoc : FsmActionDoc
{
    internal BuildStringDoc(ActionContext Ctx, BuildString action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.addToEnd), action.addToEnd);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.result), action.result);
        this.AddProperty(nameof(action.separator), action.separator);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.stringParts), action.stringParts);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static BuildStringDoc Document(this ActionContext ctx, BuildString Action) =>
        new(ctx, Action);
}
